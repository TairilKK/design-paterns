namespace ObjectOrientedProgramming;

public class PersonalBankAccount : BankAccount
{
  public void RequestPersonalLoan()
  {
    Console.WriteLine("Making request");
  }

  public override void MakeWithdrawal(float amount)
  {
    Console.WriteLine("Personal bank account withdrawl");
    if (amount < 0)
      throw new Exception("Amount must be positive");

    if (balance - amount < 0)
      throw new Exception("Personal bank account cannot go in debt");

    balance -= amount;
  }
}
