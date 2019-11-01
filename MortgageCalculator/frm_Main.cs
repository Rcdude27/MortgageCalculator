using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MortgageCalculator {
    public partial class frm_Main : Form {
        public frm_Main() {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e) 
        {
           txtPayment.Text = MortgageCalc(Convert.ToDouble(txtPrinc.Text), Convert.ToDouble(txtInterest.Text), Convert.ToDouble(txtTerm.Text));
        }

        private string MortgageCalc(double dPrinciple, double dAIR, double dTerm) 
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
