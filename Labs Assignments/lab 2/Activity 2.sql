/****** Script for SelectTopNRows command from SSMS  ******/
/* Activity 2*/
/*task 1*/
SELECT [RegNo]
      ,[FirstName]
      ,[LastName]
      ,[GPA]
      ,[Contact]
  FROM [lab2].[dbo].[Student] WHERE  GPA >= 3.5 AND Not RegNo='2016-CS-178' 

SELECT [RegNo]
      ,[FirstName]
      ,[LastName]
      ,[GPA]
      ,[Contact]
  FROM [lab2].[dbo].[Student] WHERE  GPA >= 3.5 OR Not RegNo='2016-CS-178'
SELECT [FirstName],[GPA]
      *[GPA] + [GPA]
  FROM [lab2].[dbo].[Student] WHERE  GPA = 3.5 OR GPA < 3.1
/* Task 2 */
SELECT [FirstName],[GPA]
      *([GPA] + [GPA])
  FROM [lab2].[dbo].[Student] WHERE  GPA = 3.5 OR GPA < 3.1
SELECT [FirstName],[GPA] + 1
  FROM [lab2].[dbo].[Student]
      