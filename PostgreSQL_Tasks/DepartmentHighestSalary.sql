SELECT d.name AS Department, e.name AS Employee, e.salary AS Salary
FROM department d
JOIN (
    SELECT departmentId, MAX(salary) AS max_salary
    FROM employee
    GROUP BY departmentId
) max_salaries ON d.id = max_salaries.departmentId
JOIN employee e ON d.id = e.departmentId AND e.salary = max_salaries.max_salary;
