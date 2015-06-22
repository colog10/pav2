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
        public decimal montoDTO { get; set; }
        public float comisionDTO { get; set; }
        public int motivoViajeDTO { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime fechaVentaDTO { get; set; }
        public ClienteDTO Cliente{get;set;}
        public EmpleadoDTO Vendedor{get;set;}

        public string NombreCliente{
            get{
                string nombre = "";
                if (Cliente != null)
                    nombre = Cliente.razonSocialDTO;
                return nombre;
            }
        }

         public string NombreVendedor{
             get{
                 string nombre = "";
                 if (Vendedor != null)
                     nombre = Vendedor.Nombre;
                 return nombre;
             }
         }

        public int LegajoVendedor{
            get
            {
                int legajo = 0;
                if (Cliente != null)
                    legajo = Vendedor.Legajo;
                return legajo;
                
            }
        }
                        
            



        public List<VentaDetalleDTO> DetallesVenta { get; set; }

       public VentaDTO ()
        {
            numeroVentaDTO = Int_NullValue;
            idClienteDTO = Int_NullValue;
            idVendedorDTO = 3;
            montoDTO = Decimal_NullValue;
            comisionDTO = Int_NullValue;
            motivoViajeDTO = Int_NullValue;
            NumeroFactura = Int_NullValue;
            fechaVentaDTO = DateTime_NullValue;
        }





       
    }
}
