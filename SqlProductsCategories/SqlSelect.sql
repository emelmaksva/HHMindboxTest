SELECT Products.name as 'Продукт', Categories.name as 'Категория'
FROM ProductsCategories
JOIN Products ON Products.id = ProductsCategories.ProductId
JOIN Categories ON Categories.id = ProductsCategories.CategoryId ;

--Аналогично

SELECT
(SELECT name FROM Products		WHERE id = ProductsCategories.ProductId) as 'Продукт',
(SELECT name FROM Categories	WHERE id = ProductsCategories.CategoryId) as 'Категория'
FROM ProductsCategories