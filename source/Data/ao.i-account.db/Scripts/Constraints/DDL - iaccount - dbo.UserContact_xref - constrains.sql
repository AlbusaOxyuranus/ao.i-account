
ALTER TABLE [dbo].[UserContact_xref]  WITH CHECK ADD  CONSTRAINT [FK_UserContact_xref_Contact] FOREIGN KEY([contactId])
REFERENCES [dbo].[Contact] ([contactId])
GO

ALTER TABLE [dbo].[UserContact_xref] CHECK CONSTRAINT [FK_UserContact_xref_Contact]
GO

ALTER TABLE [dbo].[UserContact_xref]  WITH CHECK ADD  CONSTRAINT [FK_UserContact_xref_User] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
GO

ALTER TABLE [dbo].[UserContact_xref] CHECK CONSTRAINT [FK_UserContact_xref_User]
GO