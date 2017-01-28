/****** Object:  Table [dbo].[Catagory_Table]    Script Date: 12/30/2015 1:11:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Catagory_Table](
	[Catagory_Id] [varchar](50) NOT NULL,
	[Catagory_Name] [varchar](50) NULL,
	[Catagory_unit] [int] NULL,
	[Catagory_Description] [varchar](50) NULL,
 CONSTRAINT [PK_Catagory_Table] PRIMARY KEY CLUSTERED 
(
	[Catagory_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer_Table]    Script Date: 12/30/2015 1:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer_Table](
	[Customer_ID] [varchar](50) NOT NULL,
	[Customer_Name] [varchar](50) NULL,
	[Customer_Phone] [int] NULL,
	[Customer_Address] [varchar](50) NULL,
	[Customer_Email] [varchar](50) NULL,
 CONSTRAINT [PK_Customer_Table] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee_Table]    Script Date: 12/30/2015 1:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee_Table](
	[Employee_ID] [varchar](50) NOT NULL,
	[Employee_Name] [varchar](50) NULL,
	[Employee_Password] [varchar](50) NULL,
	[Employee_Phone] [int] NULL,
	[Employee_Address] [varchar](50) NULL,
	[Employee_Type] [varchar](50) NULL,
 CONSTRAINT [PK_Employee_Table] PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product_Table]    Script Date: 12/30/2015 1:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product_Table](
	[Product_ID] [varchar](50) NOT NULL,
	[Unit_Cost] [int] NULL,
	[Product_Description] [varchar](50) NULL,
	[Stock] [varchar](50) NULL,
	[Supplier_ID] [varchar](50) NULL,
	[Product_Name] [varchar](50) NULL,
	[Catagory_ID] [varchar](50) NULL,
	[Unit_Price] [int] NULL,
 CONSTRAINT [PK_Product_Table] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Supplier_Table]    Script Date: 12/30/2015 1:11:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier_Table](
	[Supplier_ID] [varchar](50) NOT NULL,
	[Supplier_Name] [varchar](50) NULL,
	[Supplier_Email] [varchar](50) NULL,
	[Supplier_Phone] [int] NULL,
 CONSTRAINT [PK_Supplier_Table] PRIMARY KEY CLUSTERED 
(
	[Supplier_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Catagory_Table] ([Catagory_Id], [Catagory_Name], [Catagory_unit], [Catagory_Description]) VALUES (N'111111', NULL, NULL, NULL)
INSERT [dbo].[Catagory_Table] ([Catagory_Id], [Catagory_Name], [Catagory_unit], [Catagory_Description]) VALUES (N'111112', NULL, NULL, NULL)
INSERT [dbo].[Catagory_Table] ([Catagory_Id], [Catagory_Name], [Catagory_unit], [Catagory_Description]) VALUES (N'11123232112', NULL, NULL, NULL)
INSERT [dbo].[Catagory_Table] ([Catagory_Id], [Catagory_Name], [Catagory_unit], [Catagory_Description]) VALUES (N'121', NULL, NULL, NULL)
INSERT [dbo].[Catagory_Table] ([Catagory_Id], [Catagory_Name], [Catagory_unit], [Catagory_Description]) VALUES (N'12221', NULL, NULL, NULL)
INSERT [dbo].[Catagory_Table] ([Catagory_Id], [Catagory_Name], [Catagory_unit], [Catagory_Description]) VALUES (N'14', NULL, NULL, NULL)
INSERT [dbo].[Catagory_Table] ([Catagory_Id], [Catagory_Name], [Catagory_unit], [Catagory_Description]) VALUES (N'1545994', NULL, NULL, NULL)
ALTER TABLE [dbo].[Product_Table]  WITH CHECK ADD  CONSTRAINT [FK_Product_Table_Catagory_Table] FOREIGN KEY([Catagory_ID])
REFERENCES [dbo].[Catagory_Table] ([Catagory_Id])
GO
ALTER TABLE [dbo].[Product_Table] CHECK CONSTRAINT [FK_Product_Table_Catagory_Table]
GO
ALTER TABLE [dbo].[Product_Table]  WITH CHECK ADD  CONSTRAINT [FK_Product_Table_Supplier_Table] FOREIGN KEY([Supplier_ID])
REFERENCES [dbo].[Supplier_Table] ([Supplier_ID])
GO
ALTER TABLE [dbo].[Product_Table] CHECK CONSTRAINT [FK_Product_Table_Supplier_Table]
GO
