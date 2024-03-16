CREATE DATABASE Company;
USE Company;

CREATE TABLE Clients(
Client_ID INT PRIMARY KEY,
Cname VARCHAR(40) NOT NULL,
Addresss VARCHAR(30),
Email VARCHAR(30)  UNIQUE,
Phone NUMERIC(10) ,
Business VARCHAR(20) NOT NULL
);
SELECT*FROM Clients
--INSERT DATA INTO TBLES

INSERT INTO Clients (Client_ID, Cname, Addresss, Email, Phone, Business) VALUES
(1001,'Aceme Uitilies','Noida','contact@acmeutil.com',9567880032,'Manufacturing'),
(1002,'Trackon Consulters','Mumbai','consult@trackon.com',8743875904,'Consultant'),
(1003,'MoneySaver Distribution','Kolkata','save@moneysaver.com',7799886655,'Reseller'),
(1004,'Lawful Corp','Chennai','justic@lawful.com',9210342219,'Reseller'); 


-- CREATE DEPARTMENTS====
CREATE TABLE Departments(          
Deptno INT PRIMARY KEY,
Dname VARCHAR(15)NOT NULL,
Loc  VARCHAR(20)
);

select * from Departments

INSERT INTO Departments (Deptno,Dname,Loc)VALUES
(10,'Design','Pune'),
(20,'Development','Pune'),
(30,'Testing','Mumbai'),
(40,'Document','Mumbai');

-- Creating employee====
CREATE TABLE Employees(
Empno NUMERIC(4) PRIMARY KEY,
Ename VARCHAR(20),
Job VARCHAR(15),
Salary NUMERIC(10) CHECK (Salary > 0),
Deptno int foreign key references Departments(Deptno)
);


INSERT INTO Employees (Empno,Ename,Job,Salary,Deptno) VALUES
(7001,'Sandeep','Analyst',25000,10),
(7002,'Rajesh','Designer',30000,10),
(7003,'Madhav','Developer',40000,20),
(7004,'Manoj','Developer',40000,20),
(7005,'Abhay','Designer',35000,10),
(7006,'Uma','Tester',30000,30),
(7007,'Gita','Tech. Writer',30000,40),
(7008,'Priya','Tester',35000,30);

select * from Employees


--CREATE PROJECT

CREATE TABLE Project(
Project_ID INT PRIMARY KEY,
Descr VARCHAR(30) NOT NULL,
Start_Dates DATE ,
Planned_End_Date DATE,
Actual_End_date DATE,
Budget NUMERIC(10) CHECK (Budget > 0),
Client_ID INT FOREIGN KEY REFERENCES Clients(Client_ID) 
);

SELECT * FROM Project

INSERT INTO Project(Project_ID,Descr,Start_Dates,Planned_End_Date,Actual_End_date,Budget,Client_ID)VALUES
(401,'Inventory','01-Apr-11','01-Oct-11','31-Oct-11', 150000, 1001),
(402,'Accounting','01-Aug-11','01-Jan-11',NULL, 500000, 1002),
(403,'Payroll','01-Oct-11','01-Dec-11',NULL, 750000, 1003),
(404,'Contact Mgmt','01-Nov-11','01-Dec-11',NULL, 500000, 1004);


CREATE TABLE EmpProjectTasks(
Project_ID INT ,
Empno NUMERIC(4),
Start_Dates DATE,
End_Date  DATE,
Task VARCHAR(25)NOT NULL,
Statuss VARCHAR(25) NOT NULL,
PRIMARY KEY(Project_ID,Empno),
FOREIGN KEY (Project_ID) REFERENCES  Project(Project_ID),
FOREIGN KEY (Empno) REFERENCES  Employees(Empno)
);

SELECT * FROM EmpProjectTasks


INSERT INTO EmpProjectTasks(Project_ID,Empno,Start_Dates,End_Date,Task,Statuss) VALUES
(401,7001,'01-Apr-11','20-Apr-11','System Analysis','Completed'),
(401,7002,'21-Apr-11','30-May-11','System Design','Completed'),
(401,7003,'01-Jun-11','15-Jul-11','Coding','Completed'),
(401,7004,'18-Jul-11','01-Sep-11','Coding','Completed'),
(401,7006,'03-Sep-11','15-Sep-11','Testing','Completed'),
(401,7008,'18-Sep-11','05-Oct-11','Code Change','Completed'),
(401,7009,'06-Oct-11','16-Oct-11','Testing','Completed'),
(401,7007,'06-Oct-11','22-Oct-11','Documentation','Completed'),
(401,7011,'22-Oct-11','30-Oct-11','Sign off','Completed'),
(402,7010,'01-Aug-11','20-Aug-11','System Analysis','Completed'),
(402,7002,'22-Aug-11','30-Sep-11','System Design','Completed'),
(402,7004,'01-Oct-11',NULL,'Coding','In Progress');
