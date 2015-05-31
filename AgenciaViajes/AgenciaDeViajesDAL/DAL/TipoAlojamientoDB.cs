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
    class TipoAlojamientoDB : DALBase
    {
        public static TipoAlojamientoDTO GetTipoAlojamientoByID(int IDTipoAlojamiento)
        {
            SqlCommand command = GetDbSprocCommand("usp_TipoAlojamiento_GetByID");
            command.Parameters.Add(CreateParameter("@IDTipoAlojamiento", IDTipoAlojamiento));
            return GetSingleDTO<TipoAlojamientoDTO>(ref command);
        }

        public static List<TipoAlojamientoDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_TipoAlojamiento_GetAll");
            return GetDTOList<TipoAlojamientoDTO>(ref command);
        }

        public static void SaveTipoAlojamiento(ref TipoAlojamientoDTO TipoAlojamiento)
        {
            SqlCommand command;

            if (TipoAlojamiento.IsNew)
            {
                command = GetDbSprocCommand("usp_TipoAlojamiento_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDTipoAlojamiento", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_TipoAlojamiento_Update");
                command.Parameters.Add(CreateParameter("@IDTipoAlojamiento", TipoAlojamiento.idTipoAlojamientoDTO));
            }

   
            command.Parameters.Add(CreateParameter("@Descripcion", TipoAlojamiento.descripcionDTO,50));
           
            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (TipoAlojamiento.IsNew)
            {
                TipoAlojamiento.idTipoAlojamientoDTO = (int)command.Parameters["@IDTipoAlojamiento"].Value;
            }
        }

    }
}
