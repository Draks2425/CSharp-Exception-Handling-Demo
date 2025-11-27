using System;
using ExceptionHandling.Core;

namespace ExceptionHandling.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(200.00m);
            decimal withdrawalAmount = 300.00m; // Kwota, która spowoduje wyjątek

            Console.WriteLine($"Current balance: {account.Balance:C}");
            Console.WriteLine($"Attempting to withdraw: {withdrawalAmount:C}");

            try
            {
                Console.WriteLine("\n--- Entering TRY block ---");
                account.Withdraw(withdrawalAmount); // TUTAJ RZUCONY ZOSTANIE WYJĄTEK
                Console.WriteLine("Withdrawal successful. (This line won't be executed)");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine("\n--- Entering CATCH block (InsufficientFundsException) ---");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Insufficient Funds!");
                Console.WriteLine($"Details: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n--- Entering CATCH block (General Exception) ---");
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
//a
                Console.WriteLine("\n--- Entering FINALLY block ---");
                Console.WriteLine($"Operation finished. Final balance check: {account.Balance:C}");
            }

            Console.WriteLine("\nProgram finished. Press any key to exit.");
            Console.ReadKey();
        }
    }
}