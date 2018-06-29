if object_id('dbo.User', 'U') is not null
	drop table dbo.[User] 

create table dbo.[User]
(
	user_id int not null identity(1,1),
	username NVARCHAR(100) not null,
	pwd NVARCHAR(100) not null,
	create_date datetime,
	modified_date datetime,
	constraint PK_User primary key (user_id)	
)
go