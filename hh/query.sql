CREATE TABLE Category (
	id INT PRIMARY KEY,
	name NVARCHAR(255) NOT NULL
);

INSERT INTO Category 
VALUES  (1, 'Продукты'),
        (2, 'Бытовая химия');


CREATE TABLE Products (
	id int PRIMARY KEY,
	name varchar(255) NOT NULL,
);

INSERT INTO Products
VALUES  (1, 'Хлеб'),
		(2, 'Сыр'),
		(3, 'Мыло'),
        (4, 'Книга');

CREATE TABLE ProductsCategory (
	products_id  INT not null,
	category_id INT not null
);

INSERT INTO ProductsCategory
VALUES  (1, 1),
		(2, 1),
		(3, 2);

select prod.name [Имя продукта], cat.name [Имя категории]
from Products prod
left join ProductsCategory prodcat on prod.id = prodcat.products_id
inner join Category cat on cat.id = prodcat.category_id
order by prod.name