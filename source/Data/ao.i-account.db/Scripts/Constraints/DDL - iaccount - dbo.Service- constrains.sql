if object_id('DF_Service_modified_date') is not null
	alter table dbo.[Service]
		drop constraint DF_Service_modified_date
go

alter table dbo.[Service]
	add constraint DF_Service_modified_date default (getdate()) for modified_date

--ALTER TABLE dbo.[User]   
--ADD CONSTRAINT AK_Username UNIQUE ([username]);   
--GO 
GO


