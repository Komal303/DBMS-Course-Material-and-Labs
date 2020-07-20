Q1
SELECT [customer_id]
      ,[first_name]
      +' '+[last_name] AS CustomerName
      ,[email] AS Email
      ,[city] AS City
  FROM [BikeStores].[dbo].[customers] 
  Where state = 'NY'
***

Q2
Select stores.store_name AS StoreName
 ,products.product_name AS ProductName
 ,stocks.quantity AS QuantityOfProducts
From stores Join stocks
ON stores.store_id = stocks.store_id
JOIN products
ON stocks.product_id  = products.product_id
Group BY stocks.product_id, stocks.store_id, stores.store_name, products.product_name, stocks.quantity
***

Q3
Select stores.store_name
FROM stores
JOIN orders
ON stores.store_id = orders.store_id
Group BY stores.store_id
Having Count(*) = (Select Max(COUNT(*) )
FROM stores
JOIN orders
ON stores.store_id = orders.store_id
Group BY stores.store_id)
*** 


Q5
SELECT staff1.first_name + ' ' + staff1.last_name AS StaffMemberName,
staff2.first_name + ' ' + staff2.last_name AS ManagerName
From staffs as staff1
Join staffs as staff2
ON staff1.manager_id = staff2.staff_id
***


Q6
SELECT stores.store_name AS StoreName,
Count(staffs.staff_id) AS CountOfStaffMembers
FROM staffs
JOIN stores
ON staffs.store_id = stores.store_id
Group By stores.store_id, stores.store_name
***

 Q7
 SELECT customers.first_name + ' '+ customers.last_name as CustomerName,
 categories.category_name AS CategoryName
 FROM customers JOIN orders
 ON customers.customer_id = orders.customer_id
 JOIN order_items ON order_items.item_id = orders.order_id
 Join products On products.product_id = order_items.product_id
 jOIN categories
 ON categories.category_id = products.category_id
 Group By customers.customer_id, customers.first_name, customers.last_name, categories.category_name
 ***


 Q9
 SELECT customers.state
 From
 customers Join orders
 ON customers.customer_id = orders.order_id
 Group BY customers.customer_id
 Having COUNT(*) = (
 Select Max(Count(*))
 From orders  as order1
 Group By order1.customer_id
 Having Count(*) > 0)
 ***


