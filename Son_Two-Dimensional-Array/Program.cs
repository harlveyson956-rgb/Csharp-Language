using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Son_Two_Dimensional_Array
{
    public static class Program 
    {
        private static int j;

        static void Main(string[] args)
        {
            //Complete Name: Harlvey N.Son

            //Choosen Dimensions: C. 3x3
            //Data type: int (integer)

            // Initialize the 3x3 array with sample values
            int[,] array = new int[3,3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
                
            };
            // Print the table Name
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Table Representation of 3x3 Array");
            Console.WriteLine("| Col 0 | Col 1 | Col 2 |");
            Console.WriteLine("---|-------|-------|-------|");

            // Print each row with row header
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Row {i} |");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {array[i, j],5} |");
                }
                Console.WriteLine();
            }

            // Wait for user input to close the console
            Console.ReadLine();
        }
    }
}

-- Create Database
IF DB_ID('SALESDB') IS NULL
    CREATE DATABASE SALESDB;


USE SALESDB;


-- ==========================
-- TABLES
-- ==========================

CREATE TABLE REGIONS
(
    REGION_ID INT PRIMARY KEY,
    REGION_NAME VARCHAR(25)
);

CREATE TABLE COUNTRIES
(
    COUNTRY_ID CHAR(2) PRIMARY KEY,
    COUNTRY_NAME VARCHAR(40),
    REGION_ID INT
);

CREATE TABLE LOCATIONS
(
    LOCATION_ID INT PRIMARY KEY,
    STREET_ADDRESS VARCHAR(40),
    POSTAL_CODE VARCHAR(12),
    CITY VARCHAR(30),
    STATE_PROVINCE VARCHAR(25),
    COUNTRY_ID CHAR(2)
);

CREATE TABLE JOBS
(
    JOB_ID VARCHAR(10) PRIMARY KEY,
    JOB_TITLE VARCHAR(35),
    MIN_SALARY DECIMAL(6,0),
    MAX_SALARY DECIMAL(6,0)
);

CREATE TABLE DEPARTMENTS
(
    DEPARTMENT_ID INT PRIMARY KEY,
    DEPARTMENT_NAME VARCHAR(30),
    MANAGER_ID INT NULL,
    LOCATION_ID INT
);

CREATE TABLE EMPLOYEES
(
    EMPLOYEE_ID INT PRIMARY KEY,
    FIRST_NAME VARCHAR(20),
    LAST_NAME VARCHAR(25),
    EMAIL VARCHAR(25),
    PHONE_NUMBER VARCHAR(20),
    HIRE_DATE DATETIME,
    JOB_ID VARCHAR(10),
    SALARY DECIMAL(8,2),
    COMMISSION_PCT DECIMAL(4,2),
    MANAGER_ID INT NULL,
    DEPARTMENT_ID INT
);

CREATE TABLE JOB_HISTORY
(
    EMPLOYEE_ID INT,
    START_DATE DATETIME,
    END_DATE DATETIME,
    JOB_ID VARCHAR(10),
    DEPARTMENT_ID INT,
    CONSTRAINT PK_JOB_HISTORY PRIMARY KEY (EMPLOYEE_ID, START_DATE)
);

-- ==========================
-- FOREIGN KEYS
-- ==========================

ALTER TABLE COUNTRIES
ADD CONSTRAINT FK_COUNTRIES_REGIONS
FOREIGN KEY (REGION_ID)
REFERENCES REGIONS(REGION_ID);

ALTER TABLE LOCATIONS
ADD CONSTRAINT FK_LOCATIONS_COUNTRIES
FOREIGN KEY (COUNTRY_ID)
REFERENCES COUNTRIES(COUNTRY_ID);

ALTER TABLE DEPARTMENTS
ADD CONSTRAINT FK_DEPARTMENTS_LOCATIONS
FOREIGN KEY (LOCATION_ID)
REFERENCES LOCATIONS(LOCATION_ID);

ALTER TABLE EMPLOYEES
ADD CONSTRAINT FK_EMPLOYEES_JOBS
FOREIGN KEY (JOB_ID)
REFERENCES JOBS(JOB_ID);

ALTER TABLE EMPLOYEES
ADD CONSTRAINT FK_EMPLOYEES_DEPARTMENTS
FOREIGN KEY (DEPARTMENT_ID)
REFERENCES DEPARTMENTS(DEPARTMENT_ID);

ALTER TABLE EMPLOYEES
ADD CONSTRAINT FK_EMPLOYEES_MANAGER
FOREIGN KEY (MANAGER_ID)
REFERENCES EMPLOYEES(EMPLOYEE_ID);

ALTER TABLE DEPARTMENTS
ADD CONSTRAINT FK_DEPARTMENTS_MANAGER
FOREIGN KEY (MANAGER_ID)
REFERENCES EMPLOYEES(EMPLOYEE_ID);

ALTER TABLE JOB_HISTORY
ADD CONSTRAINT FK_JOB_HISTORY_EMPLOYEES
FOREIGN KEY (EMPLOYEE_ID)
REFERENCES EMPLOYEES(EMPLOYEE_ID);

ALTER TABLE JOB_HISTORY
ADD CONSTRAINT FK_JOB_HISTORY_JOBS
FOREIGN KEY (JOB_ID)
REFERENCES JOBS(JOB_ID);

ALTER TABLE JOB_HISTORY
ADD CONSTRAINT FK_JOB_HISTORY_DEPARTMENTS
FOREIGN KEY (DEPARTMENT_ID)
REFERENCES DEPARTMENTS(DEPARTMENT_ID);











