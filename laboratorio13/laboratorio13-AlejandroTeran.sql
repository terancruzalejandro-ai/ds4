-- Ejemplo 1 para selecconar todos los campos
select * from Products;

--Ejemplo 2 seleccionando ciertos campos

select ProductID, ProductName,Unitprice from products;

-- Ejemplo 3 seleccionando con campo logico

select productID, productname, unitprice from products where unitprice > 15;

-- Ejemplo 4: WHERE con AND
SELECT ProductID, ProductName, UnitPrice
FROM Products
WHERE UnitPrice >= 15 AND UnitPrice <= 50

-- Ejemplo 5: Usando BETWEEN
SELECT ProductID, ProductName, UnitPrice
FROM Products
WHERE UnitPrice BETWEEN 15 AND 50

-- Ejemplo 6: Usando NOT
SELECT ProductID, ProductName, UnitPrice
FROM Products
WHERE NOT UnitPrice > 15

-- Ejemplo 7: WHERE con OR
SELECT ProductID, ProductName, UnitPrice
FROM Products
WHERE ProductID > 15 OR UnitPrice < 10

-- Ejemplo 8: LIKE con %
SELECT EmployeeID, LastName FROM Employees
WHERE LastName LIKE 'D%'

-- Ejemplo 9: LIKE con %N
SELECT EmployeeID, LastName FROM Employees
WHERE LastName LIKE '%N'

-- Ejemplo 10: LIKE con %SALES%
SELECT EmployeeID, LastName, Title FROM Employees
WHERE Title LIKE '%SALES%'

-- Ejemplo 11: NOT LIKE
SELECT EmployeeID, LastName FROM Employees
WHERE LastName NOT LIKE 'D%'

-- Ejemplo 12: ORDER BY ascendente
SELECT ProductID, ProductName, UnitPrice
FROM Products
ORDER BY ProductID ASC

-- Ejemplo 13: ORDER BY descendente
SELECT ProductID, ProductName, UnitPrice
FROM Products
ORDER BY ProductID DESC

-- Ejemplo 14: DISTINCT
SELECT DISTINCT OrderID FROM [Order Details]

-- Ejemplo 15: TOP 5
SELECT TOP 5 OrderID, ProductID, Quantity
FROM [Order Details]

-- Ejemplo 16: TOP 10 PERCENT
SELECT TOP 10 PERCENT OrderID, ProductID, Quantity
FROM [Order Details]

-- Ejemplo 17: Alias de columna
SELECT CategoryName AS [Nombre de Categoría]
FROM Categories

-- Ejemplo 18: Alias con cálculo
SELECT OrderId, OrderDate, ShippedDate + 5 AS RetrasoEnvio
FROM Orders

-- Ejemplo 19: INNER JOIN
SELECT OrderID, P.ProductID, ProductName
FROM Products P
INNER JOIN [Order Details] OD
ON P.ProductID=OD.ProductID

-- Ejemplo 20: FULL JOIN
SELECT ProductName, CompanyName, ContactName
FROM Products P
FULL JOIN Suppliers S
ON P.SupplierID=S.SupplierID