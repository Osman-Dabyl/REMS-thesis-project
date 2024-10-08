USE [RafatDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2024-07-20 9:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookThanks]    Script Date: 2024-07-20 9:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookThanks](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EffectValue] [int] NOT NULL,
	[Ref] [nvarchar](max) NOT NULL,
	[BookThankDate] [datetime2](7) NOT NULL,
	[Note] [nvarchar](max) NOT NULL,
	[AddedDate] [datetime2](7) NOT NULL,
	[EmployeesId] [int] NOT NULL,
	[UserId] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_BookThanks] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2024-07-20 9:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[JobTitle] [nvarchar](max) NOT NULL,
	[EmpState] [nvarchar](max) NOT NULL,
	[LastPromotionDate] [datetime2](7) NOT NULL,
	[CurrentDegree] [int] NOT NULL,
	[CurrentStage] [int] NOT NULL,
	[CurrentSalary] [real] NOT NULL,
	[CurrentDate] [datetime2](7) NOT NULL,
	[NextDegree] [int] NOT NULL,
	[NextStage] [int] NOT NULL,
	[NextSalary] [real] NOT NULL,
	[NextDate] [datetime2](7) NOT NULL,
	[Note] [nvarchar](max) NOT NULL,
	[AddedDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NOT NULL,
	[UsersId] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeesRecords]    Script Date: 2024-07-20 9:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeesRecords](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[JobTitle] [nvarchar](max) NOT NULL,
	[EmpState] [nvarchar](max) NOT NULL,
	[LastPromotionDate] [datetime2](7) NOT NULL,
	[CurrentDegree] [int] NOT NULL,
	[CurrentStage] [int] NOT NULL,
	[CurrentSalary] [real] NOT NULL,
	[CurrentDate] [datetime2](7) NOT NULL,
	[NextDegree] [int] NOT NULL,
	[NextStage] [int] NOT NULL,
	[NextSalary] [real] NOT NULL,
	[NextDate] [datetime2](7) NOT NULL,
	[Note] [nvarchar](max) NOT NULL,
	[AddedDate] [datetime2](7) NOT NULL,
	[UpdateDate] [datetime2](7) NOT NULL,
	[UsersId] [nvarchar](max) NOT NULL,
	[EmployeesId] [int] NOT NULL,
 CONSTRAINT [PK_EmployeesRecords] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 2024-07-20 9:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Key] [nvarchar](max) NOT NULL,
	[Value] [bit] NOT NULL,
	[UsersId] [int] NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalaryRate]    Script Date: 2024-07-20 9:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaryRate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Degree] [int] NOT NULL,
	[Salary] [real] NOT NULL,
	[BonusYearRate] [real] NOT NULL,
	[PromotionYear] [int] NOT NULL,
	[UsersId] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_SalaryRate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SystemRecords]    Script Date: 2024-07-20 9:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemRecords](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserFullName] [nvarchar](max) NOT NULL,
	[DeviceName] [nvarchar](max) NOT NULL,
	[MachinId] [nvarchar](max) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[UsersId] [int] NOT NULL,
 CONSTRAINT [PK_SystemRecords] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2024-07-20 9:36:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Role] [nvarchar](max) NOT NULL,
	[IsSecondaryUser] [bit] NOT NULL,
	[UserId] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[EditedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240614181754_AddTables', N'7.0.19')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240620031815_AddSalaryTable', N'7.0.19')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240625073607_AddEmployeesTable', N'7.0.19')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240706070645_AddBookThankTable', N'7.0.19')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240712095613_AddEmployeesRecords', N'7.0.19')
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (18, N'checkBoxAdd', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (19, N'checkBoxDelete', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (20, N'checkBoxEdit', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (21, N'checkBoxExport', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (22, N'checkBoxPrint', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (23, N'checkBoxSearch', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (24, N'checkBoxHomeSearch', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (25, N'checkBoxHome', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (26, N'checkBoxSalary', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (27, N'checkBoxEmployees', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (28, N'checkBoxUsers', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (29, N'checkBoxReport', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (30, N'checkBoxSettings', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (31, N'checkBoxAbout', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (32, N'checkBoxHelp', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (33, N'checkBoxRetirmnet', 1, 1)
INSERT [dbo].[Roles] ([Id], [Key], [Value], [UsersId]) VALUES (34, N'checkBoxSystemRecords', 1, 1)
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[SystemRecords] ON 

INSERT [dbo].[SystemRecords] ([Id], [UserFullName], [DeviceName], [MachinId], [Title], [Description], [CreatedDate], [UsersId]) VALUES (1, N'الشعبة الادارية', N'Safaa', N'1CBFC0C5988D', N'تسجيل الدخول', N'تم تسجيل دخول مستخدم     الشعبة الادارية', CAST(N'2024-07-20T09:11:37.9459671' AS DateTime2), 1)
INSERT [dbo].[SystemRecords] ([Id], [UserFullName], [DeviceName], [MachinId], [Title], [Description], [CreatedDate], [UsersId]) VALUES (2, N'الشعبة الادارية', N'Safaa', N'1CBFC0C5988D', N'تسجيل الدخول', N'تم تسجيل دخول مستخدم     الشعبة الادارية', CAST(N'2024-07-20T09:23:12.8623999' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[SystemRecords] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [FullName], [UserName], [Password], [Role], [IsSecondaryUser], [UserId], [Phone], [Email], [Address], [CreatedDate], [EditedDate]) VALUES (1, N'الشعبة الادارية', N'admin', N'12345', N'User', 0, N'7e3c6ce6-a05b-4cbe-b0fc-c6057cd30541', N'', N'', N'', CAST(N'2024-06-14T00:00:00.0000000' AS DateTime2), CAST(N'2024-07-17T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[BookThanks]  WITH CHECK ADD  CONSTRAINT [FK_BookThanks_Employees_EmployeesId] FOREIGN KEY([EmployeesId])
REFERENCES [dbo].[Employees] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BookThanks] CHECK CONSTRAINT [FK_BookThanks_Employees_EmployeesId]
GO
ALTER TABLE [dbo].[EmployeesRecords]  WITH CHECK ADD  CONSTRAINT [FK_EmployeesRecords_Employees_EmployeesId] FOREIGN KEY([EmployeesId])
REFERENCES [dbo].[Employees] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmployeesRecords] CHECK CONSTRAINT [FK_EmployeesRecords_Employees_EmployeesId]
GO
ALTER TABLE [dbo].[Roles]  WITH CHECK ADD  CONSTRAINT [FK_Roles_Users_UsersId] FOREIGN KEY([UsersId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Roles] CHECK CONSTRAINT [FK_Roles_Users_UsersId]
GO
