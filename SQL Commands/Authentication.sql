USE [ShopsRates]
GO
/****** Object:  StoredProcedure [dbo].[Authentication]    Script Date: 10.07.2020 21:53:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[Authentication]
@Login NVARCHAR(50),
@Password NVARCHAR(256)
AS
BEGIN
	SELECT COUNT(*) FROM Users WHERE Login=@Login AND Password=@Password
END