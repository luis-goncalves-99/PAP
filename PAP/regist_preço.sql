USE [PAP]
GO
/****** Object:  StoredProcedure [dbo].[Regist_Campo]    Script Date: 01/07/2017 20:46:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
go
Alter Procedure [dbo].[Regist_Pre�os]
	@id_pre�o int,
	@id_desporto varchar(50),
	@pre�o_aula money,
	@qtd_elementos int,
	@id_func varchar(50)


as
begin
	Insert into Pre�o_Aulas(id_pre�o,id_desporto,pre�o_aula,qtd_elementos,id_func)	
	values(@id_pre�o,@id_desporto,@pre�o_aula,@qtd_elementos,@id_func)
end