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

        private void isTextEmpty(string TextBoxText)
        {
            if (TextBoxText == "" || TextBoxText == ".")
                btnCalc.Enabled = false;
            else
                btnCalc.Enabled = true;
        }

        private void txtPrinc_KeyPress(object sender, KeyPressEventArgs e)
        {
            isTextEmpty(txtPrinc.Text);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtInterest_KeyPress(object sender, KeyPressEventArgs e)
        {
            isTextEmpty(txtInterest.Text);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }
        private void txtTerm_KeyPress(object sender, KeyPressEventArgs e)
        {
            isTextEmpty(txtPrinc.Text);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
