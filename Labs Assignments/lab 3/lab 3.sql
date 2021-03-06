/****** Script for SelectTopNRows command from SSMS  ******/
SELECT Avg([Quantity])
     
  FROM [Northwind].[dbo].[Order Details]

SELECT Min([UnitPrice])
     
  FROM [Northwind].[dbo].[Order Details]

SELECT Sum([Quantity])
     
  FROM [Northwind].[dbo].[Order Details]
SELECT Sum([Discount])
     
  FROM [Northwind].[dbo].[Order Details]

SELECT STDEV([UnitPrice])
     
  FROM [Northwind].[dbo].[Order Details]
SELECT STDEVP([UnitPrice])
     
  FROM [Northwind].[dbo].[Order Details]

SELECT Var([Quantity])
     
  FROM [Northwind].[dbo].[Order Details]
SELECT VARP([Quantity])
     
  FROM [Northwind].[dbo].[Order Details]
SELECT Max([UnitPrice])
     
  FROM [Northwind].[dbo].[Order Details]

/** Task 2 ***/
SELECT OrderID, AVG(UnitPrice)
FROM [Northwind].[dbo].[Order Details]
GROUP BY OrderID


/* Task 3 ***/
SELECT OrderID, AVG(UnitPrice)
FROM [Northwind].[dbo].[Order Details]
GROUP BY OrderID
HAVING OrderID > 1000

/*** Task 4 ***/
SELECT OrderID AS ID
FROM [Northwind].[dbo].[Order Details];

SELECT OrderID 
FROM [Northwind].[dbo].[Order Details] AS AllOrders;



/********** Extraaa ***************/
SELECT
      Year([BirthDate])
    
  FROM [Northwind].[dbo].[Employees]
SELECT
      Month([BirthDate])
    
  FROM [Northwind].[dbo].[Employees]
SELECT
      Day([BirthDate])
    
  FROM [Northwind].[dbo].[Employees]