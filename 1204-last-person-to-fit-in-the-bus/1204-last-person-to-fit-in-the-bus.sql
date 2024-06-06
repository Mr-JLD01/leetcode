# Write your MySQL query statement below
Select person_name
From (
    Select *, SUM(weight) OVER (Order by turn) as total
    From Queue
    ) as turn_order
Where total <= 1000
Order by turn Desc
Limit 1