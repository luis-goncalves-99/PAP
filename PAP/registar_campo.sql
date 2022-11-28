USE [PAP]
GO
/****** Object:  StoredProcedure [dbo].[Regist_Campo]    Script Date: 01/07/2017 20:03:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[Regist_Campo]
	@id_Campo int,
	@Nome varchar(50),
	@Nome_Desporto varchar(50),
	@id_func varchar(50)


as
begin
	Insert into Campo(id_Campo,Nome,Nome_Desporto,id_func)	
	values(@id_Campo,@Nome,@Nome_Desporto,@id_func)
end
