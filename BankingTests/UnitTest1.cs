using BankingLibrary;

namespace BankingTests
{
    public class UserAccountTests
    {
        private readonly string _userFilePath = @"C:\Users\myuser\Documents\userfile.txt";

        [Test]
        public void Login_ExistingUser_ReturnsUserModel()
        {
            // Arrange
            var userAccount = new TextFileConnector();
            var username = "testuser";
            var password = "testpassword";

            // Act
            var result = userAccount.Login(username, password);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result.UserName, username);
            Assert.AreEqual(result.Password, password);
        }

        [Test]
        public void Login_NonExistingUser_ReturnsNull()
        {
            // Arrange
            var userAccount = new TextFileConnector();

            var username = "nonexistinguser";
            var password = "testpassword";

            // Act
            var result = userAccount.Login(username, password);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void CheckBalance_ExistingUser_ReturnsBalance()
        {
            // Arrange
            var userAccount = new TextFileConnector();
            var user = new UserModel { Id = 1 };
            var expectedBalance = 100;

            // Act
            var result = userAccount.CheckBalance(user);

            // Assert
            Assert.AreEqual(result, expectedBalance);
        }

        [Test]
        public void CheckBalance_NonExistingUser_ThrowsException()
        {
            // Arrange
            var userAccount = new TextFileConnector();


            var user = new UserModel { Id = 999 };

            // Act & Assert
            Assert.Throws<Exception>(() => userAccount.CheckBalance(user));
        }

        [Test]
        public void Deposit_ExistingUser_AddsAmountToBalance()
        {
            // Arrange
            var userAccount = new TextFileConnector();

            var user = new UserModel { Id = 1 };
            var initialBalance = userAccount.CheckBalance(user);
            var depositAmount = 50;
            var expectedBalance = initialBalance + depositAmount;

            // Act
            var result = userAccount.Deposit(user, depositAmount);

            // Assert
            Assert.AreEqual(result, expectedBalance);
        }

        [Test]
        public void Deposit_NonExistingUser_ThrowsException()
        {
            // Arrange
            var userAccount = new TextFileConnector();

            var user = new UserModel { Id = 999 };
            var depositAmount = 50;

            // Act & Assert
            Assert.Throws<Exception>(() => userAccount.Deposit(user, depositAmount));
        }

        [Test]
        public void Transfer_ExistingUser_RemovesAmountFromBalance()
        {
            // Arrange
            var userAccount = new TextFileConnector();
            var user = new UserModel { Id = 1 };
            var initialBalance = userAccount.CheckBalance(user);
            var transferAmount = 50;
            var expectedBalance = initialBalance - transferAmount;

            // Act
            var result = userAccount.Transfer(user, transferAmount);

            // Assert
            Assert.AreEqual(result, expectedBalance);
        }

        [Test]
        public void Transfer_NonExistingUser_ThrowsException()
        {
            // Arrange
            var userAccount = new TextFileConnector();
            var user = new UserModel { Id = 999 };
            var transferAmount = 50;

            // Act & Assert
            Assert.Throws<Exception>(() => userAccount.Transfer(user, transferAmount));
        }
    }
}