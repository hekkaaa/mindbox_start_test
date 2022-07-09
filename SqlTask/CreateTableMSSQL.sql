create table dbo.Product
(
	ProductId int primary key,
	ProductName nvarchar(128) not null,
)

-- Заполним таблицу Product данными.
insert into dbo.Product(ProductId, ProductName) values (1, N'Коровка')
insert into dbo.Product(ProductId, ProductName) values (2, N'Омичка')
insert into dbo.Product(ProductId, ProductName) values (3, N'Кола')
insert into dbo.Product(ProductId, ProductName) values (4, N'Бородинский')
insert into dbo.Product(ProductId, ProductName) values (5, N'Селяночка')
insert into dbo.Product(ProductId, ProductName) values (6, N'Карачинская')
insert into dbo.Product(ProductId, ProductName) values (7, N'Милка')
insert into dbo.Product(ProductId, ProductName) values (8, N'Лейс')

create table dbo.Category
(
	CategoryId int primary key,
	CategoryName nvarchar(64) not null
)

-- Заполним таблицу Category данными.
insert into dbo.Category(CategoryId, CategoryName) values(1, N'Молоко')
insert into dbo.Category(CategoryId, CategoryName) values(2, N'Минеральная вода')
insert into dbo.Category(CategoryId, CategoryName) values(3, N'Газированя вода')
insert into dbo.Category(CategoryId, CategoryName) values(4, N'Хлеб')
insert into dbo.Category(CategoryId, CategoryName) values(5, N'Шоколад')
insert into dbo.Category(CategoryId, CategoryName) values(6, N'Творог')
insert into dbo.Category(CategoryId, CategoryName) values(7, N'Сыр')
insert into dbo.Category(CategoryId, CategoryName) values(8, N'Рыбные консервы')
insert into dbo.Category(CategoryId, CategoryName) values(9, N'Макаронные изделия')


-- Заполним таблицу ProductCategory данными.
create table dbo.ProductsCategory
(
	ProductId int foreign key references dbo.Product(ProductId),
	CategoryId int foreign key references dbo.Category(CategoryId),
	primary key(ProductId, CategoryId)
)

insert into dbo.ProductsCategory(ProductId, CategoryId) values (1, 1)
insert into dbo.ProductsCategory(ProductId, CategoryId) values (1, 6)
insert into dbo.ProductsCategory(ProductId, CategoryId) values (2, 3)
insert into dbo.ProductsCategory(ProductId, CategoryId) values (2, 7)
insert into dbo.ProductsCategory(ProductId, CategoryId) values (3, 3)
insert into dbo.ProductsCategory(ProductId, CategoryId) values (4, 4)
insert into dbo.ProductsCategory(ProductId, CategoryId) values (6, 2)
insert into dbo.ProductsCategory(ProductId, CategoryId) values (7, 5)
insert into dbo.ProductsCategory(ProductId, CategoryId) values (7, 1)