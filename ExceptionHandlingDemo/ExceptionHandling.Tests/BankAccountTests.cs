using Xunit;
using ExceptionHandling.Core;

namespace ExceptionHandling.Tests
{
    public class BankAccountTests
    {
        [Fact]
        public void Withdraw_ValidAmount_ShouldDecreaseBalance()
        {
            // Arrange
            var account = new BankAccount(100.00m);
            decimal amountToWithdraw = 30.00m;

            // Act
            account.Withdraw(amountToWithdraw);

            // Assert
            Assert.Equal(70.00m, account.Balance);
        }

        [Fact]
        public void Withdraw_InsufficientFunds_ShouldThrowInsufficientFundsException()
        {
            // Arrange
            var account = new BankAccount(50.00m);
            decimal amountToWithdraw = 100.00m;

            // Act & Assert

            Assert.Throws<InsufficientFundsException>(() =>
            {
                account.Withdraw(amountToWithdraw);
            });
        }
    }
}
