USE [PAP]
GO
/****** Object:  StoredProcedure [dbo].[Regist_Prof]    Script Date: 04-07-2017 12:57:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[Regist_Prof]
	@id_prof int,
	@Nome varchar(50),
	@Email varchar(50),	
	@Telefone int,
	@Morada varchar(50),
	@Id_func varchar(50),
	@Cod_Postal varchar(8),
	@Horário_dia varchar(50),
	@Horário_semanal varchar(50),
	@Desporto varchar(50)
as
begin
	Insert into Professor(id_prof,Nome,Email,Telefone,Morada,Id_func,Cod_Postal,Horário_dia,Horário_semanal,Desporto)	
	values(@id_prof,@Nome,@Email,@Telefone,@Morada,@Id_func,@Cod_Postal,@Horário_dia,@Horário_semanal,@Desporto)
end
