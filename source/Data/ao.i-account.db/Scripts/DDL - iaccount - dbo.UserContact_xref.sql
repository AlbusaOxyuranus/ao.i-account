if object_id('dbo.UserContact_xref', 'U') is not null
	drop table dbo.UserContact_xref 

create table dbo.UserContact_xref
(
	[userContactId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[create_date] [datetime] NULL,
	[contactId] [int] NOT NULL,
	[modified_date] [datetime] NULL,
	 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[userId] ASC,
	[contactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO