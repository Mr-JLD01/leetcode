# Write your MySQL query statement below
Select name as results
From (Select name, Count(*) as reviews
    From Users as u
    Join MovieRating as r
    On u.user_id = r.user_id
    Group by r.user_id
    Order by reviews DESC, name ASC
    Limit 1) as TopReviewer
Union all
Select title as results
From (Select title, AVG(rating) as avg_rating
    From Movies as m
    Join MovieRating as r
    On m.movie_id = r.movie_id
    Where r.created_at like "2020-02-%"
    Group by r.movie_id
    Order by avg_rating DESC, title ASC
    Limit 1) as MovieRatings