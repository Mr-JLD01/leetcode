# Write your MySQL query statement below
Select *, IF(
    x+y > z
    And x+z > y
    And z+y > x,
    "Yes", "No"
) as triangle
From Triangle