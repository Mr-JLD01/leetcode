# Write your MySQL query statement below
Select S.user_id,
IF(ISNULL(C.time_stamp),
    0,
       ROUND(
           (
               Select COUNT(C1.action)
               From Confirmations as C1
               Where C1.user_id = S.user_id
               And C1.action like "%confirmed%"
           )
           /COUNT(C.time_stamp)
           ,2)
      ) as confirmation_rate
From Signups as S
Left Join Confirmations as C
On S.user_id = C.user_id
Group by S.user_id