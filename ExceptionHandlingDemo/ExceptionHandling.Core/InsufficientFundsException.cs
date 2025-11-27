using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling.Core
{
    public class InsufficientFundsException : Exception
    {
        // Standardowy konstruktor
        public InsufficientFundsException()
        {
        }

        // Konstruktor przyjmujący wiadomość (Message)
        public InsufficientFundsException(string message)
            : base(message)
        {
        }

        // Konstruktor przyjmujący wiadomość i innerException (gdy chcemy zawinąć inny wyjątek)
        public InsufficientFundsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
