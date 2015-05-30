using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class ClienteDTO : DTOBase
    {
        public int idClienteDTO { get; set; }
        public string cuilcuit1DTO { get; set; }
        public string cuilcuit2DTO { get; set; }
        public string cuilcuit3DTO { get; set; }
        public string razonSocialDTO { get; set; }
        public string movilDTO { get; set; }
        public string domicilioComercialDTO { get; set; }
        public string domicilioParticularDTO { get; set; }
        public string emailDTO { get; set; }
        public string telfaxDTO { get; set; }

        public ClienteDTO()
        {
            idClienteDTO = Int_NullValue;
            cuilcuit1DTO = String_NullValue;
            cuilcuit2DTO = String_NullValue;
            cuilcuit3DTO = String_NullValue;
            razonSocialDTO = String_NullValue;
            movilDTO = String_NullValue;
            domicilioParticularDTO = String_NullValue;
            domicilioComercialDTO = String_NullValue;
            emailDTO = String_NullValue;
            telfaxDTO = String_NullValue;
        }
    }
}
