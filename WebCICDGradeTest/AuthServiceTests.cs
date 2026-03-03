using Xunit;
using GradeSystem;

namespace GradeSystemTest
{
    public class AuthServiceTests
    {
        [Fact]
        public void Login_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            string username = "admin";
            string password = "admin123";

            // Act
            bool result = AuthService.Login(username, password);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Login_InvalidCredentials_ReturnsFalse()
        {
            string username = "admin";
            string password = "wrongpass";

            bool result = AuthService.Login(username, password);

            Assert.False(result);
        }

        [Fact]
        public void Login_EmptyUsername_ReturnsFalse()
        {
            string username = "";
            string password = "admin123";

            bool result = AuthService.Login(username, password);

            Assert.False(result);
        }

        [Fact]
        public void Login_EmptyPassword_ReturnsFalse()
        {
            string username = "admin";
            string password = "";

            bool result = AuthService.Login(username, password);

            Assert.False(result);
        }

        [Fact]
        public void Login_NonExistingUser_ReturnsFalse()
        {
            string username = "unknown";
            string password = "123";

            bool result = AuthService.Login(username, password);

            Assert.False(result);
        }
    }
}
