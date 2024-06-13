# Write your MySQL query statement below
Select id, Count(*) as num
From (
    Select requester_id as id, accepter_id as id2
    From RequestAccepted
    Union All
    Select accepter_id as id, requester_id as id2
    From RequestAccepted
) as Friends
Group by id
Order by num Desc
Limit 1