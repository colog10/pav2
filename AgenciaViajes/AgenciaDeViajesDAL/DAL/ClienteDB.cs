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
    public class ClienteDB : DALBase
    {
        public static ClienteDTO GetClienteByID(int idCliente)
        {
            SqlCommand command = GetDbSprocCommand("usp_Cliente_GetByID");
            command.Parameters.Add(CreateParameter("@idCliente", idCliente));
            return GetSingleDTO<ClienteDTO>(ref command);
        }

        public static List<ClienteDTO> GetAll()
        {
            SqlCommand command = GetDbSprocCommand("usp_Cliente_GetAll");
            return GetDTOList<ClienteDTO>(ref command);
        }

        public static void SaveCliente(ref ClienteDTO cliente)
        {
            SqlCommand command;

            if (cliente.IsNew)
            {
                command = GetDbSprocCommand("usp_cliente_Insert");
                command.Parameters.Add(CreateOutputParameter("@idCliente", SqlDbType.Int));
            }
            else
            {
                command = GetDbSprocCommand("usp_Cliente_Update");
                command.Parameters.Add(CreateParameter("@idCliente", cliente.idClienteDTO));
            }

            command.Parameters.Add(CreateParameter("@cuilcuit1", cliente.cuilcuit1DTO, 2));
            command.Parameters.Add(CreateParameter("@cuilcuit2", cliente.cuilcuit2DTO, 8));
            command.Parameters.Add(CreateParameter("@cuilcuit3", cliente.cuilcuit3DTO, 1));
            command.Parameters.Add(CreateParameter("@razonSocial", cliente.razonSocialDTO, 50));
            command.Parameters.Add(CreateParameter("@movil", cliente.movilDTO, 50));
            command.Parameters.Add(CreateParameter("@domicilioComercial", cliente.domicilioComercialDTO, 60));
            command.Parameters.Add(CreateParameter("@domicilioParticular", cliente.domicilioParticularDTO, 60));
            command.Parameters.Add(CreateParameter("@email", cliente.emailDTO, 40));
            command.Parameters.Add(CreateParameter("@telfax", cliente.telfaxDTO, 50));

            // Run the command.
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();

            // If this is a new record, let's set the ID so the object
            // will have it.
            if (cliente.IsNew)
            {
                cliente.idClienteDTO = (int)command.Parameters["@idCliente"].Value;
            }
        }
    }
}
