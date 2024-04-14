# Write your MySQL query statement below
Select P.product_name, SUM(O.unit) as unit
From Orders as O
Left Join Products as P
On O.product_id = P.product_id
Where O.order_date Between "20200201" And "20200229"
Group by P.product_name
Having unit >= 100;