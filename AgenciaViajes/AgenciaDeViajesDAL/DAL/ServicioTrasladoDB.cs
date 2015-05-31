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
    class ServicioTrasladoDB : DALBase
    {
        public static ServicioTrasladoDTO GetServicioTrasladoByID(int IDServicioTraslado)
        {
            SqlCommand command = GetDbSprocCommand("usp_ServicioTraslado_GetByID");
            command.Parameters.Add(CreateParameter("@IDServicioTraslado", IDServicioTraslado));
            return GetSingleDTO<ServicioTrasladoDTO>(ref command);
        }

        public static List<ServicioTrasladoDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_ServicioTraslado_GetAll");
            return GetDTOList<ServicioTrasladoDTO>(ref command);
        }

        public static void SaveServicioTraslado(ref ServicioTrasladoDTO ServicioTraslado)
        {
            SqlCommand command;

            if (ServicioTraslado.IsNew)
            {
                command = GetDbSprocCommand("usp_ServicioTraslado_Insert");
                command.Parameters.Add(CreateOutputParameter("@IDServicioTraslado", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_ServicioTraslado_Update");
                command.Parameters.Add(CreateParameter("@IDServicioTraslado", ServicioTraslado.idServicioTrasladoDTO));
            }

            
            command.Parameters.Add(CreateParameter("@Comision", ServicioTraslado.comisionDTO));
            command.Parameters.Add(CreateParameter("@Destino", ServicioTraslado.destinoDTO));
            command.Parameters.Add(CreateParameter("@FechaLlegada", ServicioTraslado.fechaLlegadaDTO));
            command.Parameters.Add(CreateParameter("@FechaReserva", ServicioTraslado.fechaReservaDTO));
            command.Parameters.Add(CreateParameter("@FechaSalida", ServicioTraslado.fechaSalidaDTO));
            command.Parameters.Add(CreateParameter("@IDCompaniaAerea", ServicioTraslado.idCompaniaAereaDTO));
            command.Parameters.Add(CreateParameter("@IDEmpesaColectivo", ServicioTraslado.idEmpresaColectivoDTO));
            command.Parameters.Add(CreateParameter("@Monto", ServicioTraslado.montoDTO));
            command.Parameters.Add(CreateParameter("@NumeroCompra", ServicioTraslado.numeroCompraDTO));
            command.Parameters.Add(CreateParameter("@NumeroDocumento", ServicioTraslado.numeroDocumentoDTO, 10));
            command.Parameters.Add(CreateParameter("@NumeroReserva", ServicioTraslado.numeroReservaDTO, 10));
            command.Parameters.Add(CreateParameter("@NumeroVenta", ServicioTraslado.numeroVentaDTO));
            command.Parameters.Add(CreateParameter("@IDServicioAlojamiento", ServicioTraslado.origenDTO));
            command.Parameters.Add(CreateParameter("@TipoDocumentoDTO", ServicioTraslado.tipoDocumentoDTO));
            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (ServicioTraslado.IsNew)
            {
                ServicioTraslado.idServicioTrasladoDTO = (int)command.Parameters["@IDServicioTraslado"].Value;
            }
        }

    }
}
