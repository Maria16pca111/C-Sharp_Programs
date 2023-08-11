#region Encapuslation Exercise 1
public class BankAccount
{
    private decimal balance;
    public BankAccount(decimal initialBalance)
    {
        this.balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public decimal GetBalance() { return balance; }
}
#endregion