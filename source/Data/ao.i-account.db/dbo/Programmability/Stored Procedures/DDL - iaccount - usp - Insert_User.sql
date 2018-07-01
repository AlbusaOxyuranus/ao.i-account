if(object_id('dbo.usp_Insert_User') is not null)
	drop procedure dbo.usp_Insert_User
go

create procedure dbo.usp_Insert_User
(	
	@json nvarchar(max)
) as
begin
	insert into dbo.[User] 
	(
	username,
	pwd,
	create_date
	)
	select 
		username, 
		pwd, 
		getdate()
	from openjson(@json)
	with
	(
		username nvarchar(250) N'strict $."Username"',
		pwd nvarchar(250) N'strict $."Password"'
	
	)

	select scope_identity()	
end
go