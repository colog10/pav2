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
    class ServicioAlojamientoDB : DALBase
    {
        public static ServicioAlojamientoDTO GetServicioAlojamientoByID(int IDServicioAlojamiento)
        {
            SqlCommand command = GetDbSprocCommand("usp_ServicioAlojamiento_GetByID");
            command.Parameters.Add(CreateParameter("@IDServicioAlojamiento", IDServicioAlojamiento));
            return GetSingleDTO<ServicioAlojamientoDTO>(ref command);
        }

        public static List<ServicioAlojamientoDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_ServicioAlojamiento_GetAll");
            return GetDTOList<ServicioAlojamientoDTO>(ref command);
        }

        public static void SaveServicioAlojamiento(ref ServicioAlojamientoDTO ServicioAlojamiento)
        {
            SqlCommand command;

            if (ServicioAlojamiento.IsNew)
            {
                command = GetDbSprocCommand("usp_ServicioAlojamiento_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDServicioAlojamiento", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_ServicioAlojamiento_Update");
                command.Parameters.Add(CreateParameter("@IDServicioAlojamiento", ServicioAlojamiento.ServicioAlojamiento));
            }

            command.Parameters.Add(CreateParameter("@CategoriaDTO", ServicioAlojamiento.CategoriaDTO,50));
            command.Parameters.Add(CreateParameter("@Comision", ServicioAlojamiento.comisionDTO));
            command.Parameters.Add(CreateParameter("@Descripcion", ServicioAlojamiento.descripcionDTO, 50));
            command.Parameters.Add(CreateParameter("@FechaDesde", ServicioAlojamiento.fechaDesdeDTO));
            command.Parameters.Add(CreateParameter("@FechaHasta", ServicioAlojamiento.fechaHastaDTO));
            command.Parameters.Add(CreateParameter("@FechaVencReserva", ServicioAlojamiento.fechaVencReservaDTO));
            command.Parameters.Add(CreateParameter("@IDAlojamiento", ServicioAlojamiento.idAlojamientoDTO));
            command.Parameters.Add(CreateParameter("@Monto", ServicioAlojamiento.montoDTO));
            command.Parameters.Add(CreateParameter("@NumeroCompra", ServicioAlojamiento.numeroCompraDTO));
            command.Parameters.Add(CreateParameter("@NumeroDocumento", ServicioAlojamiento.numeroDocumentoDTO,10));
            command.Parameters.Add(CreateParameter("@NumeroReserva", ServicioAlojamiento.numeroReservaDTO, 10));
            command.Parameters.Add(CreateParameter("@NumeroVenta", ServicioAlojamiento.numeroVentaDTO));
            command.Parameters.Add(CreateParameter("@TipoDocumentoDTO", ServicioAlojamiento.tipoDocumentoDTO));        
            

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (ServicioAlojamiento.IsNew)
            {
                ServicioAlojamiento.ServicioAlojamiento = (int)command.Parameters["@IDServicioAlojamiento"].Value;
            }
        }

    }
}
