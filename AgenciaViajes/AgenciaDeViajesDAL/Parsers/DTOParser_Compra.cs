﻿using AgenciaDeViajesDAL.Util;
using AgenciaDeViajesDTO.Entities;
using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgenciaDeViajesDAL.Parsers
{
    internal class DTOParser_Compra : DTOParserSQLClient
    {
        private int Ord_idCompra;
        private int Ord_idOperadorTuristico;
        private int Ord_idDetalleCompra;
        private int Ord_fechaCompra;
        private int Ord_fechaPago;
        private int Ord_monto;
        private int Ord_saldo;
        private int Ord_NumeroFactura;
        private int Ord_IdReserva;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
 	        Ord_idCompra = reader.GetOrdinal("idCompra");
            Ord_idOperadorTuristico = reader.GetOrdinal("idOperadorTuristico");
            Ord_idDetalleCompra = reader.GetOrdinal("idDetalleCompra");
            Ord_fechaCompra = reader.GetOrdinal("fechaCompra");
            Ord_fechaPago = reader.GetOrdinal("fechaPago");
            Ord_monto = reader.GetOrdinal("monto");
            Ord_saldo = reader.GetOrdinal("saldo");
            Ord_NumeroFactura = reader.GetOrdinal("numeroFactura");
            Ord_IdReserva = reader.GetOrdinal("idReserva");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            CompraDTO compraDTO = new CompraDTO();
            //idCompra
            if(!reader.IsDBNull(Ord_idCompra)) { compraDTO.idCompraDTO = reader.GetInt32(Ord_idCompra);}

            //idOperadorturistico
            if(!reader.IsDBNull(Ord_idOperadorTuristico)) { compraDTO.idOperadorTuristicoDTO = reader.GetInt32(Ord_idOperadorTuristico);}

            //idDetalleCompra
            if(!reader.IsDBNull(Ord_idDetalleCompra)) { compraDTO.idDetalleCompraDTO = reader.GetInt32(Ord_idDetalleCompra);}

            //fechaCompra
            if(!reader.IsDBNull(Ord_fechaCompra)) { compraDTO.fechaCompraDTO = reader.GetDateTime(Ord_fechaCompra);}

            //fechaPago
            if(!reader.IsDBNull(Ord_fechaPago)) { compraDTO.fechaPagoDTO = reader.GetDateTime(Ord_fechaPago);}

            //monto
            if(!reader.IsDBNull(Ord_monto)) { compraDTO.montoDTO = reader.GetDecimal(Ord_monto);}

            //saldo
            if (!reader.IsDBNull(Ord_saldo)) { compraDTO.saldoDTO = reader.GetDecimal(Ord_saldo); }

            //numeroFactura
            if (!reader.IsDBNull(Ord_NumeroFactura)) { compraDTO.NumeroFactura = reader.GetInt32(Ord_NumeroFactura); }

            //IdReserva
            if (!reader.IsDBNull(Ord_IdReserva)) { compraDTO.IdReserva = reader.GetInt32(Ord_IdReserva); }

            //IdOperadorTuristico
            if (!reader.IsDBNull(Ord_idOperadorTuristico)) { compraDTO.idOperadorTuristicoDTO = reader.GetInt32(Ord_idOperadorTuristico); }

            return compraDTO;
        }

    }
}

