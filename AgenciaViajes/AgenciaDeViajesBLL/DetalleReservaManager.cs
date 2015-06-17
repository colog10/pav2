using AgenciaDeViajesDAL.DAL;
using AgenciaDeViajesDTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesBLL
{
    public class DetalleReservaManager
    {

        public static ReservaDetalleDTO Reservas_ReservaDTO(int documento)
        {
            return ReservaDetalleDB.GetReservasGetByDocumento(documento);
        }
    }
}
