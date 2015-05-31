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
            SqlCommand command;

            if (compra.IsNew)
            {
                command = GetDbSprocCommand("usp_Compra_Insert");
                command.Parameters.Add(CreateOutputParameter("@idcompra", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_Compra_Update");
                command.Parameters.Add(CreateParameter("@idCompra", compra.idCompraDTO));
            }

            command.Parameters.Add(CreateParameter("@idOperadorTuristico", compra.idOperadorTuristicoDTO));
            command.Parameters.Add(CreateParameter("@idDetalleCompra", compra.idDetalleCompraDTO));
            command.Parameters.Add(CreateParameter("@fechaCompra", compra.fechaCompraDTO));
            command.Parameters.Add(CreateParameter("@fechaPago", compra.fechaPagoDTO));
            command.Parameters.Add(CreateParameter("@monto", compra.montoDTO));
            command.Parameters.Add(CreateParameter("@saldo", compra.saldoDTO));


            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (compra.IsNew)
            {
                compra.idCompraDTO= (int)command.Parameters["@idCompra"].Value;
            }
        }

    }
}
