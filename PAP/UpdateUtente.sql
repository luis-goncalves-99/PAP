USE [PAP]
GO
/****** Object:  StoredProcedure [dbo].[UpdateUtente]    Script Date: 30/06/2017 19:07:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[UpdateUtente]
	@Nome varchar(50),
	@Email varchar(50),
	@Socio varchar(3),
	@Telefone int,
	@Morada varchar(50),
	@Id_func varchar(50),
	@Cod_Postal varchar(8),
	@id_utente int
as
Begin
UPDATE Utente SET
            Nome = @Nome,Email = @Email,Socio=@Socio,Telefone = @Telefone,Morada=@Morada,Cod_Postal=@Cod_Postal,Id_func=@Id_func where id_utente = @id_utente
END
