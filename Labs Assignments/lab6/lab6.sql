
SELECT [EmployeeID]
      ,[LastName]
      ,[FirstName]
      ,[Title]
      ,[TitleOfCourtesy]
      ,[BirthDate]
      ,[HireDate]
      ,[Address]
      ,[City]
      ,[Region]
      ,[PostalCode]
      ,[Country]
      ,[HomePhone]
      ,[Extension]
  FROM [Northwind].[dbo].[Employees] Where Country='USA'
Union
Select [EmployeeID]
      ,[LastName]
      ,[FirstName]
      ,[Title]
      ,[TitleOfCourtesy]
      ,[BirthDate]
      ,[HireDate]
      ,[Address]
      ,[City]
      ,[Region]
      ,[PostalCode]
      ,[Country]
      ,[HomePhone]
      ,[Extension]
	  FROM [Northwind].[dbo].[Employees] Where Not(City = 'Redmond')



SELECT [EmployeeID]
      ,[LastName]
      ,[FirstName]
      ,[Title]
      ,[TitleOfCourtesy]
      ,[BirthDate]
      ,[HireDate]
      ,[Address]
      ,[City]
      ,[Region]
      ,[PostalCode]
      ,[Country]
      ,[HomePhone]
      ,[Extension]
  FROM [Northwind].[dbo].[Employees] Where Country='USA'
Intersect
Select [EmployeeID]
      ,[LastName]
      ,[FirstName]
      ,[Title]
      ,[TitleOfCourtesy]
      ,[BirthDate]
      ,[HireDate]
      ,[Address]
      ,[City]
      ,[Region]
      ,[PostalCode]
      ,[Country]
      ,[HomePhone]
      ,[Extension]
	  FROM [Northwind].[dbo].[Employees] Where Not(City = 'Redmond')

SELECT [Freight]
  FROM [Northwind].[dbo].[Orders]
Union
  SELECT [EmployeeID]
  FROM [Northwind].[dbo].[Orders]


SELECT [Freight]
  FROM [Northwind].[dbo].[Orders]
Intersect
  SELECT [EmployeeID]
  FROM [Northwind].[dbo].[Orders]


