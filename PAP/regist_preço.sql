USE [PAP]
GO
/****** Object:  StoredProcedure [dbo].[Regist_Campo]    Script Date: 01/07/2017 20:46:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
go
Alter Procedure [dbo].[Regist_Preços]
	@id_preço int,
	@id_desporto varchar(50),
	@preço_aula money,
	@qtd_elementos int,
	@id_func varchar(50)


as
begin
	Insert into Preço_Aulas(id_preço,id_desporto,preço_aula,qtd_elementos,id_func)	
	values(@id_preço,@id_desporto,@preço_aula,@qtd_elementos,@id_func)
end