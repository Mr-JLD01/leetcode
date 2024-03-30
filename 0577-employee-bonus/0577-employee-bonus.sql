# Write your MySQL query statement below
Select name, bonus
From Employee as E
Left Join Bonus as B
On E.empId = B.empId
Where bonus is NULL
Or bonus < 1000;