EXEC sp_InsertEmployee 
    @FirstName = 'Anjali',
    @LastName = 'Singh',
    @DepartmentID = 1,
    @Salary = 6200.00,
    @JoinDate = '2023-06-01';

SELECT * FROM Employees;

