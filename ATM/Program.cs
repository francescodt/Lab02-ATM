using System;

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
                    userBalance = WithdrawalHandler(userBalance);
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
    }
}
