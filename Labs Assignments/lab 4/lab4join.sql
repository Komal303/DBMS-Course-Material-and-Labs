
/* Natural Join */
Select * from Customers 
join Orders ON Customers.CustomerID = Orders.CustomerID



/* Theeta Join */

Select * from Customers 
join Orders ON Customers.Country = Orders.ShipCountry






/* Inner Join */


Select * from Customers 
Inner join Orders ON Customers.Country = Orders.ShipCountry


/* Full jOin */
Select * from Customers 
Full join Orders ON Customers.Country = Orders.ShipCountry