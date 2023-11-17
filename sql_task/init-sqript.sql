USE master
GO
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'myDatabase')
BEGIN
    CREATE DATABASE myDatabase
END
GO

USE myDatabase;

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(255) NOT NULL
);

CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName NVARCHAR(255) NOT NULL
);

CREATE TABLE ProductCategories (
    ProductID INT,
    CategoryID INT,
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

INSERT INTO Products (ProductID, ProductName) VALUES
(1, 'Product 1'),
(2, 'Product 2'),
(3, 'Product 3'),
(4, 'Product without category');

INSERT INTO Categories (CategoryID, CategoryName) VALUES
(1, 'Category 1'),
(2, 'Category 2'),
(3, 'Category 3');

INSERT INTO ProductCategories (ProductID, CategoryID) VALUES
(1, 1),
(1, 2),
(2, 3),
(3, 1),
(3, 2),
(3, 3);