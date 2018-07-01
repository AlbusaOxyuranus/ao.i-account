if(object_id('dbo.usp_Get_Service') is not null)
	drop procedure dbo.usp_Get_Service
go

create procedure dbo.usp_Get_Service
(	
	@id int
) as
begin
	
	select top (1) u.[serviceId] as Id,u.nameService as NameService  from dbo.[Service] as u where u.[serviceId]= @id
	for json path
end
go