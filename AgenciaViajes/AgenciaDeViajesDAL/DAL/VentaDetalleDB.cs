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
    class VentaDetalleDB : DALBase
    {
        public static VentaDetalleDTO GetVentaDetalleByID(int IDVentaDetalle)
        {
            SqlCommand command = GetDbSprocCommand("usp_Venta_GetByID");
            command.Parameters.Add(CreateParameter("@IDVentaDetalle", IDVentaDetalle));
            return GetSingleDTO<VentaDetalleDTO>(ref command);
        }

        public static List<VentaDetalleDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_VentaDetalle_GetAll");
            return GetDTOList<VentaDetalleDTO>(ref command);
        }

        public static void SaveVentaDetalle(ref VentaDetalleDTO VentaDetalle)
        {
            SqlCommand command;

            if (VentaDetalle.IsNew)
            {
                command = GetDbSprocCommand("usp_VentaDetalle_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDVenta", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_VentaDetalle_Update");
                command.Parameters.Add(CreateParameter("@IDVentaDetalle", VentaDetalle.idDetalleVentaDTO));
            }

            command.Parameters.Add(CreateParameter("@FechaPasaporteDesde", VentaDetalle.fechaPasaporteDesdeDTO));
            command.Parameters.Add(CreateParameter("@FechaPasaporteHasta", VentaDetalle.fechaPasaporteHastaDTO));
            command.Parameters.Add(CreateParameter("@FechaVisaDesde", VentaDetalle.fechaVISADesdeDTO));
            command.Parameters.Add(CreateParameter("@FechaVisaHasta", VentaDetalle.fechaVISAHastaDTO));
            command.Parameters.Add(CreateParameter("@IDSeguroViajero", VentaDetalle.idDetalleReservaDTO));
            command.Parameters.Add(CreateParameter("@IDServicioAlojamiento", VentaDetalle.idMotivoViajeDTO));
            command.Parameters.Add(CreateParameter("@IDServicioTraslado", VentaDetalle.idPasajeroDTO));
            command.Parameters.Add(CreateParameter("@IDVendedor", VentaDetalle.idSeguroViajeroDTO));
            command.Parameters.Add(CreateParameter("@IDDetalleVenta", VentaDetalle.idServicioAlojamientoDTO));
            command.Parameters.Add(CreateParameter("@Monto", VentaDetalle.idServicioTrasladoDTO));
            command.Parameters.Add(CreateParameter("@MontoViajero", VentaDetalle.idTipoDocumentoDTO));
            command.Parameters.Add(CreateParameter("@PaisDestino", VentaDetalle.idTipoDocumentoViajeDTO));
            command.Parameters.Add(CreateParameter("@PaisOrigen", VentaDetalle.numeroDocumentoDTO,50));
            command.Parameters.Add(CreateParameter("@PaisOrigen", VentaDetalle.numeroVentaDTO));


            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (VentaDetalle.IsNew)
            {
                VentaDetalle.idDetalleVentaDTO = (int)command.Parameters["@IDVentaDetalle"].Value;
            }
        }

    }
}
