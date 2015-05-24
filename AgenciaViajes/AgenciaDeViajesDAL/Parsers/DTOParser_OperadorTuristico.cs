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
    internal class DTOParser_OperadorTuristico : DTOParserSQLClient
    {
        private int Ord_IdOperadorTuristico;
        private int Ord_IdTipoDestino; 
        private int Ord_Calificacion;
        private int Ord_Descripcion;
        private int Ord_Direccion;
        private int Ord_Email;
        private int Ord_Nombre;
        private int Ord_PaginaWeb;
        private int Ord_Telefono;
        private int Ord_Activo;
        private int Ord_FechaAlta;


        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_IdOperadorTuristico = reader.GetOrdinal("IdOperadorTuristico");
            Ord_IdTipoDestino = reader.GetOrdinal("IdTipoDestino");
            Ord_Calificacion = reader.GetOrdinal("Calificacion");
            Ord_Descripcion = reader.GetOrdinal("Descripcion");
            Ord_Direccion = reader.GetOrdinal("Direccion");
            Ord_Email = reader.GetOrdinal("Email");
            Ord_Nombre = reader.GetOrdinal("Nombre");
            Ord_PaginaWeb = reader.GetOrdinal("PaginaWeb");
            Ord_Telefono = reader.GetOrdinal("Telefono");
            Ord_Activo = reader.GetOrdinal("Activo");
            Ord_FechaAlta = reader.GetOrdinal("FechaAlta");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            OperadorTuristicoDTO operadorTuristico = new OperadorTuristicoDTO();
            // IdOperadorTuristico
            if (!reader.IsDBNull(Ord_IdOperadorTuristico))
            {
                operadorTuristico.IdOperadorTuristico = reader.GetInt32(Ord_IdOperadorTuristico);
            }
            // IdTipoDestino
            if (!reader.IsDBNull(Ord_IdTipoDestino))
            {
                operadorTuristico.IdTipoDestino = reader.GetInt32(Ord_IdTipoDestino);
            }
            // Calificacion
            if (!reader.IsDBNull(Ord_Calificacion))
            {
                operadorTuristico.Calificacion = reader.GetInt32(Ord_Calificacion);
            }
            // Descripcion
            if (!reader.IsDBNull(Ord_Descripcion))
            {
                operadorTuristico.Descripcion = reader.GetString(Ord_Descripcion);
            }
            // Direccion
            if (!reader.IsDBNull(Ord_Direccion))
            {
                operadorTuristico.Direccion = reader.GetString(Ord_Direccion);
            }
            // Email
            if (!reader.IsDBNull(Ord_Email))
            {
                operadorTuristico.Email = reader.GetString(Ord_Email);
            }
            // Nombre
            if (!reader.IsDBNull(Ord_Nombre))
            {
                operadorTuristico.Nombre = reader.GetString(Ord_Nombre);
            }
            // PaginaWeb
            if (!reader.IsDBNull(Ord_PaginaWeb))
            {
                operadorTuristico.PaginaWeb = reader.GetString(Ord_PaginaWeb);
            }
            // Telefono
            if (!reader.IsDBNull(Ord_Telefono))
            {
                operadorTuristico.Telefono = reader.GetString(Ord_Telefono);
            }
            // Activo
            if (!reader.IsDBNull(Ord_Activo))
            {
                operadorTuristico.Activo = reader.GetBoolean(Ord_Activo);
            }
            // FechaAlta
            if (!reader.IsDBNull(Ord_FechaAlta)) {
                operadorTuristico.FechaAlta = reader.GetDateTime(Ord_FechaAlta); 
            }
            return operadorTuristico;
        }
    }
}
