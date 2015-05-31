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
    public class PaisDB : DALBase
    {
        public static PaisDTO GetPaisByID(int IDPais)
        {
            SqlCommand command = GetDbSprocCommand("usp_Paises_GetByID");
            command.Parameters.Add(CreateParameter("@IDPais", IDPais));
            return GetSingleDTO<PaisDTO>(ref command);
        }

        public static List<PaisDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_Paises_GetAll");
            return GetDTOList<PaisDTO>(ref command);
        }

        public static void SavePais(ref PaisDTO Pais)
        {
            SqlCommand command;

            if (Pais.IsNew)
            {
                command = GetDbSprocCommand("usp_Paises_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDPais", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_Paises_Update");
                command.Parameters.Add(CreateParameter("@PaisCodigo", Pais.PaisCodigo, 3));
            }

            command.Parameters.Add(CreateParameter("@PaisArea", Pais.PaisArea));
            command.Parameters.Add(CreateParameter("@PaisCapital", Pais.PaisCapital));
            command.Parameters.Add(CreateParameter("@PaisCodigo2", Pais.PaisCodigo2, 3));
            command.Parameters.Add(CreateParameter("@PaisContinente", Pais.PaisContinente, 50));
            command.Parameters.Add(CreateParameter("@PaisExpectativaDeVida", Pais.PaisExpectativaDeVida));
            command.Parameters.Add(CreateParameter("@PaisGobierno", Pais.PaisGobierno, 45));
            command.Parameters.Add(CreateParameter("@PaisIndependencia", Pais.PaisIndependencia));
            command.Parameters.Add(CreateParameter("@PaisJefeDeEstado", Pais.PaisJefeDeEstado, 60));
            command.Parameters.Add(CreateParameter("@PaisNombre", Pais.PaisNombre, 52));
            command.Parameters.Add(CreateParameter("@PaisNombreLocal", Pais.PaisNombreLocal, 45));
            command.Parameters.Add(CreateParameter("@PaisPoblacion", Pais.PaisPoblacion));
            command.Parameters.Add(CreateParameter("@PaisProductoInternoBruto", Pais.PaisProductoInternoBruto));
            command.Parameters.Add(CreateParameter("@PaisProductoInternoBrutoAntiguo", Pais.PaisProductoInternoBrutoAntiguo));
            command.Parameters.Add(CreateParameter("@PaisRegion", Pais.PaisRegion, 26));
            

            


            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (Pais.IsNew)
            {
                Pais.PaisCodigo = (string)command.Parameters["@PaisCodigo"].Value;
            }
        }

    }
}
