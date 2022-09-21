/* 1 */
select name as Customers from customers c
where not exists (select * from orders where customerid=c.id)

/* 2 */
select name as Customers
from customers c full join orders o on c.id = o.customerId
where o.id is null

/* 3 */
select name as Customers
from customers c left join orders o on c.id = o.customerId
where o.id is null

/* 4 */
select name as Customers from customers c
where c.id not in (select customerId from orders)