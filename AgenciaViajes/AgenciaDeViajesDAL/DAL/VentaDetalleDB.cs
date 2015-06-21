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

        

    }
}
