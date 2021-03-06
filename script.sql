USE [query-example]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 8.01.2018 02:12:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_yetkili] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_user_login]    Script Date: 8.01.2018 02:12:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_user_login]
(
@id int output,
@username nvarchar(50),
@pass nvarchar(50)
)
as
begin
	select @id=id from dbo.Users where username=@username and Password=@pass
end	
GO
create proc [dbo].[Add_user]
(
@Name nvarchar(50),
@Surname nvarchar(50),
@UserName nvarchar(50),
@Password nvarchar(50)
)
as
begin
	insert into Users(Name,Surname,Username,Password)
		values(@Name,@Surname,@UserName,@Password)
end
GO