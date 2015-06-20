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
            SqlCommand command = GetDbSprocCommand("usp_Pasajero_GetByID");
            command.Parameters.Add(CreateParameter("@IDPasajero", IDPasajero));
            return GetSingleDTO<PasajeroDTO>(ref command);
        }

        public static List<PasajeroDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_Pasajero_GetAll");
            return GetDTOList<PasajeroDTO>(ref command);
        }

        public static void SavePasajero(ref PasajeroDTO Pasajero)
        {
            SqlCommand command;

            if (Pasajero.IsNew)
            {
                command = GetDbSprocCommand("usp_Pasajero_Insert");
                command.Parameters.Add(CreateOutputParameter("@idPasajero", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_Pasajero_Update");
                command.Parameters.Add(CreateParameter("@idPasajero", Pasajero.IdPasajero));
            }

            command.Parameters.Add(CreateParameter("@activo", Pasajero.Activo));
            command.Parameters.Add(CreateParameter("@apellido", Pasajero.Apellido, 50));
            command.Parameters.Add(CreateParameter("@cuilcuit1", Pasajero.Cuilcuit1, 2));
            command.Parameters.Add(CreateParameter("@cuilcuit2", Pasajero.Cuilcuit2, 8));
            command.Parameters.Add(CreateParameter("@cuilcuit3", Pasajero.Cuilcuit3, 1));
            command.Parameters.Add(CreateParameter("@domicilio", Pasajero.Domicilio, 100));
            command.Parameters.Add(CreateParameter("@eliminado", Pasajero.Eliminado, 1));
            command.Parameters.Add(CreateParameter("@email", Pasajero.Email, 50));
            command.Parameters.Add(CreateParameter("@fechaNacimiento", Pasajero.FechaNacimiento));
            command.Parameters.Add(CreateParameter("@idEstadoCivil", Pasajero.IdEstadoCivil));
            command.Parameters.Add(CreateParameter("@idNacionalidad", Pasajero.IdNacionalidad,3));
            command.Parameters.Add(CreateParameter("@idTipoDocumento", Pasajero.IdTipoDocumento));
            command.Parameters.Add(CreateParameter("@movil", Pasajero.Movil, 50));
            command.Parameters.Add(CreateParameter("@nombre", Pasajero.Nombre, 50));
            command.Parameters.Add(CreateParameter("@numeroDocumento", Pasajero.NumeroDocumento));
            command.Parameters.Add(CreateParameter("@profesion", Pasajero.Profesion, 50));
            command.Parameters.Add(CreateParameter("@telefono", Pasajero.Telefono, 50));
            



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

        public static void DeletePasajero(int idPasajero)
        {
            SqlCommand command;
            command = GetDbSprocCommand("usp_Pasajero_Delete");
            command.Parameters.Add(CreateParameter("@idPasajero", idPasajero));

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();  
        }

       
    }
}
