if object_id('dbo.UserService_xref', 'U') is not null
	drop table dbo.[UserService_xref] 

create table dbo.[UserService_xref]
(
	[userServiceId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[serviceId] [int] NOT NULL,
	[create_date] [datetime] NOT NULL,
	[modified_date] [datetime] NOT NULL,
	constraint PK_User primary key ([userServiceId])	
)
go