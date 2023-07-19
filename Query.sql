CREATE TABLE Categories(
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	Name NVARCHAR(128) NOT NULL
);

CREATE TABLE Products(
	Id INT NOT NULL IDENTITY PRIMARY KEY,
	Name NVARCHAR(128) NOT NULL,
);

CREATE TABLE Product_Category(
	ProductId INT NOT NULL,
	CategoryId INT NOT NULL
);

INSERT INTO Products (Name) VALUES
    (N'Метла'),
    (N'Тапочки'),
    (N'Витамины'),
    (N'Батон');

INSERT INTO Categories (Name) VALUES
    (N'Товар для дома'),
    (N'Товар для участка'),
    (N'Товар для здоровья');

INSERT INTO Product_Category (ProductId, CategoryId) VALUES
    (1, 1),
    (1, 2),
    (2, 1),
    (3, 3);

SELECT DISTINCT
    P.Name AS 'Имя продукта',
    ISNULL(C.Name, N'Без категории') AS 'Имя категории'
FROM
    Products P
LEFT JOIN
    Product_Category PC ON P.Id = PC.ProductId
LEFT JOIN
    Categories C ON PC.CategoryId = C.Id
ORDER BY
	P.Name;