using AgenciaDeViajesDAL.Util;
using AgenciaDeViajesDTO.Entities;
using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDAL.Parsers
{
    internal class DTOParser_Empleado : DTOParserSQLClient
    {
        private int Ord_idEmpleado;
        private int Ord_legajo;
        private int Ord_apellido;
        private int Ord_nombre;
        private int Ord_fechaAlta;
        private int Ord_fechaBaja;
        private int Ord_idUsuario;
        private int Ord_activo;
        private int Ord_supervisor;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_idEmpleado = reader.GetOrdinal("idEmpleado");
            Ord_legajo = reader.GetOrdinal("legajo");
            Ord_apellido = reader.GetOrdinal("apellido");
            Ord_nombre = reader.GetOrdinal("nombre");
            Ord_fechaAlta = reader.GetOrdinal("fechaAlta");
            Ord_fechaBaja = reader.GetOrdinal("fechaBaja");
            Ord_idUsuario = reader.GetOrdinal("idUsuario");
            Ord_activo = reader.GetOrdinal("activo");
            Ord_supervisor = reader.GetOrdinal("supervisor");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            EmpleadoDTO empleadoDTO = new EmpleadoDTO();

            //IdEmpleado
            if(!reader.IsDBNull(Ord_idEmpleado)) { empleadoDTO.IdEmpleado = reader.GetInt32(1);}
            
            //Legajo
            if(!reader.IsDBNull(Ord_legajo)) { empleadoDTO.Legajo = reader.GetInt32(Ord_legajo);}

            //Apellido
            if(!reader.IsDBNull(Ord_apellido)) { empleadoDTO.Apellido = reader.GetString(Ord_apellido);}

            //Nombre
            if(!reader.IsDBNull(Ord_nombre)) { empleadoDTO.Nombre = reader.GetString(Ord_nombre);}

            //FechaAlta
            if(!reader.IsDBNull(Ord_fechaAlta)) { empleadoDTO.FechaAlta = reader.GetDateTime(Ord_fechaAlta);}

            //FechaBaja
            if(!reader.IsDBNull(Ord_fechaBaja)) { empleadoDTO.FechaBaja = reader.GetDateTime(Ord_fechaBaja);}

            //IdUsuario
            if(!reader.IsDBNull(Ord_idUsuario)) { empleadoDTO.IdUsuario = reader.GetInt32(Ord_idUsuario);}

            //Activo
            if(!reader.IsDBNull(Ord_activo)) { empleadoDTO.Activo = reader.GetBoolean(Ord_activo);}

            //Supervisor
            if(!reader.IsDBNull(Ord_supervisor)) { empleadoDTO.Supervisor = reader.GetBoolean(Ord_supervisor);}
            
            return empleadoDTO;
        }

    }
}
