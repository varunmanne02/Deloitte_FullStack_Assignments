--- Create database 
Create Database  Sept2024Db

-- creating emp table
CREATE TABLE PROD
(
	PRODID INT PRIMARY KEY, 
	PNAME VARCHAR(10),
	PRICE FLOAT,	
	QUANTITY INT,	
	CATEGORY VARCHAR(20)
)


-- inserting records to emp table

INSERT INTO PROD VALUES(12684,'PHONE',20000,2,'ELECTRONICS');
INSERT INTO PROD VALUES(29384,'CAMERA',15000,1,'ELECTRONICS');
INSERT INTO PROD VALUES(69909,'SOFA',50000,1,'FURNITURE');
INSERT INTO PROD VALUES(12524,'CHAIRS',10000,6,'FURNITURE');
INSERT INTO PROD VALUES(74270,'WATCH',12000,3,'ACCESORIES');
INSERT INTO PROD VALUES(54980,'BRACELET',5000,2,'ACCESORIES');



-- select commands
SELECT * FROM PROD

-- drop table
DROP TABLE PROD