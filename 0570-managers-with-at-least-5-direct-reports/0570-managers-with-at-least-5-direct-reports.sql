# Write your MySQL query statement below
Select mgr.name
From Employee as mgr
Left join Employee as emp
On mgr.id = emp.managerId
Group by mgr.id
Having COUNT(*) >= 5;