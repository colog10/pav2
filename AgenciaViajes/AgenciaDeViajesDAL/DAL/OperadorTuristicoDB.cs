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
    public class OperadorTuristicoDB : DALBase
    {
        public static OperadorTuristicoDTO GetOperadorTuristicoByID(int IDOperadorTuristico)
        {
            SqlCommand command = GetDbSprocCommand("usp_OperadoresTuristicos_GetByID");
            command.Parameters.Add(CreateParameter("@IDOperadorTuristico", IDOperadorTuristico));
            return GetSingleDTO<OperadorTuristicoDTO>(ref command);
        }

        public static List<OperadorTuristicoDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_OperadoresTuristicos_GetAll");
            return GetDTOList<OperadorTuristicoDTO>(ref command);
        }

        public static void SaveOperadorTuristico(ref OperadorTuristicoDTO operadorTuristico)
        {
            SqlCommand command;

            if (operadorTuristico.IsNew)
            {
                command = GetDbSprocCommand("usp_OperadoresTuristicos_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDOperadorTuristico", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_OperadoresTuristicos_Update");
                command.Parameters.Add(CreateParameter("@IDOperadorTuristico", operadorTuristico.IdOperadorTuristico));
            }

            command.Parameters.Add(CreateParameter("@Descripcion", operadorTuristico.Descripcion, 30));
            command.Parameters.Add(CreateParameter("@Activo", operadorTuristico.Activo));
            command.Parameters.Add(CreateParameter("@Calificacion", operadorTuristico.Calificacion));
            command.Parameters.Add(CreateParameter("@Direccion", operadorTuristico.Direccion, 100));
            command.Parameters.Add(CreateParameter("@Email", operadorTuristico.Email, 35));
            command.Parameters.Add(CreateParameter("@FechaAlta", operadorTuristico.FechaAlta));
            command.Parameters.Add(CreateParameter("@IdTipoDestino", operadorTuristico.IdTipoDestino));
            command.Parameters.Add(CreateParameter("@Nombre", operadorTuristico.Nombre, 50));
            command.Parameters.Add(CreateParameter("@PaginaWeb", operadorTuristico.PaginaWeb, 50));
            command.Parameters.Add(CreateParameter("@Telefono", operadorTuristico.Telefono, 20));
            
            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (operadorTuristico.IsNew)
            {
                operadorTuristico.IdOperadorTuristico = (int)command.Parameters["@IDOperadorTuristico"].Value;
            }
        }



        public static List<OperadorTuristicoDTO> GetByTermino(string termino)
        {
            SqlCommand command = GetDbSprocCommand("usp_OperadorTuristico_GetByTermino");
            command.Parameters.Add(CreateParameter("@Termino", termino, 70));
            return GetDTOList<OperadorTuristicoDTO>(ref command);
        }
    }
}
