USE OnlineRetailStore;
GO

WITH CustomerOrderCounts AS
(
SELECT
CustomerID,
COUNT(OrderID) AS OrderCount
FROM Orders
GROUP BY CustomerID
)

SELECT
c.CustomerID,
c.Name,
OrderCount

FROM CustomerOrderCounts coc

JOIN Customers c
ON c.CustomerID=coc.CustomerID

WHERE OrderCount>3;
GO