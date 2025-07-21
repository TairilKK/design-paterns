namespace ObjectOrientedProgramming;

public class CompanyBankAccount : BankAccount
{
  public void TakeLoan(float amount)
  {
    Console.WriteLine("Company take loan");
  }
  public override void MakeWithdrawal(float amount)
  {
    Console.WriteLine("Company bank account withdrawl");
    base.MakeWithdrawal(amount);
  }

}
