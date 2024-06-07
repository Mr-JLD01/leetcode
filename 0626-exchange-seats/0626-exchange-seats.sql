# Write your MySQL query statement below
Select Case
    When id = (SELECT MAX(id) FROM seat) and id % 2 = 1 then id
    When id % 2 = 1 then id + 1
    Else id - 1
End as id,
student
From Seat
Order by id