# Write your MySQL query statement below
SELECT a.machine_id, ROUND(AVG(a.timestamp - b.timestamp),3) AS processing_time
FROM Activity a
JOIN Activity b USING (machine_id,process_id)
WHERE a.timestamp > b.timestamp
GROUP BY machine_id;