using System;

namespace AccountFormatLibrary {

    public class FormatAccount {
        //method
        public static decimal CalculateInterestByMonths(int months, decimal interestRate, decimal balance) {

            return balance * (interestRate / 12) * months;

        }

    }
}
