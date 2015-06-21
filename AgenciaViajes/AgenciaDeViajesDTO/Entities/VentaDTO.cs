using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class VentaDTO : DTOBase
    {
        public int numeroVentaDTO {get; set;}
        public int idClienteDTO { get; set; }
        public int idVendedorDTO {get; set;}
        public float montoDTO { get; set; }
        public float comisionDTO { get; set; }
        public int motivoViajeDTO { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime fechaVentaDTO { get; set; }

        public List<VentaDetalleDTO> DetallesVenta { get; set; }

       public VentaDTO ()
        {
            numeroVentaDTO = Int_NullValue;
            idClienteDTO = Int_NullValue;
            idVendedorDTO = Int_NullValue;
            montoDTO = Float_NullValue;
            comisionDTO = Int_NullValue;
            motivoViajeDTO = Int_NullValue;
            NumeroFactura = Int_NullValue;
            fechaVentaDTO = DateTime_NullValue;
        }





       
    }
}
