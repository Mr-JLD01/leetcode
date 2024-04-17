# Write your MySQL query statement below
Select employee_id, department_id
From Employee
Where primary_flag = 'Y'
Or employee_id in (
    Select employee_id as id
    From Employee
    Group by id
    Having COUNT(id) < 2
);