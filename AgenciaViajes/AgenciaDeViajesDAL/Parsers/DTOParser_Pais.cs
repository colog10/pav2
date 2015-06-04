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
    internal class DTOParser_Pais : DTOParserSQLClient
    {
        private int Ord_PaisCodigo;
        private int Ord_PaisNombre;
        private int Ord_PaisContinente;
        private int Ord_PaisRegion;
      
     
        private int Ord_PaisPoblacion;
      
        private int Ord_PaisNombreLocal;
        private int Ord_PaisGobierno;
        private int Ord_PaisJefeDeEstado;
        private int Ord_PaisCapital;
        private int Ord_PaisCodigo2;

        internal override void PopulateOrdinals(SqlDataReader reader)
        {
            Ord_PaisCodigo = reader.GetOrdinal("PaisCodigo");
            Ord_PaisNombre = reader.GetOrdinal("PaisNombre");
            Ord_PaisContinente = reader.GetOrdinal("PaisContinente");
            Ord_PaisRegion = reader.GetOrdinal("PaisRegion");
           
            Ord_PaisPoblacion = reader.GetOrdinal("PaisPoblacion");
          
            Ord_PaisNombreLocal = reader.GetOrdinal("PaisNombreLocal");
            Ord_PaisGobierno = reader.GetOrdinal("PaisGobierno");
            Ord_PaisJefeDeEstado = reader.GetOrdinal("PaisJefeDeEstado");
            Ord_PaisCapital = reader.GetOrdinal("PaisCapital");
            Ord_PaisCodigo2 = reader.GetOrdinal("PaisCodigo2");
        }

        internal override DTOBase PopulateDTO(SqlDataReader reader)
        {
            PaisDTO pais = new PaisDTO();
            // PaisCodigo
            if (!reader.IsDBNull(Ord_PaisCodigo))
            {
                pais.PaisCodigo = reader.GetString(Ord_PaisCodigo);
            }
            // PaisNombre
            if (!reader.IsDBNull(Ord_PaisNombre))
            {
                pais.PaisNombre = reader.GetString(Ord_PaisNombre);
            }
            // PaisContinente
            if (!reader.IsDBNull(Ord_PaisContinente))
            {
                pais.PaisContinente = reader.GetString(Ord_PaisContinente);
            }
            // PaisRegion
            if (!reader.IsDBNull(Ord_PaisRegion))
            {
                pais.PaisRegion = reader.GetString(Ord_PaisRegion);
            }
          
            // PaisPoblacion
            if (!reader.IsDBNull(Ord_PaisPoblacion))
            {
                pais.PaisPoblacion = reader.GetInt32(Ord_PaisPoblacion);
            }
          
            // PaisNombreLocal
            if (!reader.IsDBNull(Ord_PaisNombreLocal))
            {
                pais.PaisNombreLocal = reader.GetString(Ord_PaisNombreLocal);
            }
            // PaisGobierno
            if (!reader.IsDBNull(Ord_PaisGobierno))
            {
                pais.PaisGobierno = reader.GetString(Ord_PaisGobierno);
            }
            // PaisJefeDeEstado
            if (!reader.IsDBNull(Ord_PaisJefeDeEstado))
            {
                pais.PaisJefeDeEstado = reader.GetString(Ord_PaisJefeDeEstado);
            }
            // PaisCapital
            if (!reader.IsDBNull(Ord_PaisCapital))
            {
                pais.PaisCapital = reader.GetInt32(Ord_PaisCapital);
            }
            // PaisCodigo2
            if (!reader.IsDBNull(Ord_PaisCodigo2))
            {
                pais.PaisCodigo2 = reader.GetString(Ord_PaisCodigo2);
            }
            return pais;
        }
    }
}
