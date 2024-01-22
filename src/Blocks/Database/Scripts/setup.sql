USE [master]
GO

-- Drop the database if it exists
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'SearchDb')
    DROP DATABASE SearchDb
GO

-- Create the database
CREATE DATABASE SearchDb
GO

-- Use the newly created database
USE SearchDb
GO

-- Create the Item table with a primary key constraint and an index
CREATE TABLE [dbo].[Item](
    [ItemID] [uniqueidentifier] NOT NULL PRIMARY KEY,
    [ItemName] [nvarchar](max) NOT  NULL,
    [Description] [nvarchar](max) NOT NULL,
    [Date] DATETIME NOT NULL
);

-- Create an index on the Title column
CREATE INDEX IX_Item_Name ON [dbo].[Item] ([ItemName]);