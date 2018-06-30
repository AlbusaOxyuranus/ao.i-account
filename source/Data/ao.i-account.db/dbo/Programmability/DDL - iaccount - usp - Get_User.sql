use [i-account.db]
go

if(object_id('dbo.usp_Get_User') is not null)
	drop procedure dbo.usp_Get_User
go

create procedure dbo.usp_Get_User
(	
	@userId int
) as
begin
	
	select top (1) u.[userId],u.username,u.pwd  from dbo.[User] as u where u.[userId]= @userid
	for json path
end
go