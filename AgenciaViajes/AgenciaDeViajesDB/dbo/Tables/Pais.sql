CREATE TABLE [dbo].[Pais] (
    [PaisCodigo]                      NVARCHAR (3) CONSTRAINT [DF__Pais__PaisCodigo__778AC167] DEFAULT ('') NOT NULL,
    [PaisNombre]                      CHAR (52)    CONSTRAINT [DF__Pais__PaisNombre__787EE5A0] DEFAULT ('') NOT NULL,
    [PaisContinente]                  VARCHAR (50) CONSTRAINT [DF__Pais__PaisContin__797309D9] DEFAULT ('Asia') NULL,
    [PaisRegion]                      VARCHAR (26) CONSTRAINT [DF__Pais__PaisRegion__7A672E12] DEFAULT ('') NULL,
    [PaisArea]                        FLOAT (53)   CONSTRAINT [DF__Pais__PaisArea__7B5B524B] DEFAULT ('0.00') NULL,
    [PaisIndependencia]               SMALLINT     CONSTRAINT [DF__Pais__PaisIndepe__7C4F7684] DEFAULT (NULL) NULL,
    [PaisPoblacion]                   INT          CONSTRAINT [DF__Pais__PaisPoblac__7D439ABD] DEFAULT ('0') NULL,
    [PaisExpectativaDeVida]           FLOAT (53)   CONSTRAINT [DF__Pais__PaisExpect__7E37BEF6] DEFAULT (NULL) NULL,
    [PaisProductoInternoBruto]        FLOAT (53)   CONSTRAINT [DF__Pais__PaisProduc__7F2BE32F] DEFAULT (NULL) NULL,
    [PaisProductoInternoBrutoAntiguo] FLOAT (53)   CONSTRAINT [DF__Pais__PaisProduc__00200768] DEFAULT (NULL) NULL,
    [PaisNombreLocal]                 VARCHAR (45) CONSTRAINT [DF__Pais__PaisNombre__01142BA1] DEFAULT ('') NULL,
    [PaisGobierno]                    VARCHAR (45) CONSTRAINT [DF__Pais__PaisGobier__02084FDA] DEFAULT ('') NULL,
    [PaisJefeDeEstado]                VARCHAR (60) CONSTRAINT [DF__Pais__PaisJefeDe__02FC7413] DEFAULT (NULL) NULL,
    [PaisCapital]                     INT          CONSTRAINT [DF__Pais__PaisCapita__03F0984C] DEFAULT (NULL) NULL,
    [PaisCodigo2]                     CHAR (2)     CONSTRAINT [DF__Pais__PaisCodigo__04E4BC85] DEFAULT ('') NULL,
    CONSTRAINT [PK__Pais__F3A7B39A75A278F5] PRIMARY KEY CLUSTERED ([PaisCodigo] ASC)
);

