public class BankAccount
{
    public int AccountNumber;
    public int Balance;

    public BankAccount(int accountNumber, int balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }
    public override bool Equals(object obj)
    {
        if (obj is BankAccount other)
        {
            return this.AccountNumber == other.AccountNumber;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return AccountNumber.GetHashCode() ^ Balance.GetHashCode();

    }
    public override string ToString()
    {
        return $"Account: {AccountNumber},Balance: {Balance}";
    }

    public static BankAccount operator +(BankAccount a, int money)
    {

        BankAccount res = new BankAccount(a.AccountNumber, a.Balance);
        res.Balance = a.Balance + money;
        return res;
    }

    public static BankAccount operator -(BankAccount a, int money)
    {
        BankAccount res = new BankAccount(a.AccountNumber, a.Balance);
        if (a.Balance - money < 0)
        {
            Console.WriteLine("error");
        }
        
        else{res.Balance = a.Balance - money;}
        return res;
    }

    public static bool operator <(BankAccount a, BankAccount b)
    {
        return a.Balance < b.Balance;
    }

    public static bool operator >(BankAccount a, BankAccount b)
    {
        return a.Balance > b.Balance;
    }
    public void DisplayBalance()
    {
        Console.WriteLine($"Current Balance: {Balance}");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account1 = new BankAccount(123, 4000);
        BankAccount account2 = new BankAccount(123, 4000);
        BankAccount account3 = new BankAccount(12, 400);
        Console.WriteLine(account1.Equals(account2));
        Console.WriteLine(account3.ToString());
        Console.WriteLine(account1.GetHashCode());
        Console.WriteLine(account2.GetHashCode());
        Console.WriteLine(account3.GetHashCode());
        account3 = account3 + 100;
        account3.DisplayBalance();
        account2 = account3 - 5000;
        account2.DisplayBalance();
        Console.WriteLine(account2 < account3);
    }
    
}
