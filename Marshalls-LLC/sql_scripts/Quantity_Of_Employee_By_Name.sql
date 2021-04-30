CREATE FUNCTION [dbo].[Quantity_Of_Employee_By_Name]
(
	-- Add the parameters for the function here
	@FirstName varchar(150),
	@SureName varchar(150),

)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @result int

	-- Add the T-SQL statements to compute the return value here
	SELECT @result = count(*)
	from  [dbo].[Employee]
	where [dbo].[Employee].[EmployeeName] = @FirstName and [dbo].[Employee].[EmployeeSurname] = @SureName

	-- Return the result of the function
	RETURN @result

END
GO