use [i-account.db]
go

if object_id('DF_User_modified_date') is not null
	alter table dbo.Person
		drop constraint DF_User_modified_date
go

alter table dbo.[User]
	add constraint DF_User_modified_date default (getdate()) for modified_date
go
