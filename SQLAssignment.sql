CREATE DATABASE ShoppingCartDb

USE ShoppingCartDb

DROP TABLE Users

CREATE TABLE Users
(
	UserId INT PRIMARY KEY,
	UserName VARCHAR(20) NOT NULL,
	Password VARCHAR(20) NOT NULL,
	ContactNumber BIGINT,
	City VARCHAR(20)
);

INSERT INTO Users VALUES(7369,'SMITH','CLERK',9490466799, 'HYDERABAD');
INSERT INTO Users VALUES(2349,'JACOB','PAUL',9492366799, 'DELHI');
INSERT INTO Users VALUES(3369,'PETER','MANNE',9550466799, 'COORG');
INSERT INTO Users VALUES(5669,'HUGO','BOSS',9456766799, 'VIZAG');
INSERT INTO Users VALUES(8869,'NOAH','JOHN',6490466799, 'BANGLORE');

DROP TABLE Products

CREATE TABLE Products
(
	ProductID INT PRIMARY KEY,
	Name VARCHAR(20) NOT NULL,
	QuantityInStock INT NOT NULL CHECK(QuantityInStock>0),
	UnitPrice INT NOT NULL CHECK(UnitPrice>0),
	Category VARCHAR(20) NOT NULL
);

INSERT INTO Products VALUES(1369,'LAPTOP',3,30000, 'ELECTRONICS');
INSERT INTO Products VALUES(4349,'PHONE',3,60000, 'ELECTRONICS');
INSERT INTO Products VALUES(5769,'CHAIR',6,5000, 'FURNITURE');
INSERT INTO Products VALUES(4469,'CAMERA',4,20000, 'ELECTRONICS');
INSERT INTO Products VALUES(2069,'SOFA',3,40000, 'FURNITURE');

DROP TABLE Cart

CREATE TABLE Cart
(
	Id INT PRIMARY KEY,
	CartId INT NOT NULL,
	ProductID INT,
	Quantity INT NOT NULL CHECK(Quantity>0),
	CONSTRAINT  FK_Cart_Products  FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

INSERT INTO Cart VALUES(1,2765,1369,2);
INSERT INTO Cart VALUES(2,5643,2069,2);
INSERT INTO Cart VALUES(3,4432,4349,2);
INSERT INTO Cart VALUES(4,7854,5769,3);
INSERT INTO Cart VALUES(5,8989,4469,3);

// PRODUCT TABLE QUERIES

SELECT * FROM Products

SELECT * FROM Products 
where category = 'ELECTRONICS'

INSERT INTO Products VALUES(8569,'DESK',6,4000, 'FURNITURE');
INSERT INTO Cart VALUES(6,7732,8569,4);

UPDATE Products SET QuantityInStock = 0 where ProductId = 8569

SELECT * FROM Products 
where QuantityInStock = 0

SELECT * FROM Products 
where UnitPrice>1000 AND UnitPrice<10000

SELECT * FROM Products ORDER BY ProductID

// CART TABLE

SELECT * FROM CART where CartId = 5643

INSERT INTO Products VALUES(2999,'WATCH',2,25000, 'ACCESORIES');

SELECT ProductID, Name FROM Products where ProductID in (SELECT PRODUCTID FROM Cart)

SELECT * FROM Users

SELECT * FROM Users Order By ContactNumber

SELECT * FROM USers Order By UserId

--ASSIGNMENT 2

--2.1. Write the sql queries for the following requirements  by using joins concept:

--	a. Consider the Products table and Cart table 

--	b. Write a Query to display the results from the above two tables:
--			CartId,  ProductName, Quantity, UnitPrice
			
--		Hint :  Quantity should takes from Cart table
			
--	c.  Try to appy inner join,  right outer join , left outer join and full outer join on the above tables.

SELECT CartId, Name, Quantity, UnitPrice FROM Products INNER JOIN Cart on Products.ProductID = Cart.ProductID;

SELECT CartId, Name, Quantity, UnitPrice FROM Products RIGHT OUTER JOIN Cart on Products.ProductID = Cart.ProductID;

SELECT CartId, Name, Quantity, UnitPrice FROM Products LEFT OUTER JOIN Cart on Products.ProductID = Cart.ProductID;

SELECT CartId, Name, Quantity, UnitPrice FROM Products FULL OUTER JOIN Cart on Products.ProductID = Cart.ProductID;
	
	
 
--2.2. Write the sql queries for the following requirements  by using Group By concept:

--	Hint :   -->   Create a table Called "Student"  table with the following columns:
--							StudentId,  StudentName,  CourseName,  City Name, ContactNumber
--					-->   Insert some 10 rows in the above table. 
--	a.   Find out how many Students are joined for "Angular"  Course
--	b.   Find out how many Students are joined from  "Hyderabad"  City
--	c.    Display No. of Students are join from each  City based 
	
--			Sample Output:
--						Hyderabad    10
--						Mumbai   20
--						Pune   5
--						.....
	
--	d.    Display No. of Students are join from each  Course  based 
--			Sample Outupt:
--					Angular    10
--					React       20
--					.NET        30
--					....... 
					
--	e.     Display the counts  by grouping based on  city, course 


CREATE TABLE Student
(
	StudentID INT PRIMARY KEY,
	StudentName VARCHAR(20) NOT NULL,
	CourseName VARCHAR(20) NOT NULL,
	CityName VARCHAR(20) NOT NULL,
	ContactNumber BIGINT
);

INSERT INTO Student Values(4563,'VARSHA','ANGULAR','HYDERABAD',9490467101)
INSERT INTO Student Values(5673,'KEVIN','CSE','CHENNAI',9650467101)
INSERT INTO Student Values(3263,'AAKASH','CIVIL','DELHI',9489467101)
INSERT INTO Student Values(9083,'AAKAR','ANGULAR','HYDERABAD',7690467101)
INSERT INTO Student Values(4623,'SLOKA','CCE','CHENNAI',9490466201)
INSERT INTO Student Values(2263,'RAKESH','SQL','DELHI',9456467101)
INSERT INTO Student Values(2763,'AADHARSH','SQL','PUNE',9490467999)
INSERT INTO Student Values(4993,'PRAKASH','CIVIL','CHENNAI',9494367101)
INSERT INTO Student Values(4593,'LAKSHMI','ANGULAR','DELHI',8990467101)
INSERT INTO Student Values(4533,'VINAY','BME','LUCKNOW',9670467101)

SELECT COUNT(*) FROM Student where CourseName = 'ANGULAR'

SELECT COUNT(*) FROM Student where CityName = 'HYDERABAD'

SELECT CityName, COUNT(*) As TotalStudentFromEachCity FROM Student Group By CityName

SELECT CourseName, COUNT(*) As TotalStudentFromEachCourse FROM Student Group By CourseName


	
 
	
--2.3.  Prepare the sql queries for the following requirements (use subqueries):
			
--			a.   Display the products if any items exists in the cart table

SELECT ProductID, Name FROM Products where ProductID in (SELECT PRODUCTID FROM Cart)


--			b.   Display the cart items whoe product price greater than 5000 

SELECT * FROM Products
Where ProductID IN
(SELECT ProductID FROM Cart) AND UnitPrice>5000

