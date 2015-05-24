using AgenciaDeViajesDTO.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeViajesDTO.Entities
{
    public class PaisDTO : CommonBase
    {
        public string PaisCodigo { get; set; }
        public string PaisNombre { get; set; }
        public string PaisContinente { get; set; }
        public string PaisRegion { get; set; }
        public float PaisArea { get; set; }
        public int PaisIndependencia { get; set; }
        public int PaisPoblacion { get; set; }
        public float PaisExpectativaDeVida { get; set; }
        public float PaisProductoInternoBruto { get; set; }
        public float PaisProductoInternoBrutoAntiguo { get; set; }
        public string PaisNombreLocal { get; set; }
        public string PaisGobierno { get; set; }
        public string PaisJefeDeEstado { get; set; }
        public int PaisCapital { get; set; }
        public string PaisCodigo2 { get; set; }

        public PaisDTO()
        {
            PaisCodigo = String_NullValue;
            PaisNombre = String_NullValue;
            PaisContinente = String_NullValue;
            PaisRegion = String_NullValue;
            PaisArea = Float_NullValue;
            PaisIndependencia = Int_NullValue;
            PaisPoblacion = Int_NullValue;
            PaisExpectativaDeVida = Float_NullValue;
            PaisProductoInternoBruto = Float_NullValue;
            PaisProductoInternoBrutoAntiguo = Float_NullValue;
            PaisNombreLocal = String_NullValue;
            PaisGobierno = String_NullValue;
            PaisJefeDeEstado = String_NullValue;
            PaisCapital = Int_NullValue;
            PaisCodigo2 = String_NullValue;
        }


        /*
        
    
    []               SMALLINT     CONSTRAINT [DF__Pais__PaisIndepe__7C4F7684] DEFAULT (NULL) NULL,
    []                   INT          CONSTRAINT [DF__Pais__PaisPoblac__7D439ABD] DEFAULT ('0') NULL,
    [PaisExpectativaDeVida]           FLOAT (53)   CONSTRAINT [DF__Pais__PaisExpect__7E37BEF6] DEFAULT (NULL) NULL,
    [PaisProductoInternoBruto]        FLOAT (53)   CONSTRAINT [DF__Pais__PaisProduc__7F2BE32F] DEFAULT (NULL) NULL,
    [PaisProductoInternoBrutoAntiguo] FLOAT (53)   CONSTRAINT [DF__Pais__PaisProduc__00200768] DEFAULT (NULL) NULL,
    [PaisNombreLocal]                 VARCHAR (45) CONSTRAINT [DF__Pais__PaisNombre__01142BA1] DEFAULT ('') NULL,
    [PaisGobierno]                    VARCHAR (45) CONSTRAINT [DF__Pais__PaisGobier__02084FDA] DEFAULT ('') NULL,
    [PaisJefeDeEstado]                VARCHAR (60) CONSTRAINT [DF__Pais__PaisJefeDe__02FC7413] DEFAULT (NULL) NULL,
    [PaisCapital]                     INT          CONSTRAINT [DF__Pais__PaisCapita__03F0984C] DEFAULT (NULL) NULL,
    [PaisCodigo2]                     CHAR (2)     CONSTRAINT [DF__Pais__PaisCodigo__04E4BC85] DEFAULT ('') NULL,
         
         */
    
    }
}
