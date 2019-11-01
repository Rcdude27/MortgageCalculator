using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MortgagePaymentCalculation;

namespace MortgageCalculator {

    public partial class frm_Main : Form {
        public frm_Main() 
        {
            InitializeComponent();
        }

        MortgageCalculations mcCal = new MortgageCalculations();

        private void btnCalc_Click(object sender, EventArgs e) 
        {
            txtPayment.Text = mcCal.MortgageCalc(Convert.ToDouble(txtPrinc.Text), Convert.ToDouble(txtInterest.Text), Convert.ToDouble(txtTerm.Text));
        }
    }
}
