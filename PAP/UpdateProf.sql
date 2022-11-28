USE [PAP]
GO
/****** Object:  StoredProcedure [dbo].[UpdateProf]    Script Date: 04-07-2017 13:10:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[UpdateProf]
	@Nome varchar(50),
	@Email varchar(50),	
	@Telefone varchar(9),
	@Morada varchar(50),
	@Id_func varchar(50),
	@Cod_Postal varchar(8),
	@id_prof int,
	@Horário_dia varchar(50),
	@Horário_semanal varchar(50),
	@Desporto varchar(50)
as
Begin
UPDATE Professor SET
            Nome = @Nome,Email = @Email,Telefone = @Telefone,Morada=@Morada,Cod_Postal=@Cod_Postal,Id_func = @Id_func, Horário_dia = @Horário_dia,Horário_semanal = @Horário_semanal,Desporto = @Desporto where id_prof =@id_prof 
END
