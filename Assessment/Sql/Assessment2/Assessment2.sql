CREATE DATABASE PERSON
USE PERSON

CREATE TABLE MYBIRTHDAY
(
 MYName VARCHAR(50),
 BIRTHDAYDATE DATE
);

INSERT INTO MYBIRTHDAY VALUES ('SANJANA','2002-04-30')

SELECT * FROM MYBIRTHDAY

--1 1.	Write a query to display your birthday( day of week)

SELECT DATENAME(DW,BIRTHDAYDATE) AS DAYOF_BDAY  FROM MYBIRTHDAY 

--2. Write a query to display your age in days

SELECT DATEDIFF(day, BIRTHDAYDATE, GETDATE()) AS MYAGE_IN_DAYS
FROM MYBIRTHDAY;

--4

CREATE TABLE EMPLOYEE
(
EMPNO INT PRIMARY KEY,
ENAME VARCHAR(25),
SAL FLOAT,
DOJ DATE
);

SELECT * FROM EMPLOYEE 

--A.First insert 3 rows

BEGIN TRAN 
INSERT INTO EMPLOYEE (EMPNO,ENAME,SAL,DOJ) 
VALUES  (1, 'SIMRAN', 50000, '2020-01-01'),(2, 'HIMANI', 60000, '2019-05-15'),
(3, 'SAURABH', 70000, '2018-08-20');
COMMIT TRAN

SELECT * FROM EMPLOYEE

--B.Update the second row sal with 15% increment  

BEGIN TRANSACTION 
UPDATE EMPLOYEE SET SAL = SAL*0.15 WHERE EMPNO = 2
COMMIT TRANSACTION

SELECT * FROM EMPLOYEE

--C  Delete first row. After completing above all actions how to recall the deleted row without losing increment of second row.
BEGIN TRAN
DELETE FROM EMPLOYEE WHERE EMPNO = 1;
COMMIT TRAN;

SELECT * FROM EMPLOYEE

--5  Create a user defined function calculate Bonus for all employees of a  given job using following conditions

USE SqlExercise

SELECT * FROM EMP

CREATE OR ALTER FUNCTION BONUS_CAL (@DEPTNO INT ,@SAL FLOAT)
RETURNS FLOAT
AS
BEGIN 
DECLARE @BONUS FLOAT

--a.     For Deptno 10 employees 15% of sal as bonus.
IF 
  @DEPTNO = 10 
  SET @BONUS= @SAL* 0.15

 --b For Deptno 20 employees  20% of sal as bonus
ELSE IF
    @DEPTNO = 20  SET @BONUS =  @SAL * 0.20

--cFor Others employees 5%of sal as bonus
ELSE  
    SET @BONUS= @SAL * 0.05

	RETURN @BONUS
END;
--output

SELECT ENAME,SAL,dbo.BONUS_CAL(Deptno,Sal)AS BONUS FROM EMP WHERE Deptno = 20


--3 Write a query to display all employees information those who joined before 5 years in the current month.
SELECT * FROM EMP

UPDATE EMP SET Hiredate = '2019-11-17' where Empno in (7469);
UPDATE EMP SET Hiredate = '2019-11-17' where Empno in (7499);

-- Query to display employees who joined in the last 5 years

SELECT * FROM EMP WHERE HireDate >= DATEADD(YEAR, -5, GETDATE()); 
