using ObjectOrientedProgramming;

CompanyBankAccount bankAccount = new CompanyBankAccount();
bankAccount.MakeDeposit(1600);
bankAccount.MakeWithdrawal(1200);
Console.WriteLine(bankAccount.GetBalance());

bankAccount.TakeLoan(121);
