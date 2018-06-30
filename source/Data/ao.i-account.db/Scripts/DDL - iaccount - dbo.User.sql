if object_id('dbo.User', 'U') is not null
	drop table dbo.[User] 

create table dbo.[User]
(
	[userId] int not null identity(1,1),
	username NVARCHAR(100) not null,
	pwd NVARCHAR(100) not null,
	create_date datetime,
	modified_date datetime,
	CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

go