if object_id('DF_User_modified_date') is not null
	alter table dbo.[User]
		drop constraint DF_User_modified_date
go

alter table dbo.[User]
	add constraint DF_User_modified_date default (getdate()) for modified_date

--ALTER TABLE dbo.[User]   
--ADD CONSTRAINT AK_Username UNIQUE ([username]);   
--GO 
GO


