# Write your MySQL query statement below
Select sell_date, COUNT(Distinct product) as num_sold,
Group_Concat(
    DISTINCT product 
    Order by product ASC 
    Separator ',') as products
From Activities
Group by sell_date
Order by sell_date ASC;