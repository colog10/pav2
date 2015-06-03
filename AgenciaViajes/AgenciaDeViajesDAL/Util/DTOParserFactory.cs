using AgenciaDeViajesDAL.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDAL.Util
{
    internal static class DTOParserFactory
    {
        // GetParser
        internal static DTOParserSQLClient GetParserSQLClient(System.Type DTOType)
        {
            switch (DTOType.Name)
            {
                case "EstadoCivilDTO":
                    return new DTOParser_EstadoCivil();
                case "MotivoViajeDTO":
                    return new DTOParser_MotivoViaje();
                case "OperadorTuristicoDTO":
                    return new DTOParser_OperadorTuristico();
                case "PaisDTO":
                    return new DTOParser_Pais();
                case "PasajeroDTO":
                    return new DTOParser_Pasajero();
                case "PaxFrecuenteXCiaAreaDTO":
                    return new DTOParser_PaxFrecuenteXCiaArea();
                case "ReservaDetalleDTO":
                    return new DTOParser_ReservaDetalle();
                case "ReservaDTO":
                    return new DTOParser_Reserva();
                case "SeguroViajeroDTO":
                    return new DTOParser_SeguroViajero();
                case "EmpleadoDTO":
                    return new DTOParser_Empleado();
                case "UsuarioDTO":
                    return new DTOParser_Usuario();
                case "TipoDestinoDTO":
                    return new DTOParser_TipoDestino();
                    case "TipoDocumentoDTO":
                    return new DTOParser_TipoDocumento();



            }

            throw new Exception("Unknown Type");
        }
    }
}

