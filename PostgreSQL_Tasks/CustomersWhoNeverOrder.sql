SELECT name AS Customers 
FROM Customers 
LEFT JOIN Orders ON Customers.id = Orders.CustomerID
WHERE Orders.id IS NULL;