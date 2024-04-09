# Write your MySQL query statement below
Select product_id, year as first_year, quantity, price
From Sales
WHERE (product_id, year) IN (
    SELECT 
      product_id, 
      MIN(year) AS year 
    FROM 
      Sales 
    GROUP BY 
      product_id
  );