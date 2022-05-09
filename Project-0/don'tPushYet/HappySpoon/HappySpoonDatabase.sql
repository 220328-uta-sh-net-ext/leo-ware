/*******************************************************************************
   HappySpoon Restaurant Review App Database - Version 1.0
   Script: Chinook_SqlServer.sql
   Description: Creates and populates the HappySpoon Restaurant Review App database.
   DB Server: HappySpoonRestaurantReviewApp
   Author: Leo Patrice J. Ware
   License: N/A3
********************************************************************************/

/*******************************************************************************
   Create Tables
********************************************************************************/

CREATE TABLE [dbo].[Users]
(
    [AccessID] NVARCHAR(2) NULL,
    [UserId] INT NULL,
    [Username] NVARCHAR(160) NOT NULL PRIMARY KEY,
    [Email] VARCHAR(40) NULL,
    [Password] VARCHAR(20) NULL
);
GO
CREATE TABLE [dbo].[Restaurants]
(
   [RestaurantId] INT NOT NULL PRIMARY KEY,
   [Name] NVARCHAR(30) NULL,
   [Description] NVARCHAR(100) NULL,
   [Location] VARCHAR(40) NULL,
   [ContactInfo] VARCHAR(80) NULL,
   [AverageStars] INT NULL
);
GO
CREATE TABLE [dbo].[Reviews]
(
   [Restaurant] NVARCHAR(30) NOT NULL PRIMARY KEY,
   [Username] NVARCHAR(160) NULL,
   [Stars] INT NULL,
   [Comments] VARCHAR(201) NULL 
);

INSERT INTO Users (AccessID, UserId, Username, Email,Password) VALUES
('B','2','CaraDanvers','jellybeandreams@yahoo.com', 'passwaord'),
('B', '3', 'AmericaChavez', 'missamerica@gmail.com', 'password'),
('A', '1', 'El Jefe', 'happyspoon@spoonies.com', '1234');

SELECT * FROM Users;