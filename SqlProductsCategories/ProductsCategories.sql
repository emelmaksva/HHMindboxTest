CREATE TABLE ProductsCategories2 (
    ProductId  INT NOT NULL,
    CategoryId INT NOT NULL DEFAULT 0,
    FOREIGN KEY (ProductId)		REFERENCES Products(id),
    FOREIGN KEY (CategoryId)	REFERENCES Categories(id)
);