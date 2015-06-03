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
    public class PasajeroDB : DALBase
    {
        public static PasajeroDTO GetPasajeroByID(int IDPasajero)
        {
            SqlCommand command = GetDbSprocCommand("usp_Pasajeros_GetByID");
            command.Parameters.Add(CreateParameter("@IDPasajero", IDPasajero));
            return GetSingleDTO<PasajeroDTO>(ref command);
        }

        public static List<PasajeroDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_Pasajeros_GetAll");
            return GetDTOList<PasajeroDTO>(ref command);
        }

        public static void SavePasajero(ref PasajeroDTO Pasajero)
        {
            SqlCommand command;

            if (Pasajero.IsNew)
            {
                command = GetDbSprocCommand("usp_Pasajeros_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDPasajero", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_Pasajeros_Update");
                command.Parameters.Add(CreateParameter("@IDPasajero", Pasajero.IdPasajero));
            }

            command.Parameters.Add(CreateParameter("@Activo", Pasajero.Activo));
            command.Parameters.Add(CreateParameter("@Apellido", Pasajero.Apellido, 50));
            command.Parameters.Add(CreateParameter("@Cuilcuit1", Pasajero.Cuilcuit1, 2));
            command.Parameters.Add(CreateParameter("@Cuilcuit2", Pasajero.Cuilcuit2, 8));
            command.Parameters.Add(CreateParameter("@Cuilcuit3", Pasajero.Cuilcuit3, 1));
            command.Parameters.Add(CreateParameter("@Domicilio", Pasajero.Domicilio, 100));
            command.Parameters.Add(CreateParameter("@Eliminado", Pasajero.Eliminado, 1));
            command.Parameters.Add(CreateParameter("@Email", Pasajero.Email, 50));
            command.Parameters.Add(CreateParameter("@FechaNacimiento", Pasajero.FechaNacimiento));
            command.Parameters.Add(CreateParameter("@IdEstadoCivil", Pasajero.IdEstadoCivil));
            command.Parameters.Add(CreateParameter("@IdNacionalidad", Pasajero.IdNacionalidad));
            command.Parameters.Add(CreateParameter("@IdPasajero", Pasajero.IdPasajero));
            command.Parameters.Add(CreateParameter("@IdTipoDocumento", Pasajero.IdTipoDocumento));
            command.Parameters.Add(CreateParameter("@Movil", Pasajero.Movil, 50));
            command.Parameters.Add(CreateParameter("@Nombre", Pasajero.Nombre, 50));
            command.Parameters.Add(CreateParameter("@NumeroDocumento", Pasajero.NumeroDocumento));
            command.Parameters.Add(CreateParameter("@Profesion", Pasajero.Profesion, 50));
            command.Parameters.Add(CreateParameter("@Telefono", Pasajero.Telefono, 50));
            



            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (Pasajero.IsNew)
            {
                Pasajero.IdPasajero = (int)command.Parameters["@IDPasajero"].Value;
            }
        }


        public static List<PasajeroDTO> GetByTermino(string termino)
        {
            SqlCommand command = GetDbSprocCommand("usp_Pasajero_GetByTermino");
            command.Parameters.Add(CreateParameter("@Termino", termino, 70));
            return GetDTOList<PasajeroDTO>(ref command);
        }
    }
}
