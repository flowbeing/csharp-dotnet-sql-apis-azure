DROP TABLE IF EXISTS SchemaOne.Users;

-- IF OBJECT_ID('SchemaOne.Users') IS NOT NULL
--     DROP TABLE SchemaOne.Users;

CREATE TABLE SchemaOne.Users
(
    UserId INT IDENTITY(1, 1) PRIMARY KEY
    , FirstName NVARCHAR(50)
    , LastName NVARCHAR(50)
    , Email NVARCHAR(50)
    , Gender NVARCHAR(50)
    , Active BIT
);

DROP TABLE IF EXISTS SchemaOne.UserSalary;

-- IF OBJECT_ID('SchemaOne.UserSalary') IS NOT NULL
--     DROP TABLE SchemaOne.UserSalary;

CREATE TABLE SchemaOne.UserSalary
(
    UserId INT
    , Salary DECIMAL(18, 4)
);

DROP TABLE IF EXISTS SchemaOne.UserJobInfo;

-- IF OBJECT_ID('SchemaOne.UserJobInfo') IS NOT NULL
--     DROP TABLE SchemaOne.UserJobInfo;

CREATE TABLE SchemaOne.UserJobInfo
(
    UserId INT
    , JobTitle NVARCHAR(50)
    , Department NVARCHAR(50),
);

-- USE DotNetCourseDatabase;
-- GO

-- SELECT  [UserId]
--         , [FirstName]
--         , [LastName]
--         , [Email]
--         , [Gender]
--         , [Active]
--   FROM  SchemaOne.Users;

-- SELECT  [UserId]
--         , [Salary]
--   FROM  SchemaOne.UserSalary;

-- SELECT  [UserId]
--         , [JobTitle]
--         , [Department]
--   FROM  SchemaOne.UserJobInfo;