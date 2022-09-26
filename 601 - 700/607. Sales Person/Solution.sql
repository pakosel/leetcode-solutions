select name 
from SalesPerson
where sales_id NOT IN
    (select sp.sales_id
    from SalesPerson sp join Orders o on sp.sales_id = o.sales_id
    join Company c on o.com_id = c.com_id
    where c.name = 'RED') 