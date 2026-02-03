CREATE PROCEDURE Check_Current_Balance
@AccountID int
AS
BEGIN	
	declare @total_deposit decimal  
	select @total_deposit = isnull(sum(Amount),0) from Transactions where TransactionType='Deposit' AND AccountID=@AccountID

	declare @total_withdraw decimal  
	select @total_withdraw = isnull(sum(Amount),0) from Transactions where TransactionType='Withdraw' AND AccountID=@AccountID

	declare @total_bonus decimal
	select @total_bonus = isnull(sum(BonusAmount),0) from Bonus where AccountID=@AccountID

	declare @opening_balance decimal
	select @opening_balance = OpeningBalance from Accounts where AccountID=@AccountID

	select C.CustomerName,A.AccountNumber,(@opening_balance+@total_deposit-@total_withdraw+@total_bonus) As CurrentBalance
	from Accounts A join Customers C on C.CustomerID=A.CustomerID where A.AccountID=@AccountID
End;
drop procedure Check_Current_Balance