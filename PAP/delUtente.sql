USE [PAP]
GO
/****** Object:  StoredProcedure [dbo].[del_Utente]    Script Date: 30/06/2017 19:06:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[del_Utente]
	@id_utente int
as
BEGIN
	DELETE FROM Utente where id_utente = @id_utente
END

