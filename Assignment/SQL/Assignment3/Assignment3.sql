USE SqlExercise

SELECT * FROM EMP

SELECT * FROM DEPT

--1  Retrieve a list of MANAGERS.=========================================

SELECT EMPNO, ENAME  FROM EMP WHERE JOB IN ('MANAGER');

--2. Find out the names and salaries of all employees earning more than 1000 per month.==============

SELECT ENAME, SAL FROM EMP WHERE SAL >1000;

--3.3. Display the names and salaries of all employees except JAMES. ================
SELECT Ename, SAL FROM EMP WHERE ENAME NOT IN  ('JAMES');


--4. Find out the details of employees whose names begin with ‘S’. ====================
SELECT * FROM EMP WHERE ENAME LIKE'S%';

--5. Find out the names of all employees that have ‘A’ anywhere in their name.===================
SELECT * FROM EMP WHERE ENAME LIKE '%A%';


---6. Find out the names of all employees that have ‘L’ as their third character in their name. ====================
SELECT * FROM EMP WHERE ENAME LIKE '__[M]%';

----7. Compute daily salary of JONES. ============================
WITH DETAILS AS 
(SELECT ENAME, SAL FROM EMP WHERE ENAME='JONES')
SELECT SAL/30 AS DAILY_SAL FROM DETAILS;

--8. Calculate the total monthly salary of all employees. ===============================

WITH EMPDETAILS AS(
SELECT * FROM EMP )
SELECT ENAME, SAL/30 AS TOTAL_MONTSAL FROM EMPDETAILS;


--9. Print the average annual salary .=============================== 

WITH EDETAILS AS(
SELECT * FROM EMP)
SELECT AVG(SAL) AS AVERAGE_SAL FROM EDETAILS;


--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30. ==========
SELECT ENAME,JOB,SAL,DEPTNO  FROM EMP WHERE JOB!='SALESMAN' AND Deptno = 30;


--11. List unique departments of the EMP table.=============== 
SELECT DISTINCT DEPTNO FROM EMP;


--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.================
SELECT ENAME AS EMPLOYEE, SAL AS SALARY FROM EMP WHERE SAL < 1500 AND Deptno IN (10,30) ;



-----13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. ===================
SELECT ENAME , SAL , JOB FROM EMP WHERE JOB NOT IN ('MANAGER','ANALYST') AND SAL NOT IN (1000,3000,5000);


--14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. ============
SELECT ENAME, SAL, COMM FROM EMP WHERE COMM >(SAL*0.1);


-----15. Display the name of all employees who have two L As in their name and are in department 30 or their manager is 7782. ==================
SELECT * FROM EMP WHERE ENAME LIKE '%L%L%' OR Deptno =30 AND MGR_ID=7782 ;


--16. Display the names of employees with experience of over 30 years and under 40 yrs.============
 -----------Count the total number of employees.
SELECT ENAME FROM EMP WHERE DATEDIFF(YEAR,HIREDATE,GETDATE()) BETWEEN 30 AND 39;
SELECT COUNT(*) AS 'TOTAL EMPOLYEES' FROM EMP WHERE DATEDIFF(YEAR,HIREDATE,GETDATE()) BETWEEN 30 AND 39;


----17. Retrieve the names of departments in ascending order and their employees in descending order. =======================

WITH DEPTEMP AS (SELECT D.DNAME AS DEPARTMENT , E.ENAME AS EMPLOYEES
FROM DEPT D JOIN EMP E ON D.Deptno=E.Deptno)
SELECT DEPARTMENT,EMPLOYEES FROM DEPTEMP ORDER BY DEPARTMENT ASC ,EMPLOYEES DESC

--18. Find out experience of MILLER====================

SELECT DATEDIFF(YEAR,HIREDATE,GETDATE()) FROM EMP WHERE ENAME='MILLER';