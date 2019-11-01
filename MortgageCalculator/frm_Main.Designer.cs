namespace MortgageCalculator
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtPrinc = new System.Windows.Forms.TextBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.lblPrinc = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblTerm = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPrinc
            // 
            this.txtPrinc.Location = new System.Drawing.Point(139, 12);
            this.txtPrinc.Name = "txtPrinc";
            this.txtPrinc.Size = new System.Drawing.Size(100, 20);
            this.txtPrinc.TabIndex = 1;
            this.txtPrinc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(139, 38);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(100, 20);
            this.txtInterest.TabIndex = 3;
            this.txtInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrinc
            // 
            this.lblPrinc.AutoSize = true;
            this.lblPrinc.Location = new System.Drawing.Point(12, 15);
            this.lblPrinc.Name = "lblPrinc";
            this.lblPrinc.Size = new System.Drawing.Size(89, 13);
            this.lblPrinc.TabIndex = 0;
            this.lblPrinc.Text = "Initial Principal ($)";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Location = new System.Drawing.Point(12, 41);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(121, 13);
            this.lblInterest.TabIndex = 2;
            this.lblInterest.Text = "Annual Interest Rate (%)";
            // 
            // lblTerm
            // 
            this.lblTerm.AutoSize = true;
            this.lblTerm.Location = new System.Drawing.Point(12, 67);
            this.lblTerm.Name = "lblTerm";
            this.lblTerm.Size = new System.Drawing.Size(67, 13);
            this.lblTerm.TabIndex = 4;
            this.lblTerm.Text = "Term (Years)";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(88, 105);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(139, 145);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(100, 20);
            this.txtPayment.TabIndex = 8;
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(12, 148);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(103, 13);
            this.lblMonthlyPayment.TabIndex = 7;
            this.lblMonthlyPayment.Text = "Monthly Payment ($)";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(139, 67);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(100, 20);
            this.txtTerm.TabIndex = 9;
            this.txtTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 177);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblTerm);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblPrinc);
            this.Controls.Add(this.txtInterest);
            this.Controls.Add(this.txtPrinc);
            this.Name = "frm_Main";
            this.Text = "Interest Earned";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrinc;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.Label lblPrinc;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.TextBox txtTerm;
    }
}

