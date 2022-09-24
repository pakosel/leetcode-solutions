select sell_date,
        count(product) as num_sold,
        STRING_AGG(product, ',') within group (order by product) as products
from (select distinct * from Activities) Act
group by sell_date
order by 1