﻿CREATE TABLE [dbo].[Textos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Texto] TEXT NULL, 
    [Local] NVARCHAR(150) NULL, 
    [Pagina] NVARCHAR(150) NULL
)
