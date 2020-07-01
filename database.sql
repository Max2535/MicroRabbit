/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[AccontType]
      ,[AccountBalance]
  FROM [BankingDB].[dbo].[Accounts]