using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class PasajeroDTO : DTOBase
    {

        public int IdPasajero { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int IdTipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public string Cuilcuit1 { get; set; }
        public string Cuilcuit2 { get; set; }
        public string Cuilcuit3 { get; set; }
        public int IdEstadoCivil { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdNacionalidad { get; set; }
        public string Profesion { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Email { get; set; }
        public string Eliminado { get; set; }
        public bool Activo { get; set; }

        public PasajeroDTO()
        {
            IdPasajero = Int_NullValue;
            Apellido = String_NullValue;
            Nombre = String_NullValue;
            IdTipoDocumento = Int_NullValue;
            NumeroDocumento = Int_NullValue;
            Cuilcuit1 = String_NullValue;
            Cuilcuit2 = String_NullValue;
            Cuilcuit3 = String_NullValue;
            IdEstadoCivil = Int_NullValue;
            FechaNacimiento = DateTime_NullValue;
            IdNacionalidad = Int_NullValue;
            Profesion = String_NullValue;
            Domicilio = String_NullValue;
            Telefono = String_NullValue;
            Movil = String_NullValue;
            Email = String_NullValue;
            Eliminado = String_NullValue;
            Activo = Boolean_NullValue;
        }

      /*  [idPasajero]      NUMERIC (10)   NOT NULL,
    [apellido]        NVARCHAR (50)  NOT NULL,
    [nombre]          NVARCHAR (50)  NOT NULL,
    [idTipoDocumento] NUMERIC (2)    NOT NULL,
    [numeroDocumento] NUMERIC (8)    NOT NULL,
    [cuilcuit1]       NVARCHAR (2)   NULL,
    [cuilcuit2]       NVARCHAR (8)   NULL,
    [cuilcuit3]       NVARCHAR (1)   NULL,
    [idEstadoCivil]   NUMERIC (2)    NULL,
    [fechaNacimiento] DATE           NULL,
    [idNacionalidad]  NVARCHAR (3)   NULL,
    [profesion]       NVARCHAR (50)  NULL,
    [domicilio]       NVARCHAR (100) NULL,
    [telefono]        NVARCHAR (50)  NULL,
    [movil]           NVARCHAR (50)  NULL,
    [email]           NVARCHAR (50)  NULL,
    [eliminado]       CHAR (1)       NULL,
    [activo]          BIT            NULL,
    */
    }
}
