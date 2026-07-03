USE OnlineRetailStore;
GO

SELECT
    c.Region,
    cat.CategoryName,
    SUM(od.Quantity) TotalQuantity
FROM Orders o
JOIN Customers c
ON o.CustomerID=c.CustomerID

JOIN OrderDetails od
ON o.OrderID=od.OrderID

JOIN Products p
ON od.ProductID=p.ProductID

JOIN Categories cat
ON p.CategoryID=cat.CategoryID

GROUP BY GROUPING SETS
(
    (c.Region,cat.CategoryName),
    (c.Region),
    (cat.CategoryName),
    ()
);
GO

SELECT
    c.Region,
    cat.CategoryName,
    SUM(od.Quantity) TotalQuantity
FROM Orders o
JOIN Customers c
ON o.CustomerID=c.CustomerID
JOIN OrderDetails od
ON o.OrderID=od.OrderID
JOIN Products p
ON od.ProductID=p.ProductID
JOIN Categories cat
ON p.CategoryID=cat.CategoryID
GROUP BY ROLLUP(c.Region,cat.CategoryName);
GO

SELECT
    c.Region,
    cat.CategoryName,
    SUM(od.Quantity) TotalQuantity
FROM Orders o
JOIN Customers c
ON o.CustomerID=c.CustomerID
JOIN OrderDetails od
ON o.OrderID=od.OrderID
JOIN Products p
ON od.ProductID=p.ProductID
JOIN Categories cat
ON p.CategoryID=cat.CategoryID
GROUP BY CUBE(c.Region,cat.CategoryName);
GO
