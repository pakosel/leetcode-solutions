select customer_id, count(*) as count_no_trans
from Visits v
where not exists (select * from Transactions t where t.visit_id = v.visit_id)
group by customer_id