namespace simpleGit;

public class Account
{
  public int Balance { get; set; }
  
  public string AccountNumber { get; set; } = "";

public void Deposit(int amount)
  {
    Balance += amount;
  }

  public void Withdraw(int amount)
  {
    if (amount > Balance)
    {
      throw new InvalidOperationException("Insufficient Money");
    }
    Balance -= amount;
  }
}
