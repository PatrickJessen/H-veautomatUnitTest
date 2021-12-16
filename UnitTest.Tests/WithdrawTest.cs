using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HæveautomatUnitTest;
using Xunit;

namespace UnitTest.Tests
{
    public class WithdrawTest
    {
        [Fact]
        public void ShouldValidatePincode()
        {
            // Arrange
            int expected = 4444;

            // Act
            Validation validate = new Validation();
            int actual = validate.ValidatePincode(4444);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
