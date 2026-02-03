CREATE PROCEDURE UpdateMonthlyBonus
AS
Begin
	insert into Bonus (BonusID, AccountID, BonusMonth, BonusYear, BonusAmount, CreatedDate) 
	SELECT Row_Number() over (ORDER BY AccountID)  + ISNULL((SELECT MAX(BonusID) FROM Bonus),0),AccountID,  month(TransactionDate),year(TransactionDate),1000, getdate()
	from TRANSACTIONS where TransactionType = 'Deposit'
	group by AccountID, month(TransactionDate), year(TransactionDate)
	having sum(Amount) > 50000;
End;