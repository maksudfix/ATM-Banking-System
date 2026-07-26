using System;
class Banking
{
    public int AccountNumber { get; set; }
    public double balance { get; set; }
    public Banking(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        this.balance = balance;
    }
    public void Deposit(double amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("Miniman Deposit Amount 500 BDT");
        }
        else
        {
            balance += amount;
            Console.WriteLine($"Amount {amount} BDT Deposited Sucessfully");
            Console.WriteLine($"Updated Balance: {balance} BDT");
        }
    }
    public void Withdraw(double amount)
    {
        if (amount < 500)
        {
            Console.WriteLine("Miniman Withdraw Amount 500 BDT");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient Balance");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($" Amount {amount} BDT Withdrawn Sucessfully");
            Console.WriteLine($"Updated Balance: {balance} BDT");
        }
    }
}
class ATM
{
    static void Main()
    {
        Banking account = new Banking(22103265, 45035);
        while (true)
        {
            Console.Write("Select Option:\n");
            Console.WriteLine("1.Current Balance");
            Console.WriteLine("2.Deposit");
            Console.WriteLine("3.Withdraw");
            Console.WriteLine("4.Exit");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Enter only number");
                continue;
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Current Balance: {account.balance} BDT");
                    break;
                case 2:
                    Console.Write("Enter Deposite Amount: ");
                    double DepositAmount;
                    if (double.TryParse(Console.ReadLine(), out DepositAmount))
                    {
                        account.Deposit(DepositAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Amount");
                    }
                    break;
                case 3:
                    Console.Write("Enter Wthdraw Amount: ");
                    double WithdrawAmount;
                    if (double.TryParse(Console.ReadLine(), out WithdrawAmount))
                    {
                        account.Withdraw(WithdrawAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Amount");
                    }
                    break;
                case 4:
                    Console.WriteLine("Thanks for using our ATM. Have a nice day!");
                    return;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }

    }
}
