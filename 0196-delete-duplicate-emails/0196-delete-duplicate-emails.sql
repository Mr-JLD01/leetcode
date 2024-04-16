# Write your MySQL query statement below
Delete p1
From Person as p1
Inner Join Person as p2
On p1.email = p2.email
Where p1.id > p2.id;