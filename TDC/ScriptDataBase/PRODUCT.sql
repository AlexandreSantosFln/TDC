USE [TDC]
GO

/****** Object:  Table [dbo].[PRODUCT]    Script Date: 05/31/2017 13:06:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PRODUCT](
	[ID_PRODUCT] [int] NOT NULL,
	[NM_PRODUCT] [varchar](255) NULL,
	[VL_PRICE] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_PRODUCT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
