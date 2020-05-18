using System;
using System.Security.Cryptography.X509Certificates;

namespace ATM
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Francesco's Empty ATM!");

            try
            {
                AtmHandler(1000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Nope. That is wrong. {ex}");
                
            }
            finally
            {
                Environment.Exit(0);
                   
            }
        }

        public static void AtmHandler(decimal currentBalance)
        {

            decimal userBalance = currentBalance;

            try
            {
                
                Console.WriteLine("1. View Funds \n 2. Withdraw Funds \n 3. Deposit Funds\n 4. Exit");
                int selectedTransaction = int.Parse(Console.ReadLine());


                if (selectedTransaction == 1)
                {
                    Console.WriteLine($"\nYour balance is: {userBalance}\n");
                    AtmHandler(userBalance); 
                }
                if (selectedTransaction == 2) 
                {
                    userBalance = WithdrawHandler(userBalance);
                    AtmHandler(userBalance); 
                }
                if (selectedTransaction == 3)  
                {
                    userBalance = DepositHandler(userBalance);
                    AtmHandler(userBalance); 
                }
                if (selectedTransaction == 4) 
                {
                    return;
                }
            }
            catch (FormatException) 
            {
                Console.WriteLine("\nNope. Enter a number.!\n");
                AtmHandler(userBalance);
            }
            catch (ArgumentOutOfRangeException Arex)
            {
                throw Arex;
            }

            

        }

        public static decimal DepositHandler(decimal currentBalance)
        {
            Console.WriteLine("How much would you like to deposit?");
            decimal depositTotal = decimal.Parse(Console.ReadLine());

            decimal newTotal = currentBalance + depositTotal;

            Console.WriteLine($"Your balance is now: {newTotal}");

            return newTotal;
        }

        public static decimal WithdrawHandler(decimal currentBalance)
        {
            Console.WriteLine("How much would you like to withdraw?");
            decimal withdrawTotal = decimal.Parse(Console.ReadLine());

            decimal newTotal = currentBalance - withdrawTotal;

            Console.WriteLine($"Your balance is now: {newTotal}");

            return newTotal;
        }
    }

}
