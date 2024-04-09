# Write your MySQL query statement below
Select D.name as Department, E.name as Employee, E.salary as Salary
From Department as D
Left Join Employee as E
On D.id = E.departmentId
Where (Salary) in (
    Select E3.salary
    From(Select Distinct E2.salary
        From Employee as E2
        Where E.departmentId = E2.departmentId
        Order by E2.salary DESC
        Limit 3) as E3
);