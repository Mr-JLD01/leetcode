# Write your MySQL query statement below
Select unique_id, name
From Employees as E
Left Join EmployeeUNI as U
On E.id = U.id;