USE [OtoHospital]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 6.01.2021 05:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[AppointmenId] [int] IDENTITY(1,1) NOT NULL,
	[AppointmentDate] [datetime] NOT NULL,
	[CarId] [int] NOT NULL,
	[AppointmentDescription] [nvarchar](500) NULL,
	[AppointmentCreationDate] [datetime] NOT NULL,
	[AppointmentUpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[AppointmenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cars]    Script Date: 6.01.2021 05:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cars](
	[CarId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[CarPlaque] [nvarchar](20) NOT NULL,
	[CarBrand] [nvarchar](30) NOT NULL,
	[CarModel] [nvarchar](20) NOT NULL,
	[CarModelYear] [nvarchar](10) NOT NULL,
	[CarAddedDate] [datetime] NOT NULL,
	[CarUpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED 
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 6.01.2021 05:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerFullName] [varchar](100) NOT NULL,
	[CustomerEmail] [varchar](50) NULL,
	[CustomerPhoneNumber] [varchar](15) NOT NULL,
	[CustomerAddedDate] [datetime] NOT NULL,
	[CustomerUpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkOrders]    Script Date: 6.01.2021 05:01:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkOrders](
	[WorkOrderId] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NOT NULL,
	[WorkOrderStartDate] [datetime] NOT NULL,
	[WorkOrderFinishDate] [datetime] NULL,
	[WorkOrderDescription] [nvarchar](500) NOT NULL,
	[WorkOrderCreationDate] [datetime] NOT NULL,
	[WorkOrderUpdateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_WorkOrders] PRIMARY KEY CLUSTERED 
(
	[WorkOrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Appointments] ON 

INSERT [dbo].[Appointments] ([AppointmenId], [AppointmentDate], [CarId], [AppointmentDescription], [AppointmentCreationDate], [AppointmentUpdateDate]) VALUES (7, CAST(N'2021-01-06T00:00:00.000' AS DateTime), 9, N'test test test', CAST(N'2021-01-06T04:02:06.557' AS DateTime), CAST(N'2021-01-06T04:02:06.557' AS DateTime))
INSERT [dbo].[Appointments] ([AppointmenId], [AppointmentDate], [CarId], [AppointmentDescription], [AppointmentCreationDate], [AppointmentUpdateDate]) VALUES (8, CAST(N'2021-01-07T00:00:00.000' AS DateTime), 8, N'test sss', CAST(N'2021-01-06T04:07:34.687' AS DateTime), CAST(N'2021-01-06T04:07:34.687' AS DateTime))
INSERT [dbo].[Appointments] ([AppointmenId], [AppointmentDate], [CarId], [AppointmentDescription], [AppointmentCreationDate], [AppointmentUpdateDate]) VALUES (9, CAST(N'2021-01-22T00:00:00.000' AS DateTime), 10, N'sacsacsacas', CAST(N'2021-01-06T04:18:24.500' AS DateTime), CAST(N'2021-01-06T04:18:24.500' AS DateTime))
SET IDENTITY_INSERT [dbo].[Appointments] OFF
GO
SET IDENTITY_INSERT [dbo].[Cars] ON 

INSERT [dbo].[Cars] ([CarId], [CustomerId], [CarPlaque], [CarBrand], [CarModel], [CarModelYear], [CarAddedDate], [CarUpdateDate]) VALUES (7, 4, N'34zn2814', N'ford', N'fiesta', N'2019', CAST(N'2021-01-06T04:00:37.610' AS DateTime), CAST(N'2021-01-06T04:00:37.610' AS DateTime))
INSERT [dbo].[Cars] ([CarId], [CustomerId], [CarPlaque], [CarBrand], [CarModel], [CarModelYear], [CarAddedDate], [CarUpdateDate]) VALUES (8, 4, N'34df8841', N'ford', N'transit', N'2010', CAST(N'2021-01-06T04:01:01.260' AS DateTime), CAST(N'2021-01-06T04:01:01.260' AS DateTime))
INSERT [dbo].[Cars] ([CarId], [CustomerId], [CarPlaque], [CarBrand], [CarModel], [CarModelYear], [CarAddedDate], [CarUpdateDate]) VALUES (9, 5, N'34kb8841', N'Fiat', N'bravo', N'2019', CAST(N'2021-01-06T04:01:26.773' AS DateTime), CAST(N'2021-01-06T04:01:26.773' AS DateTime))
INSERT [dbo].[Cars] ([CarId], [CustomerId], [CarPlaque], [CarBrand], [CarModel], [CarModelYear], [CarAddedDate], [CarUpdateDate]) VALUES (10, 5, N'34tp2535', N'Fiat', N'doblo', N'2020', CAST(N'2021-01-06T04:01:42.713' AS DateTime), CAST(N'2021-01-06T04:01:42.713' AS DateTime))
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [CustomerFullName], [CustomerEmail], [CustomerPhoneNumber], [CustomerAddedDate], [CustomerUpdateDate]) VALUES (4, N'Hakan Yıldırım', N'hakanyildirim@gmail.com', N'5357727984', CAST(N'2021-01-06T03:59:40.337' AS DateTime), CAST(N'2021-01-06T03:59:40.337' AS DateTime))
INSERT [dbo].[Customers] ([CustomerId], [CustomerFullName], [CustomerEmail], [CustomerPhoneNumber], [CustomerAddedDate], [CustomerUpdateDate]) VALUES (5, N'Ahmet Tan', N'ahmettan@gmail.com', N'5319665718', CAST(N'2021-01-06T04:00:01.623' AS DateTime), CAST(N'2021-01-06T04:00:01.623' AS DateTime))
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[WorkOrders] ON 

INSERT [dbo].[WorkOrders] ([WorkOrderId], [CarId], [WorkOrderStartDate], [WorkOrderFinishDate], [WorkOrderDescription], [WorkOrderCreationDate], [WorkOrderUpdateDate]) VALUES (2, 8, CAST(N'2021-01-20T00:00:00.000' AS DateTime), CAST(N'2021-01-06T04:52:34.777' AS DateTime), N'testtt', CAST(N'2021-01-06T04:45:02.127' AS DateTime), CAST(N'2021-01-06T04:45:02.127' AS DateTime))
INSERT [dbo].[WorkOrders] ([WorkOrderId], [CarId], [WorkOrderStartDate], [WorkOrderFinishDate], [WorkOrderDescription], [WorkOrderCreationDate], [WorkOrderUpdateDate]) VALUES (3, 9, CAST(N'2021-01-15T00:00:00.000' AS DateTime), CAST(N'2021-01-06T04:56:19.480' AS DateTime), N'asdasdsad', CAST(N'2021-01-06T04:54:52.897' AS DateTime), CAST(N'2021-01-06T04:54:52.897' AS DateTime))
INSERT [dbo].[WorkOrders] ([WorkOrderId], [CarId], [WorkOrderStartDate], [WorkOrderFinishDate], [WorkOrderDescription], [WorkOrderCreationDate], [WorkOrderUpdateDate]) VALUES (4, 9, CAST(N'2021-01-06T04:57:00.000' AS DateTime), CAST(N'2021-01-06T04:57:42.937' AS DateTime), N'test', CAST(N'2021-01-06T04:57:38.593' AS DateTime), CAST(N'2021-01-06T04:57:38.593' AS DateTime))
INSERT [dbo].[WorkOrders] ([WorkOrderId], [CarId], [WorkOrderStartDate], [WorkOrderFinishDate], [WorkOrderDescription], [WorkOrderCreationDate], [WorkOrderUpdateDate]) VALUES (5, 10, CAST(N'2021-01-15T00:00:00.000' AS DateTime), CAST(N'2021-01-06T04:57:56.160' AS DateTime), N'tess', CAST(N'2021-01-06T04:57:54.410' AS DateTime), CAST(N'2021-01-06T04:57:54.410' AS DateTime))
INSERT [dbo].[WorkOrders] ([WorkOrderId], [CarId], [WorkOrderStartDate], [WorkOrderFinishDate], [WorkOrderDescription], [WorkOrderCreationDate], [WorkOrderUpdateDate]) VALUES (7, 8, CAST(N'2021-01-21T00:00:00.000' AS DateTime), CAST(N'2021-01-06T05:00:30.620' AS DateTime), N'test', CAST(N'2021-01-06T05:00:28.770' AS DateTime), CAST(N'2021-01-06T05:00:28.770' AS DateTime))
SET IDENTITY_INSERT [dbo].[WorkOrders] OFF
GO
ALTER TABLE [dbo].[Appointments] ADD  CONSTRAINT [DF_Appointment_AppointmentUpdateDate]  DEFAULT (getdate()) FOR [AppointmentUpdateDate]
GO
ALTER TABLE [dbo].[Cars] ADD  CONSTRAINT [DF_Cars_CarUpdateDate]  DEFAULT (getdate()) FOR [CarUpdateDate]
GO
ALTER TABLE [dbo].[Customers] ADD  CONSTRAINT [DF_Customers_CustomerUpdateDate]  DEFAULT (getdate()) FOR [CustomerUpdateDate]
GO
ALTER TABLE [dbo].[WorkOrders] ADD  CONSTRAINT [DF_WorkOrders_WorkOrderUpdateDate]  DEFAULT (getdate()) FOR [WorkOrderUpdateDate]
GO
