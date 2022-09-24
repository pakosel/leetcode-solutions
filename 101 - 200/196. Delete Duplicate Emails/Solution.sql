delete from Person
where exists (select * from Person p2 where Person.email = p2.email and Person.id > p2.id)