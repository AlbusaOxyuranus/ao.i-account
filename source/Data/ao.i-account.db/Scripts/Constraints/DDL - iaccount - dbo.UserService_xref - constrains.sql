ALTER TABLE [dbo].[UserService_xref]  WITH CHECK ADD  CONSTRAINT [FK_UserService_xref_Service] FOREIGN KEY([serviceId])
REFERENCES [dbo].[Service] ([serviceId])
GO

ALTER TABLE [dbo].[UserService_xref] CHECK CONSTRAINT [FK_UserService_xref_Service]
GO

ALTER TABLE [dbo].[UserService_xref]  WITH CHECK ADD  CONSTRAINT [FK_UserService_xref_User] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
GO

ALTER TABLE [dbo].[UserService_xref] CHECK CONSTRAINT [FK_UserService_xref_User]
GO


