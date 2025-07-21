using ObjectOrientedProgramming;

BankAccount bankAccount = new BankAccount();
bankAccount.MakeDeposit(1600);
bankAccount.MakeWithdrawal(1200);
Console.WriteLine(bankAccount.GetBalance());
