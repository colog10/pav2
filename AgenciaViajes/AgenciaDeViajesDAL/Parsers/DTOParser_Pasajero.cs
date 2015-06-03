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
    internal class DTOParser_Pasajero : DTOParserSQLClient
    {
        private int Ord_IdPasajero;
        private int Ord_Apellido;
        private int Ord_Nombre;
        private int Ord_IdTipoDocumento;
        private int Ord_NumeroDocumento;
        private int Ord_Cuilcuit1;
        private int Ord_Cuilcuit2;
        private int Ord_Cuilcuit3;
        private int Ord_IdEstadoCivil;
        private int Ord_FechaNacimiento;
        private int Ord_IdNacionalidad;
        private int Ord_Profesion;
        private int Ord_Domicilio;
        private int Ord_Telefono;
        private int Ord_Movil;
        private int Ord_Email;
        private int Ord_Eliminado;
        private int Ord_Activo;
        
        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_IdPasajero = reader.GetOrdinal("IdPasajero");
            Ord_Apellido = reader.GetOrdinal("Apellido");
            Ord_Nombre = reader.GetOrdinal("Nombre");
            Ord_IdTipoDocumento = reader.GetOrdinal("IdTipoDocumento");
            Ord_NumeroDocumento = reader.GetOrdinal("NumeroDocumento");
            Ord_Cuilcuit1 = reader.GetOrdinal("Cuilcuit1");
            Ord_Cuilcuit2 = reader.GetOrdinal("Cuilcuit2");
            Ord_Cuilcuit3 = reader.GetOrdinal("Cuilcuit3");
            Ord_IdEstadoCivil = reader.GetOrdinal("IdEstadoCivil");
            Ord_FechaNacimiento = reader.GetOrdinal("FechaNacimiento");
            Ord_IdNacionalidad = reader.GetOrdinal("IdNacionalidad");
            Ord_Profesion = reader.GetOrdinal("Profesion");
            Ord_Domicilio = reader.GetOrdinal("Domicilio");
            Ord_Telefono = reader.GetOrdinal("Telefono");
            Ord_Movil = reader.GetOrdinal("Movil");
            Ord_Email = reader.GetOrdinal("Email");
            Ord_Eliminado = reader.GetOrdinal("Eliminado");
            Ord_Activo = reader.GetOrdinal("Activo");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            PasajeroDTO pasajero = new PasajeroDTO();
            // IdPasajero
            if (!reader.IsDBNull(Ord_IdPasajero))
            {
                pasajero.IdPasajero = reader.GetInt32(Ord_IdPasajero);
            }
            // Apellido
            if (!reader.IsDBNull(Ord_Apellido))
            {
                pasajero.Apellido = reader.GetString(Ord_Apellido);
            }
            // Nombre
            if (!reader.IsDBNull(Ord_Nombre))
            {
                pasajero.Nombre = reader.GetString(Ord_Nombre);
            }
            // IdTipoDocumento
            if (!reader.IsDBNull(Ord_IdTipoDocumento))
            {
                pasajero.IdTipoDocumento = reader.GetInt32(Ord_IdTipoDocumento);
            }
            // NumeroDocumento
            if (!reader.IsDBNull(Ord_NumeroDocumento))
            {
                pasajero.NumeroDocumento = reader.GetInt32(Ord_NumeroDocumento);
            }
            // Cuilcuit1
            if (!reader.IsDBNull(Ord_Cuilcuit1))
            {
                pasajero.Cuilcuit1 = reader.GetString(Ord_Cuilcuit1);
            }
            // Cuilcuit2
            if (!reader.IsDBNull(Ord_Cuilcuit2))
            {
                pasajero.Cuilcuit2 = reader.GetString(Ord_Cuilcuit2);
            }
            // Cuilcuit3
            if (!reader.IsDBNull(Ord_Cuilcuit3))
            {
                pasajero.Cuilcuit3 = reader.GetString(Ord_Cuilcuit3);
            }
            // IdEstadoCivil
            if (!reader.IsDBNull(Ord_IdEstadoCivil))
            {
                pasajero.IdEstadoCivil = reader.GetInt32(Ord_IdEstadoCivil);
            }
            // FechaNacimiento
            if (!reader.IsDBNull(Ord_FechaNacimiento))
            {
                pasajero.FechaNacimiento = reader.GetDateTime(Ord_FechaNacimiento);
            }
            // IdNacionalidad
            if (!reader.IsDBNull(Ord_IdNacionalidad))
            {
                pasajero.IdNacionalidad = reader.GetString(Ord_IdNacionalidad);
            }
            // Profesion
            if (!reader.IsDBNull(Ord_Profesion))
            {
                pasajero.Profesion = reader.GetString(Ord_Profesion);
            }


            // Domicilio
            if (!reader.IsDBNull(Ord_Domicilio))
            {
                pasajero.Domicilio = reader.GetString(Ord_Domicilio);
            }
            // Telefono
            if (!reader.IsDBNull(Ord_Telefono))
            {
                pasajero.Telefono = reader.GetString(Ord_Telefono);
            }
            // Movil
            if (!reader.IsDBNull(Ord_Movil))
            {
                pasajero.Movil = reader.GetString(Ord_Movil);
            }
            // Email
            if (!reader.IsDBNull(Ord_Email))
            {
                pasajero.Email = reader.GetString(Ord_Email);
            }
            // Eliminado
            if (!reader.IsDBNull(Ord_Eliminado))
            {
                pasajero.Eliminado = reader.GetString(Ord_Eliminado);
            }
            // Activo
            if (!reader.IsDBNull(Ord_Activo))
            {
                pasajero.Activo = reader.GetBoolean(Ord_Activo);
            }

            return pasajero;
        }
    }
}
