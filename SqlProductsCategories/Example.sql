--Допустим есть Product1 в Category1
--				Product2 в Category2
--				Product3 в Category2 и в Category1
--				Product4 в без категории (Category0)

INSERT INTO Products VALUES
(1, 'Product1'),
(2, 'Product2'),
(3, 'Product3'),
(4, 'Product4');

INSERT INTO Categories VALUES
(0, 'No category'),
(1, 'Category1'),
(2, 'Category2');

INSERT INTO ProductsCategories VALUES
(1, 1),
(2, 2),
(3, 2),
(3, 1),
(4, 0);

SELECT Products.name as 'Продукт', Categories.name as 'Категория'
FROM ProductsCategories
JOIN Products ON Products.id = ProductsCategories.ProductId
JOIN Categories ON Categories.id = ProductsCategories.CategoryId ;