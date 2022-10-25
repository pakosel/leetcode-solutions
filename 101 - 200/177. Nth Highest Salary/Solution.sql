CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS BEGIN RETURN (
    select
        top(1) salary
    from
        (
            select
                salary,
                DENSE_RANK() over (
                    order by
                        salary desc
                ) as Rank
            from
                Employee
        ) subq
    where
        Rank = @N
);

END