# Write your MySQL query statement below
Select p.project_id,
ROUND(AVG(e.experience_years),2) as average_years
From Project as p
Left Join Employee as e
On p.employee_id = e.employee_id
Group by p.project_id;