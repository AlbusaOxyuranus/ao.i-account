if(object_id('dbo.usp_Insert_Service') is not null)
	drop procedure dbo.usp_Insert_Service
go

create procedure dbo.usp_Insert_Service
(	
	@json nvarchar(max)
) as
begin
	insert into dbo.[Service] 
	(
	nameService,
	create_date
	)
	select 
		nameService, 
		getdate()
	from openjson(@json)
	with
	(
		nameService nvarchar(250) N'strict $."NameService"'
	)

	select scope_identity()	
end
go