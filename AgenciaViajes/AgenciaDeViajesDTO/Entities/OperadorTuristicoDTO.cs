using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class OperadorTuristicoDTO : CommonBase
    {
        public int IdOperadorTuristico { get; set; }
        public int IdTipoDestino { get; set; }
        public int Calificacion { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string PaginaWeb { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }

        public OperadorTuristicoDTO()
        {
            IdOperadorTuristico = Int_NullValue;
            IdTipoDestino = Int_NullValue;
            Calificacion = Int_NullValue;
            Descripcion = String_NullValue;
            Direccion = String_NullValue;
            Email = String_NullValue;
            Nombre = String_NullValue;
            PaginaWeb = String_NullValue;
            Telefono = String_NullValue;
            Activo = Boolean_NullValue;
            FechaAlta = DateTime_NullValue;
        }
    }
}
