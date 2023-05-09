using System;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;
using System.Xml.Linq;

class Bank
{
    string Name;
    int Amount;
    BankManager obj2 = new BankManager();
    public string PName
    {
        get
        {
            
            return Name;

        }
        set
        {
            Name = value;
       
        }
    }

    public int pAmount
    {
        get
        {
            return Amount;
        }
        set
        {
            Amount = value;
        }
    }
}

class BankManager
{
    public void amnt()
    {
        var obj1 = new Bank();
        Console.WriteLine("enter your account balance");
        int a = int.Parse(Console.ReadLine());
        obj1.pAmount = a;
        if (obj1.pAmount > 10000)
        {
            Console.WriteLine(" wow you are valuable customer , you are eligible for shopping go inside");
        }
        else
        {
            Console.WriteLine("oops, low balance, add more balance in account to go inside for shopping");
        }
    }
    public void nme()
    {
        var obj1 = new Bank();
        Console.WriteLine("enter your  name here");
        string b = Console.ReadLine();
        obj1.PName = b;
        Console.WriteLine($"your  name is {obj1.PName} ");

    }
    class Customer
    {
        public static void Main(string[] args)
        {
            var obj = new BankManager();
            obj.nme();
            obj.amnt();
        }
    }
}
