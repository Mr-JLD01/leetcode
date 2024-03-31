# Write your MySQL query statement below
Select St.student_id, St.student_name, Su.subject_name, COUNT(E.subject_name) as attended_exams
From Students as St
Cross Join Subjects as Su
Left Join Examinations as E
On St.student_id = E.student_id 
And Su.subject_name = E.subject_name
Group By St.student_id, St.student_name, Su.subject_name
Order By St.student_id, Su.subject_name;


