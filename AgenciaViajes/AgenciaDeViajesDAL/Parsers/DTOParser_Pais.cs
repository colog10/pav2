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
        private int Ord_PaisArea;
        private int Ord_PaisIndependencia;
        private int Ord_PaisPoblacion;
        private int Ord_PaisExpectativaDeVida;
        private int Ord_PaisProductoInternoBruto;
        private int Ord_PaisProductoInternoBrutoAntiguo;
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
            Ord_PaisArea = reader.GetOrdinal("PaisArea");
            Ord_PaisIndependencia = reader.GetOrdinal("PaisIndependencia");
            Ord_PaisPoblacion = reader.GetOrdinal("PaisPoblacion");
            Ord_PaisExpectativaDeVida = reader.GetOrdinal("PaisExpectativaDeVida");
            Ord_PaisProductoInternoBruto = reader.GetOrdinal("PaisProductoInternoBruto");
            Ord_PaisProductoInternoBrutoAntiguo = reader.GetOrdinal("PaisProductoInternoBrutoAntiguo");
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
            // PaisArea
            if (!reader.IsDBNull(Ord_PaisArea))
            {
                pais.PaisArea = reader.GetInt32(Ord_PaisArea);
            }
            // PaisIndependencia
            if (!reader.IsDBNull(Ord_PaisIndependencia))
            {
                pais.PaisIndependencia = reader.GetInt32(Ord_PaisIndependencia);
            }
            // PaisPoblacion
            if (!reader.IsDBNull(Ord_PaisPoblacion))
            {
                pais.PaisPoblacion = reader.GetInt32(Ord_PaisPoblacion);
            }
            // PaisExpectativaDeVida
            if (!reader.IsDBNull(Ord_PaisExpectativaDeVida))
            {
                pais.PaisExpectativaDeVida = reader.GetInt32(Ord_PaisExpectativaDeVida);
            }
            // PaisProductoInternoBruto
            if (!reader.IsDBNull(Ord_PaisProductoInternoBruto))
            {
                pais.PaisProductoInternoBruto = reader.GetInt32(Ord_PaisProductoInternoBruto);
            }
            // PaisProductoInternoBrutoAntiguo
            if (!reader.IsDBNull(Ord_PaisProductoInternoBrutoAntiguo))
            {
                pais.PaisProductoInternoBrutoAntiguo = reader.GetFloat(Ord_PaisProductoInternoBrutoAntiguo);
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
