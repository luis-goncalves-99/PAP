USE [PAP]
GO
/****** Object:  StoredProcedure [dbo].[Registar]    Script Date: 30/06/2017 19:07:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[Registar]
	@Username varchar(50),
	@Password varchar(50),
	@First_Name varchar(50),
	@Last_Name varchar(50),
	@Morada varchar(50),
	@Telefone int,
	@Email varchar(50),
	@Data_de_Nascimento datetime,
	@Tipo_func varchar(50)
as
begin
	Insert into Funcionario(Username,Password,First_Name,Last_Name,Email,Telefone,Data_de_Nascimento,Morada,Tipo_func)	
	values(@Username,@Password,@First_Name,@Last_Name,@Email,@Telefone,@Data_de_Nascimento,@Morada,@Tipo_func)
end