/******************TASK # 1**************************/
/* List all the products whose price is more than average price. */

SELECT  [OrderID]
      ,[ProductID]
      ,[UnitPrice]
      ,[Quantity]
      ,[Discount]
  FROM [Northwind].[dbo].[Order Details] where UnitPrice > (Select avg(UnitPrice) from [Northwind].[dbo].[Products]);



/*******************TASK # 2************************/
/* Find second highest priced product without using TOP statement.*/

Select * from [Northwind].[dbo].[Products] Where UnitPrice = (
SELECT max(UnitPrice)
  FROM [Northwind].[dbo].[Products] where UnitPrice < (Select Max(UnitPrice) from [Northwind].[dbo].[Products]));



/*********************** TASK # 3 ***********************/
/*Are there any employees who are older than their managers? List that names of
those employees and their ages.*/

SELECT [FirstName]+' '+[LastName] as Name,
      Year(getdate())- YEAR([BirthDate]) as Age
  FROM [Northwind].[dbo].[Employees] where BirthDate < (select 
      Min([BirthDate]) From [Northwind].[dbo].[Employees] Where Title = 'Sales Manager');


/**************** TASK # 4 *****************************/  
/* List the names of products which were ordered on 8th August 1997. */

   
Select Products.ProductName From [Northwind].[dbo].[Products] Where Products.ProductID =any(
Select ProductID from [Northwind].[dbo].[Order Details] where OrderID = 
(select OrderID FROM [Northwind].[dbo].[Orders] where Orders.OrderDate = CAST('1997-08-08' as datetime)))




/*******************TASK # 5 *************************/
/* List the addresses, cities, countries of all orders which were serviced by Anne and
were shipped late. */
SELECT
[ShipAddress]
      ,[ShipCity]
      ,[ShipCountry]
  FROM [Northwind].[dbo].[Orders] where EmployeeID = (SELECT EmployeeID from [Northwind].[dbo].[Employees] where FirstName = 'Anne') AND RequiredDate < ShippedDate;



/*******************TASK # 6******************************/
/* List all countries to which beverages have been shipped. */

SELECT ShipCountry FROM [Northwind].[dbo].[Orders] WHERE OrderID = ANY 
(SELECT OrderID FROM [Northwind].[dbo].[Order Details] WHERE ProductID = ANY 
(SELECT ProductID FROM [Northwind].[dbo].[Products] WHERE RIGHT(QuantityPerUnit, 7) = 'bottles'))
GROUP BY ShipCountry