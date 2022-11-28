USE [PAP]
GO
/****** Object:  StoredProcedure [dbo].[UpdateProf]    Script Date: 30/06/2017 18:05:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[ProfApagarID]	
	@id_prof int
as
Begin
UPDATE Professor SET
            id_prof =@id_prof  where id_prof =@id_prof 
END
