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
    class VentaDB : DALBase
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

        public static void SaveServicioAlojamiento(ref VentaDTO Venta)
        {
            SqlCommand command;

            if (Venta.IsNew)
            {
                command = GetDbSprocCommand("usp_Venta_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDVenta", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_Venta_Update");
                command.Parameters.Add(CreateParameter("@IDVenta", Venta.numeroVentaDTO));
            }

            command.Parameters.Add(CreateParameter("@CuidadDestino", Venta.ciudadDestinoDTO));
            command.Parameters.Add(CreateParameter("@CuidadOrigen", Venta.ciudadOrigenDTO));
            command.Parameters.Add(CreateParameter("@Comision", Venta.comisionDTO));
            command.Parameters.Add(CreateParameter("@documentoViajero", Venta.documentoViajeDTO));
            command.Parameters.Add(CreateParameter("@FechaRetorno", Venta.fechaRetornoDTO));
            command.Parameters.Add(CreateParameter("@FechaSalida", Venta.fechaSalidaDTO));
            command.Parameters.Add(CreateParameter("@FechaVenta", Venta.fechaVentaDTO));
            command.Parameters.Add(CreateParameter("@IDCliente", Venta.idClienteDTO));
            command.Parameters.Add(CreateParameter("@IDSeguroViajero", Venta.idSeguroViajeroDTO));
            command.Parameters.Add(CreateParameter("@IDServicioAlojamiento", Venta.idServicioAlojamientoDTO));
            command.Parameters.Add(CreateParameter("@IDServicioTraslado", Venta.idServicioTrasladoDTO));
            command.Parameters.Add(CreateParameter("@IDVendedor", Venta.idVendedorDTO));
            command.Parameters.Add(CreateParameter("@IDDetalleVenta", Venta.idVentaDetalleDTO));
            command.Parameters.Add(CreateParameter("@Monto", Venta.montoDTO));
            command.Parameters.Add(CreateParameter("@MontoViajero", Venta.motivoViajeDTO));
            command.Parameters.Add(CreateParameter("@PaisDestino", Venta.paisDestinoDTO,3));
            command.Parameters.Add(CreateParameter("@PaisOrigen", Venta.paisOrigenDTO,3));


            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (Venta.IsNew)
            {
                Venta.numeroVentaDTO= (int)command.Parameters["@IDVenta"].Value;
            }
        }

    }
}
