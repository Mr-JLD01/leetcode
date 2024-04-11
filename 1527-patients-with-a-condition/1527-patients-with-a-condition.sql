# Write your MySQL query statement below
Select *
From Patients
Where UPPER(conditions) like "% DIAB1%"
Or UPPER(conditions) like "DIAB1%";