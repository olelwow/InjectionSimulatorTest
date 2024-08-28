using InjectionInloggning;

namespace InjectionSimulatorTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Olle", "Yo123", true)]
        [InlineData("Jonas", "JoNas", true)]
        
        public void TestLogin_expect_True(string userName, string password, bool expected)
        {
            //Arrange
            LoginHandler handler = new(userName, password);

            //Act
            bool actual = handler.CheckLoginStatus();

            //ASSert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Olle' -- ", "", false)]
        [InlineData("Jonas' OR '1' = '1 ", "", false)]
        public void TestLogin_expect_False (string userName, string password, bool expected)
        {
            // Arrange
            LoginHandler handler = new(userName, password);

            //Act
            bool actual = handler.CheckLoginStatus();

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}