using Xunit;
using HæveautomatUnitTest;

namespace UnitTesting.Test
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldTestIfIsPinCodeValidWorks()
        {
            // Arrange
            bool expected = true;

            // Act
            Validation validate = new Validation();
            bool actual = validate.IsPinCodeValid(4444, 4444);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldTestIfWithdrawWorks()
        {
            Automat automat = new Automat();
            automat.InsertCard(new Card(1234, "Patrick", 4444, 10000));
            automat.TypePinCode(4444);
            // Arrange
            decimal expected = 20;

            // Act
            decimal actual = automat.Withdraw(20);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}