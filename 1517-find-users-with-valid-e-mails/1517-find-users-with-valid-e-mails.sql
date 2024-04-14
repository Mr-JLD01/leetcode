# Write your MySQL query statement below
Select *
From Users
Where mail REGEXP '^[a-zA-Z][a-zA-Z0-9_.-]*@leetcode[.]com$';