using AgenciaDeViajesDAL.Util;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDAL.DAL
{
    public class CompraDB : DALBase
    {
        public static CompraDTO GetCompraByID(int idCompra)
        {
            SqlCommand command = GetDbSprocCommand("usp_compra_GetByID");
            command.Parameters.Add(CreateParameter("@idCompra", idCompra));
            return GetSingleDTO<CompraDTO>(ref command);
        }

        public static List<CompraDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_Compra_GetAll");
            return GetDTOList<CompraDTO>(ref command);
        }

        public static void SaveCompra(ref CompraDTO compra)
        {
            SqlCommand command = null;

            double montoCompra = 0;

            foreach (CompraDetalleDTO rd in compra.Detalles)
            {
                montoCompra += rd.Monto;
            }

            compra.montoDTO = (float)montoCompra;

            command = GetDbSprocCommand("usp_Compra_Insert");

            command.Parameters.Add(CreateOutputParameter("@IDCompra", SqlDbType.Int));
            command.Parameters.Add(CreateParameter("@idOperadorTuristico", compra.idOperadorTuristicoDTO));
            command.Parameters.Add(CreateParameter("@fechaCompra", compra.fechaCompraDTO));
            command.Parameters.Add(CreateParameter("@fechaPago", compra.fechaPagoDTO));
            command.Parameters.Add(CreateParameter("@monto", (float)compra.montoDTO));
            command.Parameters.Add(CreateParameter("@saldo", compra.saldoDTO));


            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();

            if (compra.IsNew)
            {
                compra.idCompraDTO = (int)command.Parameters["@IDCompra"].Value;
            }

            foreach (CompraDetalleDTO rd in compra.Detalles)
            {
                command.Parameters.Clear();
                command.CommandText = "usp_CompraDetalle_Insert";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(CreateOutputParameter("@idDetalleCompra", SqlDbType.Int));
                
                command.Parameters.Add(CreateParameter("@idDetalleReserva", rd.idDetalleReservaDTO));
                command.Parameters.Add(CreateParameter("@Monto", (float)rd.Monto));
                command.Parameters.Add(CreateParameter("@Descripcion", rd.descripcionDTO, 50));

                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = "usp_ReservaDetalle_Sell";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(CreateParameter("@idDetalleReserva", rd.idDetalleReservaDTO));

                command.ExecuteNonQuery();
            }


            command.Connection.Close();

            
        }


        
    }
}
