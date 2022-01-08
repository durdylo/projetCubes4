CREATE TABLE [dbo].[Salary]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] NVARCHAR(50) NULL, 
    [firstname] NVARCHAR(50) NULL, 
    [tel_fix] NCHAR(10) NULL, 
    [tel_port] NCHAR(10) NULL, 
    [email] NVARCHAR(50) NULL, 
    [id_service] INT NULL, 
    [id_site] INT NULL, 
    CONSTRAINT [FK_Salary_ToTable] FOREIGN KEY ([id_service]) REFERENCES [Service]([Id]), 
    CONSTRAINT [FK_Salary_ToTable_1] FOREIGN KEY (id_site) REFERENCES [Site]([Id]) 
)
