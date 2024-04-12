# Write your MySQL query statement below
Select activity_date as day, COUNT(DISTINCT user_id) as active_users
From Activity
Where activity_date <= "20190727"
And activity_date > "20190627"
Group By activity_date;