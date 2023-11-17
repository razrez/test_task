USE myDatabase;
SELECT p.ProductName as product, c.CategoryName as category
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.CategoryID