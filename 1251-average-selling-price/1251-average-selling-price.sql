# Write your MySQL query statement below
Select P.product_id, 
IFNULL(
    ROUND(
        Sum(P.price * U.units) / Sum(U.units),
        2),
    0) as average_price
From Prices as P
Left Join UnitsSold as U
On P.product_id = U.product_id
And U.purchase_date >= P.start_date
And U.purchase_date <= P.end_date
Group by P.product_id;