/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ProductId]
      ,[Name]
      ,[Description]
      ,[Price]
      ,[Category]
  FROM [ECommerceSite].[dbo].[Products]

  UPDATE Products  
  SET Description = 'Titanium club'
  WHERE ProductId = 3;

  SELECT * FROM Products

  UPDATE Products  
  SET Name = 'Hat'
  WHERE ProductId = 2;

  UPDATE Products  
  SET Name = 'Shirt'
  WHERE ProductId = 9;

  UPDATE Products  
  SET Description = 'Cotton shirt'
  WHERE ProductId = 9;

  UPDATE Products  
  SET Name = 'Chain'
  WHERE ProductId = 4;

  UPDATE Products  
  SET Description = 'White tube socks'
  WHERE ProductId = 10;

  SELECT * FROM Products

  UPDATE Products  
  SET Name = 'Pants'
  WHERE ProductId = 1;