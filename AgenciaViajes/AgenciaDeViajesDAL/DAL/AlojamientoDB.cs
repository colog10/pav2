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
    public class AlojamientoDB : DALBase
    {
        public static AlojamientoDTO GetAlojamientoById (int idAlojamiento)
        {
            SqlCommand command = GetDbSprocCommand("usp_Alojamiento_GetById");
            command.Parameters.Add(CreateParameter("@idAlojamiento", idAlojamiento));
            return GetSingleDTO<AlojamientoDTO> (ref command);
        }

        public static List<AlojamientoDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_Alojamiento_GetAll");
            return GetDTOList<AlojamientoDTO>(ref command);
        }
        
        public static void SaveAlojamiento (ref AlojamientoDTO alojamientoDTO)
        {
            SqlCommand command;

            if (alojamientoDTO.IsNew)
            {
                command = GetDbSprocCommand("usp_AlojamientoDTO_Insert");
                command.Parameters.Add(CreateOutputParameter("@idAlojamiento", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_AlojamientoDTO_Update");
                command.Parameters.Add(CreateParameter("@idAlojamiento", alojamientoDTO.idAlojamientoDTO));
            }

            command.Parameters.Add(CreateParameter("@idTipoAlojamiento", alojamientoDTO.idTipoAlojamientoDTO));
            command.Parameters.Add(CreateParameter("@domicilio", alojamientoDTO.domicilioDTO, 50));
            command.Parameters.Add(CreateParameter("@nombre", alojamientoDTO.nombreDTO, 50));
            command.Parameters.Add(CreateParameter("@telefono", alojamientoDTO.numeroTelefonoDTO, 13));
            
            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (alojamientoDTO.IsNew)
            {
                alojamientoDTO.idAlojamientoDTO = (int)command.Parameters["@idAlojamiento"].Value;
            }
        }
        
        

    }
}
