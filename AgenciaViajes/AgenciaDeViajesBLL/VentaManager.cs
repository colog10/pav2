using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaDeViajesDAL.DAL;

namespace AgenciaDeViajesBLL
{
    public class VentaManager
    {
        public static void SaveVenta(VentaDTO venta)
        {
            VentaDB.SaveVenta(ref venta);
        }

        public static List<VentaDTO> GetVentas(DateTime fechaVenta, int nroFactura, string nombreCliente, int idVendedor)
        {
            return VentaDB.GetVentas(fechaVenta, nroFactura, nombreCliente, idVendedor);
        }
    }
}
