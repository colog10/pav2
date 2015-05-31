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
    public class CompraDetalleDB : DALBase
    {
        public static CompraDetalleDTO GetDetalleCompraByID(int idDetalleCompra)
        {
            SqlCommand command = GetDbSprocCommand("usp_CompraDetalle_GetByID");
            command.Parameters.Add(CreateParameter("@idDetalleCompra", idDetalleCompra));
            return GetSingleDTO<CompraDetalleDTO>(ref command);
        }

        public static List<CompraDetalleDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_DetalleCompra_GetAll");
            return GetDTOList<CompraDetalleDTO>(ref command);
        }

        public static void SaveDetalleCompra(ref CompraDetalleDTO detalleCompra)
        {
            SqlCommand command;

            if (detalleCompra.IsNew)
            {
                command = GetDbSprocCommand("usp_DetalleCompra_Insert");
                command.Parameters.Add(CreateOutputParameter("@idDetalleCompra", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_DetalleCompra_Update");
                command.Parameters.Add(CreateParameter("@idDetalleCompra", detalleCompra.idDetalleReservaDTO));
            }

            command.Parameters.Add(CreateParameter("@idDetalleReserva", detalleCompra.idDetalleReservaDTO));
            command.Parameters.Add(CreateParameter("@descripcion", detalleCompra.descripcionDTO, 50));

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (detalleCompra.IsNew)
            {
                detalleCompra.idCompraDetalleDTO = (int)command.Parameters["@idDetalleCompra"].Value;
            }
        }

    }
}
