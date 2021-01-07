USE [ReadUpBooks]
GO

/****** Object:  Table [dbo].[CurrenciesDetails]    Script Date: 01/07/2021 09:40:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CurrenciesDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[From] [varchar](50) NOT NULL,
	[To] [varchar](50) NOT NULL,
	[Value] [float] NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK__Currencies__3214EC2707F6335A] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


