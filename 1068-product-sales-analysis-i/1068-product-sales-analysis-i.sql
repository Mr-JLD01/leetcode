# Write your MySQL query statement below
Select product_name, year, price
From Sales as S
Inner Join Product as P
On S.product_id = P.product_id;