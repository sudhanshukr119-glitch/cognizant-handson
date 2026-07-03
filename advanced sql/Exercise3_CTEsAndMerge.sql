USE OnlineRetailStore;
GO

WITH Calendar AS
(
SELECT CAST('2025-01-01' AS DATE) AS DateValue

UNION ALL

SELECT DATEADD(DAY,1,DateValue)
FROM Calendar
WHERE DateValue<'2025-01-31'
)

SELECT *
FROM Calendar
OPTION(MAXRECURSION 100);
GO

CREATE TABLE StagingProducts
(
ProductID INT,
ProductName VARCHAR(100),
CategoryID INT,
Price DECIMAL(10,2)
);

INSERT INTO StagingProducts VALUES
(1,'Laptop',1,850),
(8,'Tablet',1,500);

MERGE Products AS Target

USING StagingProducts AS Source

ON Target.ProductID=Source.ProductID

WHEN MATCHED THEN

UPDATE SET
Price=Source.Price

WHEN NOT MATCHED THEN

INSERT(ProductID,ProductName,CategoryID,Price)

VALUES
(Source.ProductID,
Source.ProductName,
Source.CategoryID,
Source.Price);

GO