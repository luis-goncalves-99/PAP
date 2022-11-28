USE [PAP]
GO
/****** Object:  StoredProcedure [dbo].[loginar]    Script Date: 29/06/2017 15:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Alter Procedure [dbo].[Listagem_Utentes]
@Nome varchar(50)
as
BEGIN 
     Select id_cliente,Email,Socio,Telefone,Morada,Cod_Postal from Utentes where Nome = @Nome
END 