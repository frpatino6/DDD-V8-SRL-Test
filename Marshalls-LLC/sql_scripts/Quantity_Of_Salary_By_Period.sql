CREATE FUNCTION [dbo].[Quantity_Of_Salary_By_Period]
(
	-- Add the parameters for the function here
	@Id int,
	@Month int,
	@Year int
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @result int

	-- Add the T-SQL statements to compute the return value here
	SELECT @result = count(*)
	from  [dbo].[Employee]
	where [Id]=@Id and [Month]= @Month and [Year]= @Year

	-- Return the result of the function
	RETURN @result

END
GO