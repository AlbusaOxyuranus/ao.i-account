if object_id('dbo.Contact', 'U') is not null
	drop table dbo.Contact 

create table dbo.Contact
(
	contact_id int not null identity(1,1),
	user_id int not null,
	constraint PK_Contact primary key (contact_id)	
)
go