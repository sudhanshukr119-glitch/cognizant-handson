USE OnlineRetailStore;
GO

SELECT
    CategoryID,
    ProductName,
    Price,

    ROW_NUMBER() OVER
    (
        PARTITION BY CategoryID
        ORDER BY Price DESC
    ) AS RowNum,

    RANK() OVER
    (
        PARTITION BY CategoryID
        ORDER BY Price DESC
    ) AS RankNum,

    DENSE_RANK() OVER
    (
        PARTITION BY CategoryID
        ORDER BY Price DESC
    ) AS DenseRank

FROM Products;
GO