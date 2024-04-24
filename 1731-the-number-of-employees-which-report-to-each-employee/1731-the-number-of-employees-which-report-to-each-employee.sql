# Write your MySQL query statement below
Select E1.employee_id, E1.name, COUNT(*) as reports_count, 
ROUND(AVG(E2.age)) as average_age
From Employees as E1
Left Join Employees as E2
On E1.employee_id = E2.reports_to
Group by E1.employee_id
Having not ISNULL(average_age)
Order by employee_id;