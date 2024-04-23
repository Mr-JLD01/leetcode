# Write your MySQL query statement below
Select customer_id, Count(*) as count_no_trans
From Visits as v
Left Join Transactions as t
On v.visit_id = t.visit_id
Where ISNULL(t.transaction_id)
Group by customer_id;