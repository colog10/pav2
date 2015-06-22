using AgenciaDeViajesDAL.Util;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDAL.DAL
{
    public class VentaDB : DALBase
    {
        public static VentaDTO GetServicioAlojamientoByID(int IDVenta)
        {
            SqlCommand command = GetDbSprocCommand("usp_Venta_GetByID");
            command.Parameters.Add(CreateParameter("@IDVenta", IDVenta));
            return GetSingleDTO<VentaDTO>(ref command);
        }

        public static List<VentaDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_Venta_GetAll");
            return GetDTOList<VentaDTO>(ref command);
        }

        public static void SaveVenta(ref VentaDTO Venta)
        {
            SqlCommand command = null;
            
            decimal montoVenta = 0;

            foreach (VentaDetalleDTO rd in Venta.DetallesVenta)
            {
                montoVenta += rd.Monto;
            }

            Venta.montoDTO = montoVenta;
            
            command = GetDbSprocCommand("usp_Venta_Insert");
            command.Parameters.Add(CreateOutputParameter("@IDVenta", SqlDbType.Int));
            command.Parameters.Add(CreateParameter("@Comision", Venta.comisionDTO));
            command.Parameters.Add(CreateParameter("@FechaVenta", Venta.fechaVentaDTO));
            command.Parameters.Add(CreateParameter("@IDCliente", Venta.idClienteDTO));
            command.Parameters.Add(CreateParameter("@IDVendedor", Venta.idVendedorDTO));
            command.Parameters.Add(CreateParameter("@Monto", Venta.montoDTO));
            command.Parameters.Add(CreateParameter("@MotivoViaje", Venta.motivoViajeDTO));
            command.Parameters.Add(CreateParameter("@NumeroFactura", Venta.NumeroFactura));
            
            command.Connection.Open();
            command.Transaction = command.Connection.BeginTransaction();

            command.ExecuteNonQuery();
                                  
            if (Venta.IsNew)
            {
                Venta.numeroVentaDTO= (int)command.Parameters["@IDVenta"].Value;
            }

            foreach (VentaDetalleDTO rd in Venta.DetallesVenta)
            {
                command.Parameters.Clear();
                command.CommandText = "usp_VentaDetalle_Insert";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(CreateOutputParameter("@idDetalleVenta", SqlDbType.Int));
                command.Parameters.Add(CreateParameter("@idPasajero", rd.idPasajeroDTO));
                command.Parameters.Add(CreateParameter("@idDocumentoViaje", rd.idTipoDocumentoViajeDTO));
                command.Parameters.Add(CreateParameter("@idSeguroViajero", rd.idSeguroViajeroDTO));
                command.Parameters.Add(CreateParameter("@idServicioAlojamiento", rd.idServicioAlojamientoDTO));
                command.Parameters.Add(CreateParameter("@idServicioTraslado", rd.idServicioTrasladoDTO));
                command.Parameters.Add(CreateParameter("@idVenta", Venta.numeroVentaDTO));
                command.Parameters.Add(CreateParameter("@monto", rd.Monto));
                command.Parameters.Add(CreateParameter("@idDetalleReserva", rd.idDetalleReservaDTO));
                
                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = "usp_ReservaDetalle_Sell";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(CreateParameter("@idDetalleReserva", rd.idDetalleReservaDTO));

                command.ExecuteNonQuery();
            }
            command.Connection.Close();
        }

        public static List<VentaDTO> GetVentas(DateTime fechaVenta, int nroFactura, string nombreCliente, int idVendedor)
        {
            SqlCommand command = GetDbSprocCommand("usp_Venta_GetByFiltros");
            command.Parameters.Add(CreateParameter("@fechaVenta", fechaVenta));
            command.Parameters.Add(CreateParameter("@nroFactura", nroFactura));
            command.Parameters.Add(CreateParameter("@nombreCliente", nombreCliente, 50));
            command.Parameters.Add(CreateParameter("@idVendedor", idVendedor));
            return GetDTOList<VentaDTO>(ref command);
        }
    }
}
