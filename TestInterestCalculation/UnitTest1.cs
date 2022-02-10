using System;
using AccountFormatLibrary;
using Xunit;

namespace TestInterestCalculation {
    public class UnitTest1 {
       
        
        [Theory]
        [InlineData(36, 36, 0.12, 100)]
        [InlineData(36, 24, 0.12, 150)]
        [InlineData(96, 48, 0.12, 200)]

        public void TestCalcIntByMonths(decimal interestAmount, int months, decimal interestRate, decimal balance) {
            Assert.Equal(interestAmount, FormatAccount.CalculateInterestByMonths(months, interestRate, balance));
            
        }
    }
}
