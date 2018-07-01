if object_id('dbo.Service', 'U') is not null
	drop table dbo.Service 

CREATE TABLE [dbo].[Service](
	[serviceId] [int] IDENTITY(1,1) NOT NULL,
	[create_date] [datetime] NULL,
	[nameService] [nchar](250) NULL,
	[modified_date] [datetime] NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[serviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
