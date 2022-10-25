select
    Department,
    Employee,
    salary
from
    (
        select
            Department.name as Department,
            Employee.name as Employee,
            salary,
            DENSE_RANK() over (
                partition by departmentId
                order by
                    salary desc
            ) as Rank
        from
            Employee
            join Department on Employee.departmentId = Department.id
    ) as subq
where
    Rank = 1