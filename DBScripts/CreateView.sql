

CREATE VIEW EmployeeListForView
AS
Select e.*,d1.DepartmentName ,d2.DesignationName,CONVERT(int,ROUND(DATEDIFF(hour,e.DOB,GETDATE())/8766.0,0)) as Age From Employees e
Inner Join Departments d1 on d1.DepartmentId = e.DepartmentId
Inner Join Designations d2 on d2.DesignationId = e.DesignationId