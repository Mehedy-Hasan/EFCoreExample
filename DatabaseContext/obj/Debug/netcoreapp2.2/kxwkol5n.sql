ALTER TABLE [Customers] ADD [ContactNo] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190426145809_Customer_ContactNo_Add', N'2.2.4-servicing-10062');

GO

