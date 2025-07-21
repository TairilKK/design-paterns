using ObjectOrientedProgramming;

var bankAccount = GetBankAccount();
bankAccount.MakeWithdrawal(1700);
Console.WriteLine(bankAccount.GetBalance());

static BankAccount GetBankAccount()
{
  var bankAccount = new CompanyBankAccount();
  bankAccount.MakeDeposit(1600);

  return bankAccount;
}
