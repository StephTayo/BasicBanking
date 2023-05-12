using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankingData.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void DepositTestPositiveAmount()
        {
            // arrange
            Account acct = new Account(100);
            decimal amount = 70;
            decimal expectedBalance = 170;
            decimal actualBalance;

            // act 
            acct.Deposit(amount);
            actualBalance = acct.Balance;

            // assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod()]
        public void DepositTestNegativeAmount()
        {
            // arrange
            Account acct = new Account(100);
            decimal amount = -70;
            decimal expectedBalance = 100;
            decimal actualBalance;

            // act 
            acct.Deposit(amount);
            actualBalance = acct.Balance;

            // assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod()]
        public void WithdrawTestNegativeAmount()
        {
            // arrange
            Account acct = new Account(100);
            decimal amount = -70;
            decimal expectedBalance = 100;
            decimal actualBalance;
            bool expectedResult = true;
            bool actualResult;

            // act 
            actualResult = acct.Withdraw(amount);
            actualBalance = acct.Balance;

            // assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void WithdrawTestPositiveAmountSuccess()
        {
            // arrange
            Account acct = new Account(100);
            decimal amount = 70;
            decimal expectedBalance = 30;
            decimal actualBalance;
            bool expectedResult = true;
            bool actualResult;

            // act 
            actualResult = acct.Withdraw(amount);
            actualBalance = acct.Balance;

            // assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod()]
        public void WithdrawTestPositiveAmountNSF()
        {
            // arrange
            Account acct = new Account(100);
            decimal amount = 170;
            decimal expectedBalance = 100;
            decimal actualBalance;
            bool expectedResult = false;
            bool actualResult;

            // act 
            actualResult = acct.Withdraw(amount);
            actualBalance = acct.Balance;

            // assert
            Assert.AreEqual(expectedBalance, actualBalance);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}