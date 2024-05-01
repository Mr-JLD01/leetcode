# Write your MySQL query statement below
Select MAX(salary) as SecondHighestSalary
From (
    Select E.salary
    From Employee as E
    Where E.salary < (Select MAX(E2.salary)
                     From Employee as E2)
) as HighRemoved
Limit 1;