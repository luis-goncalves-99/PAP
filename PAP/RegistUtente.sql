USE [PAP]
GO
/****** Object:  StoredProcedure [dbo].[Regist_Utente]    Script Date: 30/06/2017 19:06:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[Regist_Utente]
	@id_utente int,
	@Nome varchar(50),
	@Email varchar(50),
	@Socio varchar(3),
	@Telefone int,
	@Morada varchar(50),
	@Id_func varchar(50),
	@Cod_Postal varchar(8)
as
begin
	Insert into Utente(id_utente,Nome,Email,Socio,Telefone,Morada,Id_func,Cod_Postal)	
	values(@id_utente,@Nome,@Email,@Socio,@Telefone,@Morada,@Id_func,@Cod_Postal)
end