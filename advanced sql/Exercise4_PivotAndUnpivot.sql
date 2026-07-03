USE OnlineRetailStore;
GO

SELECT *
FROM
(
SELECT
p.ProductName,
MONTH(o.OrderDate) AS SalesMonth,
od.Quantity
FROM Orders o
JOIN OrderDetails od
ON o.OrderID=od.OrderID
JOIN Products p
ON od.ProductID=p.ProductID
) AS SourceTable

PIVOT
(
SUM(Quantity)

FOR SalesMonth IN
([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12])

) AS PivotTable;
GO