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
    public class EmpresaColectivoDB : DALBase
    {

        public static EmpresaColectivoDTO GetempresaColectivoByID(int idEmpresaColectivo)
        {
            SqlCommand command = GetDbSprocCommand("usp_EmpresaColectivo_GetByID");
            command.Parameters.Add(CreateParameter("@idEmpresaColectivo", idEmpresaColectivo));
            return GetSingleDTO<EmpresaColectivoDTO>(ref command);
        }

        public static List<EmpresaColectivoDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_EmpresaColectivo_GetAll");
            return GetDTOList<EmpresaColectivoDTO>(ref command);
        }

        public static void SaveEmpresaColectivo(ref EmpresaColectivoDTO EmpresaColectivo)
        {
            SqlCommand command;

            if (EmpresaColectivo.IsNew)
            {
                command = GetDbSprocCommand("usp_EmpresaColectivo_Insert");
                command.Parameters.Add(CreateOutputParameter("@idEmpresaColectivo", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_EmpresaColectivo_Update");
                command.Parameters.Add(CreateParameter("@idEmpresaColectivo", EmpresaColectivo.idEmpresaColectivoDTO));
            }

            command.Parameters.Add(CreateParameter("@nombre", EmpresaColectivo.nombreDTO, 50));
            command.Parameters.Add((CreateParameter("@telefono", EmpresaColectivo.telefonoDTO, 13)));
            command.Parameters.Add((CreateParameter("@paginaWeb", EmpresaColectivo.paginaWebDTO, 50 )));

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (EmpresaColectivo.IsNew)
            {
                EmpresaColectivo.idEmpresaColectivoDTO = (int)command.Parameters["@idEmpresaColectivo"].Value;
                
            }
        }



    }
}
