CREATE DATABASE OnlineRetailStore;
GO

USE OnlineRetailStore;
GO

CREATE TABLE Customers
(
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(100),
    Region VARCHAR(50)
);

CREATE TABLE Categories
(
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(100)
);

CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    CategoryID INT,
    Price DECIMAL(10,2),
    FOREIGN KEY(CategoryID) REFERENCES Categories(CategoryID)
);

CREATE TABLE Orders
(
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderDetails
(
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY(OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY(ProductID) REFERENCES Products(ProductID)
);
GO
INSERT INTO Customers VALUES
(1,'Alice','North'),
(2,'Bob','South'),
(3,'Charlie','East'),
(4,'David','West');

INSERT INTO Categories VALUES
(1,'Electronics'),
(2,'Clothing'),
(3,'Books');

INSERT INTO Products VALUES
(1,'Laptop',1,800),
(2,'Phone',1,800),
(3,'TV',1,1200),
(4,'Shirt',2,50),
(5,'Jeans',2,70),
(6,'Novel',3,20),
(7,'Dictionary',3,40);

INSERT INTO Orders VALUES
(1,1,'2025-01-05'),
(2,1,'2025-01-10'),
(3,2,'2025-01-11'),
(4,3,'2025-01-12'),
(5,4,'2025-01-13'),
(6,1,'2025-01-14');

INSERT INTO OrderDetails VALUES
(1,1,1,2),
(2,1,4,5),
(3,2,2,1),
(4,2,3,1),
(5,3,5,3),
(6,4,6,8),
(7,5,7,6),
(8,6,1,1);
GO