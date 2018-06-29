use [i-account.db]
go

if(object_id('dbo.usp_Insert_User') is not null)
	drop procedure dbo.usp_Insert_User
go

create procedure dbo.usp_Insert_User
(	
	@username nvarchar(256),
	@password nvarchar(256)
) as
begin
	insert into dbo.[User] 
	(
	username,
	pwd,
	create_date
	)
	values
	(
		@username,
		@password,
		getdate()		
	)
	select scope_identity()	
end
go