namespace ObjectOrientedProgramming;

public class BankAccount
{
  private float balance;
  public string? Name { get; set; }

  public void MakeDeposit(float amount)
  {
    if (amount < 0)
      throw new Exception("Amount must be positive");
    balance += amount;
  }

  public void MakeWithdrawal(float amount)
  {
    if (amount < 0)
      throw new Exception("Amount must be positive");

    balance -= amount;
  }
  public float GetBalance()
  {
    return balance;
  }
}
