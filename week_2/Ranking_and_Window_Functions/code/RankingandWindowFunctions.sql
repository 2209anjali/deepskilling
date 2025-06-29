IF OBJECT_ID('dbo.ProductInfo', 'U') IS NOT NULL
    DROP TABLE dbo.ProductInfo;

CREATE TABLE ProductInfo (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(100),
    Category NVARCHAR(50),
    Price DECIMAL(10, 2)
);


INSERT INTO ProductInfo (ProductID, ProductName, Category, Price)
VALUES 
(1, 'Pen', 'Stationery', 80.00),
(2, 'Diary', 'Stationery', 200.00),
(3, 'Leather File', 'Stationery', 450.00),
(4, 'Belt', 'Clothing', 800.00),
(5, 'T Shirt', 'Clothing', 300.00),
(6, 'Pan', 'Kitchen', 1500.00),
(7, 'Jeans', 'Clothing', 590.00),
(8, 'IPad', 'Electronic ', 2200.00),
(9, 'Watch', 'Furniture', 1500.00),
(10, 'Scarf', 'Clothing', 600.00);



SELECT *
FROM (
    SELECT 
        ProductID,
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum,
        RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum,
        DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankNum
    FROM ProductInfo
) AS RankedProducts
WHERE RowNum <= 3 OR RankNum <= 3 OR DenseRankNum <= 3
ORDER BY Category, Price DESC;
