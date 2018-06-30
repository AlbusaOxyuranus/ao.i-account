if(object_id('dbo.usp_Get_User') is not null)
	drop procedure dbo.usp_Get_User
go

create procedure dbo.usp_Get_User
(	
	@userId int
) as
begin
	
	select top (1) u.[userId] as UserId, u.username as Username, u.pwd as Password  from dbo.[User] as u where u.[userId]= @userid
	for json path
end
go