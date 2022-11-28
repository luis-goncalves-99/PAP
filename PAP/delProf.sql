USE [PAP]
GO
/****** Object:  StoredProcedure [dbo].[del_Utente]    Script Date: 29/06/2017 20:21:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[del_Prof]
	@id_prof int
as
BEGIN
	DELETE FROM Professor where id_prof = @id_prof
END
