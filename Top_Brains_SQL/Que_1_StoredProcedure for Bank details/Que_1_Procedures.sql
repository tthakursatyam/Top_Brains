CREATE PROCEDURE GetStatement
	@StartDate Date,
	@EndDate Date,
	@AccountID int
AS
BEGIN
select TransactionType,sum(Amount) As Amount from Transactions where AccountID=@AccountID AND TransactionDate Between @StartDate AND @EndDate  group by TransactionType
END;

DROP PROCEDURE GetStatement;