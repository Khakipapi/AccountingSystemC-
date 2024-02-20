// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security.Principal;

void Welcome()
{
    Console.WriteLine("Welcome to Dragonvain accounting system 1.0");
   
}

Welcome();
            Console.WriteLine("Create a checking account:");
            Console.WriteLine("Please enter your account number");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your account balance");
            decimal accountBalance = Convert.ToDecimal(Console.ReadLine());
            CheckingAccount account = new CheckingAccount(accountNumber, accountBalance);
               
            Console.WriteLine("Create a premium account");
            Console.WriteLine("Please enter your account number:");
            int accountNumberP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your account balance");
            decimal accountBalanceP = Convert.ToDecimal(Console.ReadLine());
            PremiumAccount accountP = new PremiumAccount(accountNumberP, accountBalanceP);
                  
                  
            account.Print();
            accountP.Print();
            account.Deposit(2000);
            accountP.Deposit(6000);
            account.Print();
            accountP.Print();
            accountP.Transfer(2000, account);
            account.Print();
            accountP.Print();
            account.Interest();
            accountP.Interest();
            account.Print();
            accountP.Print();




                   
                  
              

     
      


public interface IAccountingSystem
{
    public int Id { get; set; }
    public decimal Balance { get; set; }

}

public class CheckingAccount : IAccountingSystem
{
    public int Id { get; set; }
    public decimal Balance { get; set; }
    

    public CheckingAccount(int id, decimal balance)
    {
        Id = id;
        Balance = balance;
    }
    public decimal Deposit(decimal amount)
    {
        return Balance += amount;
    }
    public decimal Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            throw new Exception("Insufficient funds");
        }
        return Balance -= amount;
    }
    public virtual decimal Interest()
    {
       
      return  Balance += Balance * 0.03m;
    }

    
    public void Print()
    {
        Console.WriteLine("Account: " + Id + " Balance: " + Balance);
    }
    public void Transfer(decimal amount, CheckingAccount account)
    {
        if (Balance < amount)
        {
            throw new Exception("Insufficient funds");
        }
        account.Deposit(amount);
        Balance -= amount;
    }
    

   
}
public class PremiumAccount : CheckingAccount
{
    public PremiumAccount(int id, decimal balance) : base(id, balance)
    {
        
    }
    override public decimal Interest()
    {
        return Balance += Balance * 0.04m;
    }

}
