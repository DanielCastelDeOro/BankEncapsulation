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
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Would you like to make another transaction? Yes or No");
            var anwser = Console.ReadLine();
           
            if (anwser.ToUpper() == "Yes".ToUpper()) 
            {
                Console.WriteLine("Okay, what do you want to do? please type 'Transaction' or 'Exit'");
                var responseToWhatToDo = Console.ReadLine();
                if (responseToWhatToDo.ToUpper() == "Transaction".ToUpper())
                {
                    Console.WriteLine($"How much money do you want to deposit?");
                    double amountToDepost1 = double.Parse(Console.ReadLine());

                    bA.Deposit(amountToDepost1);
                    double userBalance1 = bA.GetBalance();

                    Console.WriteLine($"Your balance is {userBalance1 + userBalance,0:c}");

                }
                else
                {
                    Console.WriteLine("Thank you have a great day!");
                }

               
                
            }
            else if (anwser.ToUpper() == "No".ToUpper())
            {
                Console.WriteLine("Thank you have a great day!");
            }
            else
            {
               // return;
            }
        }
    }
}
