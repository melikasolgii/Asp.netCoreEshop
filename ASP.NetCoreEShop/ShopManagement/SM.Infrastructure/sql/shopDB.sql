IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF SCHEMA_ID(N'LampshadeDB') IS NULL EXEC(N'CREATE SCHEMA [LampshadeDB];');
GO

CREATE TABLE [LampshadeDB].[ProductCategories] (
    [Id] bigint NOT NULL IDENTITY,
    [Name] nvarchar(255) NOT NULL,
    [Description] nvarchar(500) NOT NULL,
    [Picture] nvarchar(1000) NOT NULL,
    [PictureAlt] nvarchar(255) NOT NULL,
    [PictureTitle] nvarchar(500) NOT NULL,
    [Keywords] nvarchar(max) NOT NULL,
    [MetaDescription] nvarchar(150) NOT NULL,
    [Slug] nvarchar(300) NOT NULL,
    [CreationDate] datetime2 NOT NULL,
    CONSTRAINT [PK_ProductCategories] PRIMARY KEY ([Id])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240723091312_shopDB', N'8.0.7');
GO

COMMIT;
GO

