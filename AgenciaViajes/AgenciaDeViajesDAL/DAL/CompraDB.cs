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

            decimal montoCompra = 0;

            foreach (CompraDetalleDTO rd in compra.Detalles)
            {
                montoCompra += rd.Monto;
            }

            compra.montoDTO = montoCompra;

            command = GetDbSprocCommand("usp_Compra_Insert");

            command.Parameters.Add(CreateOutputParameter("@IDCompra", SqlDbType.Int));
            command.Parameters.Add(CreateParameter("@idOperadorTuristico", compra.idOperadorTuristicoDTO));
            command.Parameters.Add(CreateParameter("@fechaCompra", compra.fechaCompraDTO));
            command.Parameters.Add(CreateParameter("@fechaPago", compra.fechaPagoDTO));
            command.Parameters.Add(CreateParameter("@monto", (float)compra.montoDTO));
            command.Parameters.Add(CreateParameter("@saldo", compra.saldoDTO));
            command.Parameters.Add(CreateParameter("@numeroFactura", compra.NumeroFactura));
            command.Parameters.Add(CreateParameter("@idReserva", compra.IdReserva));

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
                command.CommandText = "usp_ReservaDetalle_Buy";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(CreateParameter("@idDetalleReserva", rd.idDetalleReservaDTO));

                command.ExecuteNonQuery();
            }


            command.Connection.Close();

            
        }




        public static List<CompraDTO> GetCompras(DateTime fechaCompra, DateTime fechaReserva, int nroFactura, int idOperadorTuristico)
        {
            SqlCommand command = GetDbSprocCommand("usp_Compra_GetByFiltros");
            command.Parameters.Add(CreateParameter("@fechaCompra", fechaCompra));
            command.Parameters.Add(CreateParameter("@fechaReserva", fechaReserva));
            command.Parameters.Add(CreateParameter("@nroFactura", nroFactura));
            command.Parameters.Add(CreateParameter("@idOperadorTuristico", idOperadorTuristico));

            List<CompraDTO> comprasAux = GetDTOList<CompraDTO>(ref command);
            List<CompraDTO> compras = new List<CompraDTO>();

            foreach (CompraDTO compraAux in comprasAux)
            {
                CompraDTO compra = compraAux;
                compra.OperadorTuristico = OperadorTuristicoDB.GetById(compra.idOperadorTuristicoDTO);
                compras.Add(compra);
            }

            return compras;
        }
    }
}
