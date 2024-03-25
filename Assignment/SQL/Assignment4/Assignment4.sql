USE HELLO

--1 Write a T-SQL Program to find the factorial of a given number==================================
BEGIN
DECLARE @FACT INT =1,
		@NUM INT = 5
WHILE @NUM >1
BEGIN
  SET @FACT = @FACT * @NUM;
    SET @NUM = @NUM - 1;
END
END;
SELECT @FACT AS FACTORIAL


--2  Create a stored procedure to generate multiplication tables up to a given number================================================
      

CREATE OR ALTER PROCEDURE MULTIPILCATION_TABLE @NUM INT
AS
BEGIN
     print 'Multiplication of this table '+cast(@NUM as varchar(30))+':'
    DECLARE @MULTIPLE INT = 1;
    WHILE @MULTIPLE <= 10
    BEGIN
         PRINT CAST(@NUM AS VARCHAR(2)) + ' * ' + CAST(@MULTIPLE AS VARCHAR(2)) + ' = ' + CAST(@NUM * @MULTIPLE AS VARCHAR(4));
        SET @MULTIPLE = @MULTIPLE + 1;
    END;
END;

EXEC MULTIPILCATION_TABLE @NUM = 2




--3=====================================


-- Create the Holiday table


CREATE TABLE HOLIDAY (
    HOLIDAY_DATE DATE ,
    HOLIDAY_NAME VARCHAR(20)
);

INSERT INTO HOLIDAY(HOLIDAY_DATE, HOLIDAY_NAME) 
VALUES 
    ('2024-03-25', 'New Year'),
    ('2024-08-15', 'Independence day'),
    ('2024-10-31', 'Diwali'),
    ('2024-12-25', 'Christmas');
 SELECT * FROM HOLIDAY

 CREATE TABLE EMP (
 ID INT PRIMARY KEY,
 ENAME VARCHAR(25),
 SALARY decimal(10,2),
 );
 drop table EMP
 CREATE OR ALTER TRIGGER RESTRICT_DATAMANI
 ON EMP 
 AFTER INSERT,UPDATE,DELETE
 AS
    -- Check if the current date is a holiday and get the holiday name
 BEGIN
 DECLARE @Holiday_Name NVARCHAR(100);
 SELECT @Holiday_Name = HOLIDAY_NAME FROM HOLIDAY WHERE HOLIDAY_DATE = CAST(GETDATE() AS DATE);
       
	   IF @Holiday_Name IS NOT NULL
	   BEGIN
	   DECLARE @ERRORMESSAGE NVARCHAR(50);
        SET @ERRORMESSAGE = 'Due to ' + @Holiday_Name + ', you cannot manipulate data.';
        RAISERROR (@ERRORMESSAGE, 16, 1);
        ROLLBACK TRANSACTION
    END
	END;
INSERT INTO EMP (ID,ENAME,SALARY) VALUES (9,'RADHA',5000.00)

SELECT* FROM EMP


