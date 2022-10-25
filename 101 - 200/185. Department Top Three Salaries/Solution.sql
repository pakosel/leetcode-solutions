select
    Department,
    Employee,
    Salary
from
    (
        select
            Department.name as Department,
            Employee.name as Employee,
            Salary,
            DENSE_RANK() over (
                partition by Employee.departmentId
                order by
                    salary desc
            ) as Rank
        from
            Employee
            join Department on departmentId = Department.id
    ) subq
where
    subq.Rank < 4