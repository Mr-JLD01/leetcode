# Write your MySQL query statement below
Select Round(Sum(tiv_2016), 2) as tiv_2016
From (
    Select *
    From Insurance
    Where (lat, lon) in (
        Select lat,lon
        From Insurance
        Group by lat, lon
        Having Count(*) < 2
    )
    Intersect
    Select *
    From Insurance
    Where tiv_2015 in (
        Select tiv_2015
        From Insurance
        Group by tiv_2015
        Having Count(*) > 1
    )
) as FilteredInsurance
