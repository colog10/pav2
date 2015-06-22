using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class CompraDTO : DTOBase
    {
        public int idCompraDTO { get; set; }
        public int idOperadorTuristicoDTO { get; set; }
        public int idDetalleCompraDTO { get; set; }
        public int IdReserva { get; set; }
        public DateTime fechaCompraDTO { get; set; }
        public DateTime fechaPagoDTO { get; set; }
        public decimal montoDTO { get; set; }
        public decimal saldoDTO { get; set; }
        public int NumeroFactura { get; set; }

        public OperadorTuristicoDTO OperadorTuristico { get; set; }

        public string NombreOperadorTuristico { 
            get {
                return OperadorTuristico.Descripcion;
            } 
        }

        public string TelefonoOperadorTuristico
        {
            get
            {
                return OperadorTuristico.Telefono;
            }
        }

        public List<CompraDetalleDTO> Detalles { get; set; }

        public CompraDTO()
        {
            idCompraDTO = Int_NullValue;
            idOperadorTuristicoDTO = Int_NullValue;
            idDetalleCompraDTO = Int_NullValue;
            fechaCompraDTO = DateTime_NullValue;
            fechaPagoDTO = DateTime_NullValue;
            montoDTO = Decimal_NullValue;
            saldoDTO = Decimal_NullValue;
            NumeroFactura = Int_NullValue;
            IdReserva = Int_NullValue;
        }




        
    }
}
