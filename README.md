# 1. FigureCalculates

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

Юнит-тесты

Легкость добавления других фигур

Вычисление площади фигуры без знания типа фигуры в compile-time

Проверку на то, является ли треугольник прямоугольным 

# 2. MS SQL query

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
https://gist.github.com/Artelove/9233e9950fd31192e174ff4ce6a78108
```
CREATE TABLE Product (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

CREATE TABLE Category (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Product
VALUES
	(1, 'C++'),
	(2, 'C#'),
	(3, '.NET'),
  (4, 'Godot');
    
INSERT INTO Category
VALUES
	(1, 'Language'),
	(2, 'Platform'),
	(3, 'Framework');


CREATE TABLE ProductCategory (
    Id INT PRIMARY KEY IDENTITY,
	ProductId INT, 
  	FOREIGN KEY (ProductId) REFERENCES Product(Id),
	CategoryId INT, 
  	FOREIGN KEY (CategoryId) REFERENCES Category(Id),
);

INSERT INTO ProductCategory
VALUES
	(1, 1),
	(2, 1),
	(3, 2);

SELECT P."Name", C."Name"
FROM Product P
LEFT JOIN ProductCategory PC
	ON P.Id = PC.ProductId
LEFT JOIN Category C
	ON PC.CategoryId = C.Id;
```
Результат запроса:
![image](https://user-images.githubusercontent.com/66765809/219169161-40b23a6b-1937-4391-b02c-a3fa5c6a7730.png)
