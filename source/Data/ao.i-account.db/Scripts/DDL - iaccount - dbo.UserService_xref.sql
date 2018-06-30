if object_id('dbo.UserService_xref', 'U') is not null
	drop table dbo.[UserService_xref] 

create table dbo.[UserService_xref]
(
	[userServiceId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[serviceId] [int] NOT NULL,
	[create_date] [datetime] NOT NULL,
	[modified_date] [datetime] NOT NULL,
	CONSTRAINT [PK_UserService_xref] PRIMARY KEY CLUSTERED 
(
	[userId] ASC,
	[serviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

go