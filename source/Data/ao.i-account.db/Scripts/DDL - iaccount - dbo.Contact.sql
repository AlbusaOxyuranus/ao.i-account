if object_id('dbo.Contact', 'U') is not null
	drop table dbo.Contact 

CREATE TABLE [dbo].[Contact](
	[contactId] [int] IDENTITY(1,1) NOT NULL,
	[contactName] [nvarchar](150) NOT NULL,
	[create_date] [datetime] NULL,
	[modified_date] [datetime] NULL,
 CONSTRAINT [PK_ContactType] PRIMARY KEY CLUSTERED 
(
	[contactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO