using AgenciaDeViajesDAL.Util;
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
    internal class DTOParser_Cliente : DTOParserSQLClient
    {
        private int Ord_idCliente;
        private int Ord_cuilcuit1;
        private int Ord_cuilcuit2;
        private int Ord_cuilcuit3;
        private int Ord_razonSocial;
        private int Ord_movil;
        private int Ord_domicilioComercial;
        private int Ord_domicilioParticular;
        private int Ord_email;
        private int Ord_telfax;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_idCliente = reader.GetOrdinal("idCliente");
            Ord_cuilcuit1 = reader.GetOrdinal("cuilcuit1");
            Ord_cuilcuit2 = reader.GetOrdinal("cuilcuit2");
            Ord_cuilcuit3 = reader.GetOrdinal("cuilcuit3");
            Ord_razonSocial = reader.GetOrdinal("razonSocial");
            Ord_movil = reader.GetOrdinal("movil");
            Ord_domicilioComercial = reader.GetOrdinal("domicilioComercial");
            Ord_domicilioParticular = reader.GetOrdinal("domicilioParticular");
            Ord_email = reader.GetOrdinal("email");
            Ord_telfax = reader.GetOrdinal("telfax");
        }

        internal override DTOBase PopulateOrdinals(SqlDataReader reader)
        {
            ClienteDTO clienteDTO = new ClienteDTO();
            
            //idCliente
            if (!reader.IsDBNull(Ord_idCliente)) { clienteDTO.idClienteDTO = reader.GetInt32(Ord_idCliente) ;}
            
            //cuilcuit1
            if (!reader.IsDBNull(Ord_cuilcuit1)) { clienteDTO.cuilcuit1DTO = reader.GetString(Ord_cuilcuit1);}

            //cuilcuit2
            if (!reader.IsDBNull(Ord_cuilcuit2)) { clienteDTO.cuilcuit2DTO = reader.GetString(Ord_cuilcuit2);}

            //cuilcuit3
            if (!reader.IsDBNull(Ord_cuilcuit3)) { clienteDTO.cuilcuit3DTO = reader.GetString(Ord_cuilcuit3) ;}

            //razonSocial
            if (!reader.IsDBNull(Ord_razonSocial)) { clienteDTO.razonSocialDTO = reader.GetString(Ord_razonSocial);}

            //movil
            if (!reader.IsDBNull(Ord_razonSocial)) { clienteDTO.movilDTO = reader.GetString(Ord_movil);}

            //domicilioComercial
            if (!reader.IsDBNull(Ord_domicilioComercial)) { clienteDTO.domicilioComercialDTO = reader.GetString(Ord_domicilioComercial);}

            //domicilioParticular
            if (!reader.IsDBNull(Ord_domicilioParticular)) { clienteDTO.domicilioParticularDTO = reader.GetString(Ord_domicilioParticular);}

            //email
            if (!reader.IsDBNull(Ord_email)) { clienteDTO.emailDTO = reader.GetString(Ord_email);}

            //telfax
            if (!reader.IsDBNull(Ord_telfax)) { clienteDTO.telfaxDTO = reader.GetString(Ord_telfax);}

            return clienteDTO;

        }

    }
}
