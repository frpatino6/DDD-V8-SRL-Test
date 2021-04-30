
-- =============================================
-- Author:		Fernando Rodríguez
-- Create date: 2021-04-29
-- Description:	<>
-- =============================================
CREATE PROCEDURE Sp_Get_Last_Employee_Salary
	@EmployeeCode nvarchar(10)
AS
BEGIN
	IF OBJECT_ID (N'#Salaries', N'U') IS NOT NULL 
	drop table #Salaries

	select top(3)*
	into #Salaries
	from employee
	where employeecode=@employeecode
	order by month desc


	select a.employeecode,a.basesalary, a.basesalary/3 as bono
	from #Salaries as a
	where a.employeecode=@employeecode
END
GO
