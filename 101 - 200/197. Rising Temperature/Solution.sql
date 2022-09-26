select id from Weather w1
where exists (select * from Weather w2 where w2.recordDate < w1.recordDate 
              and datediff(day, w2.recordDate, w1.recordDate) < 2
              and w2.temperature < w1.temperature)