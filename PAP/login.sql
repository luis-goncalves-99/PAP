USE [PAP]
GO
/****** Object:  StoredProcedure [dbo].[loginar]    Script Date: 30/06/2017 19:05:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[loginar]
as
BEGIN 
     Select Username,Password,Tipo_func from Funcionario
END 