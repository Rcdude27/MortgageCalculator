using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgagePaymentCalculation
{
    public class MortgageCalculations
    {      
        public string MortgageCalc(double dPrinciple, double dAIR, double dTerm) 
        {
            double dTermInMonths = dTerm * 12;
            double dMonthlyInterestRate = (dAIR / 12) / 100;
            double d1PlusR = Math.Pow(1 + dMonthlyInterestRate, dTermInMonths);
            double dNumerator = dMonthlyInterestRate * d1PlusR;
            double dDenominator = d1PlusR - 1;
            double dMortgagePayment = dPrinciple * (dNumerator / dDenominator);

            return dMortgagePayment.ToString("C2");
        }
    }
}
