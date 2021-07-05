using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bA = new BankAccount();

            Console.WriteLine($"How much money do you want to deposit?");
            double amountToDepost = double.Parse(Console.ReadLine());

            bA.Deposit(amountToDepost);
            double userBalance = bA.GetBalance();

            Console.WriteLine($"Your balance is {userBalance, 0:c}");
        }
    }
}
