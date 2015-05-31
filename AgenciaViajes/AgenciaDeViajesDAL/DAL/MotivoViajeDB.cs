using AgenciaDeViajesDAL.Util;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDAL.Parsers
{
    public class MotivoViajeDB : DALBase
    {
        public static MotivoViajeDTO GetMotivoViajeByID(int IDMotivoViaje)
        {
            SqlCommand command = GetDbSprocCommand("usp_MotivosViajes_GetByID");
            command.Parameters.Add(CreateParameter("@IDMotivoViaje", IDMotivoViaje));
            return GetSingleDTO<MotivoViajeDTO>(ref command);
        }

        public static List<MotivoViajeDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_MotivosViajes_GetAll");
            return GetDTOList<MotivoViajeDTO>(ref command);
        }

        public static void SaveMotivoViaje(ref MotivoViajeDTO motivoViaje)
        {
            SqlCommand command;

            if (motivoViaje.IsNew)
            {
                command = GetDbSprocCommand("usp_MotivosViajes_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDMotivoViaje", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_MotivosViajes_Update");
                command.Parameters.Add(CreateParameter("@IDMotivoViaje", motivoViaje.IdMotivoViaje));
            }

            command.Parameters.Add(CreateParameter("@Descripcion", motivoViaje.Descripcion, 30));
            

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (motivoViaje.IsNew)
            {
                motivoViaje.IdMotivoViaje = (int)command.Parameters["@IDMotivoViaje"].Value;
            }
        }
    }
}
