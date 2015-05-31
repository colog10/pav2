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

            //idEmpleado
            if(!reader.IsDBNull(Ord_idEmpleado)) { empleadoDTO.idEmpleadoDTO = reader.GetInt32(Ord_idEmpleado);}
            
            //legajo
            if(!reader.IsDBNull(Ord_legajo)) { empleadoDTO.legajoDTO = reader.GetInt32(Ord_legajo);}

            //apellido
            if(!reader.IsDBNull(Ord_apellido)) { empleadoDTO.apellidoDTO = reader.GetString(Ord_apellido);}

            //nombre
            if(!reader.IsDBNull(Ord_nombre)) { empleadoDTO.nombreDTO = reader.GetString(Ord_apellido);}

            //fechaAlta
            if(!reader.IsDBNull(Ord_fechaAlta)) { empleadoDTO.fechaAltaDTO = reader.GetDateTime(Ord_fechaAlta);}

            //fechaBaja
            if(!reader.IsDBNull(Ord_fechaBaja)) { empleadoDTO.fechaBajaDTO = reader.GetDateTime(Ord_fechaBaja);}

            //idUsuario
            if(!reader.IsDBNull(Ord_idUsuario)) { empleadoDTO.idUsuarioDTO = reader.GetInt32(Ord_idUsuario);}

            //activo
            if(!reader.IsDBNull(Ord_activo)) { empleadoDTO.activoDTO = reader.GetBoolean(Ord_activo);}

            //supervisor
            if(!reader.IsDBNull(Ord_supervisor)) { empleadoDTO.supervisorDTO = reader.GetBoolean(Ord_supervisor);}
            
            return empleadoDTO;
        }

    }
}
