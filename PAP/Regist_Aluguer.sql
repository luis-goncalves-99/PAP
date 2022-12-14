USE [PAP]
GO
/****** Object:  StoredProcedure [dbo].[Regist_Aluguer]    Script Date: 06/07/2017 00:10:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[Regist_Aluguer]
	@id_aula int,
	@Nome_desporto varchar(50),	
	@id_campo int,	
	@id_func varchar(50),
	@Utente_1 varchar(50),
	@Utente_2 varchar(50),
	@Utente_3 varchar(50),
	@Utente_4 varchar(50),
	@Dia date,
	@Hora_Inic varchar(50),
	@Hora_Fim varchar(50)
as
begin
	Insert into Ocupação_Campos(id_aula,Nome_desporto,id_campo,id_func,Utente_1,Utente_2,Utente_3,Utente_4,Dia,Hora_Inic,Hora_Fim)	
	values(@id_aula,@Nome_desporto,@id_campo,@id_func,@Utente_1,@Utente_2,@Utente_3,@Utente_4,@Dia,@Hora_Inic,@Hora_Fim)
end