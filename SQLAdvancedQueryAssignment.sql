--1.  Implement the following requirements (Concept: Views) :  

--	a.  Creates a view that selects every product in the "Products" table with a price less than the average price
--			Hint : View name should be  "Products  Less Than Average Price"
  
	use pubs

	SELECT * FROM Products

	CREATE VIEW ProductsLessThanAveragePrice As
	SELECT ProductName, UnitPrice FROM Products 
	where UnitPrice < (SELECT AVG(UnitPrice) FROM Products)
			
--	b.   Display the results by using the View	

		SELECT * FROM ProductsLessThanAveragePrice

--	c.   Rename the View as   "Low Cost Products"	

	EXEC sp_rename 'ProductsLessThanAveragePrice', 'LowCostProducts';


--	d.   Drop the view

	DROP VIEW LowCostProducts
	

--2.  Implement the following requirement using Stored Procedures and cursors 
	
--	Hint :  Products table from pubs database
	
--	a.   Read required data from the Products table

DECLARE cursor_product CURSOR
FOR SELECT ProductName, UnitPrice, UnitsOnOrder FROM  Products;


OPEN cursor_product;

DECLARE @ProductName VARCHAR(MAX),  @UnitPrice   DECIMAL, @UnitsOnOrder INT, @totalSum DECIMAL(18,2), @totalPrice DECIMAL(18,2);   
FETCH NEXT FROM cursor_product INTO  @ProductName, @UnitPrice, @UnitsOnOrder;
SELECT @totalSum=0;
SELECT @totalPrice=0;

--PRINT @ProductName
--PRINT @UnitPrice

  
    WHILE @@FETCH_STATUS = 0
    BEGIN

		SELECT @totalPrice = (@UnitPrice)*(@UnitsOnOrder);
		SELECT @totalSum = @totalSum + @totalPrice;
        PRINT @ProductName + ' - ' +  CAST(@totalPrice AS varchar);
        FETCH NEXT FROM cursor_product INTO  @ProductName,  @UnitPrice, @UnitsOnOrder;
     END;

	 PRINT 'Total Sum ' + CAST(@totalSum AS varchar);

CLOSE cursor_product;
DEALLOCATE cursor_product;

--	b.   Find the total amount of each product :  Consider UnitsOnOrder, UnitPrice
--	c.    You need to display product name and total amount in the output	  
--	d.   Also display grand total at the end. 
--	e.    Display the total amounts with only two decimal points:
--			Eg:   128.50,  582.00, etc....