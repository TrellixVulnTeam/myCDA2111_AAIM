﻿namespace Interets
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hsbDurationMonth = new System.Windows.Forms.HScrollBar();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxLoan = new System.Windows.Forms.TextBox();
            this.grpBoxInterestRate = new System.Windows.Forms.GroupBox();
            this.rbtnNine = new System.Windows.Forms.RadioButton();
            this.rbtnEight = new System.Windows.Forms.RadioButton();
            this.rbtnSeven = new System.Windows.Forms.RadioButton();
            this.lblReimbbursement = new System.Windows.Forms.Label();
            this.lblNumberOfPayment = new System.Windows.Forms.Label();
            this.lblResultAmount = new System.Windows.Forms.Label();
            this.lstPeriodicity = new System.Windows.Forms.ListBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDurationMonth = new System.Windows.Forms.Label();
            this.grpBoxInterestRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capital Emprunté";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(54, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durée en mois du remboursement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Périodicité du remboursement";
            // 
            // hsbDurationMonth
            // 
            this.hsbDurationMonth.LargeChange = 1;
            this.hsbDurationMonth.Location = new System.Drawing.Point(239, 150);
            this.hsbDurationMonth.Maximum = 309;
            this.hsbDurationMonth.Name = "hsbDurationMonth";
            this.hsbDurationMonth.Size = new System.Drawing.Size(163, 18);
            this.hsbDurationMonth.TabIndex = 4;
            this.hsbDurationMonth.Value = 1;
            this.hsbDurationMonth.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbDurationMonth_Scroll);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(239, 48);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(163, 23);
            this.txtBoxName.TabIndex = 5;
            // 
            // txtBoxLoan
            // 
            this.txtBoxLoan.Location = new System.Drawing.Point(239, 99);
            this.txtBoxLoan.Name = "txtBoxLoan";
            this.txtBoxLoan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBoxLoan.Size = new System.Drawing.Size(163, 23);
            this.txtBoxLoan.TabIndex = 6;
            // 
            // grpBoxInterestRate
            // 
            this.grpBoxInterestRate.Controls.Add(this.rbtnNine);
            this.grpBoxInterestRate.Controls.Add(this.rbtnEight);
            this.grpBoxInterestRate.Controls.Add(this.rbtnSeven);
            this.grpBoxInterestRate.Location = new System.Drawing.Point(461, 48);
            this.grpBoxInterestRate.Name = "grpBoxInterestRate";
            this.grpBoxInterestRate.Size = new System.Drawing.Size(176, 136);
            this.grpBoxInterestRate.TabIndex = 7;
            this.grpBoxInterestRate.TabStop = false;
            this.grpBoxInterestRate.Text = "Taux d\'interêts";
            // 
            // rbtnNine
            // 
            this.rbtnNine.AutoSize = true;
            this.rbtnNine.Location = new System.Drawing.Point(27, 102);
            this.rbtnNine.Name = "rbtnNine";
            this.rbtnNine.Size = new System.Drawing.Size(41, 19);
            this.rbtnNine.TabIndex = 2;
            this.rbtnNine.TabStop = true;
            this.rbtnNine.Text = "9%";
            this.rbtnNine.UseVisualStyleBackColor = true;
            this.rbtnNine.CheckedChanged += new System.EventHandler(this.RbtnInterestRate_Checked);
            // 
            // rbtnEight
            // 
            this.rbtnEight.AutoSize = true;
            this.rbtnEight.Location = new System.Drawing.Point(27, 67);
            this.rbtnEight.Name = "rbtnEight";
            this.rbtnEight.Size = new System.Drawing.Size(41, 19);
            this.rbtnEight.TabIndex = 1;
            this.rbtnEight.TabStop = true;
            this.rbtnEight.Text = "8%";
            this.rbtnEight.UseVisualStyleBackColor = true;
            this.rbtnEight.CheckedChanged += new System.EventHandler(this.RbtnInterestRate_Checked);
            // 
            // rbtnSeven
            // 
            this.rbtnSeven.AutoSize = true;
            this.rbtnSeven.Location = new System.Drawing.Point(27, 32);
            this.rbtnSeven.Name = "rbtnSeven";
            this.rbtnSeven.Size = new System.Drawing.Size(41, 19);
            this.rbtnSeven.TabIndex = 0;
            this.rbtnSeven.TabStop = true;
            this.rbtnSeven.Text = "7%";
            this.rbtnSeven.UseVisualStyleBackColor = true;
            this.rbtnSeven.CheckedChanged += new System.EventHandler(this.RbtnInterestRate_Checked);
            // 
            // lblReimbbursement
            // 
            this.lblReimbbursement.AutoSize = true;
            this.lblReimbbursement.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReimbbursement.Location = new System.Drawing.Point(488, 271);
            this.lblReimbbursement.Name = "lblReimbbursement";
            this.lblReimbbursement.Size = new System.Drawing.Size(126, 20);
            this.lblReimbbursement.TabIndex = 9;
            this.lblReimbbursement.Text = "Remboursement";
            // 
            // lblNumberOfPayment
            // 
            this.lblNumberOfPayment.AutoSize = true;
            this.lblNumberOfPayment.Location = new System.Drawing.Point(417, 275);
            this.lblNumberOfPayment.Name = "lblNumberOfPayment";
            this.lblNumberOfPayment.Size = new System.Drawing.Size(38, 15);
            this.lblNumberOfPayment.TabIndex = 10;
            this.lblNumberOfPayment.Text = "label6";
            this.lblNumberOfPayment.Visible = false;
            // 
            // lblResultAmount
            // 
            this.lblResultAmount.AutoSize = true;
            this.lblResultAmount.Location = new System.Drawing.Point(670, 275);
            this.lblResultAmount.Name = "lblResultAmount";
            this.lblResultAmount.Size = new System.Drawing.Size(38, 15);
            this.lblResultAmount.TabIndex = 11;
            this.lblResultAmount.Text = "label7";
            this.lblResultAmount.Visible = false;
            // 
            // lstPeriodicity
            // 
            this.lstPeriodicity.FormattingEnabled = true;
            this.lstPeriodicity.ItemHeight = 15;
            this.lstPeriodicity.Location = new System.Drawing.Point(239, 209);
            this.lstPeriodicity.Name = "lstPeriodicity";
            this.lstPeriodicity.Size = new System.Drawing.Size(163, 79);
            this.lstPeriodicity.TabIndex = 12;
            this.lstPeriodicity.SelectedIndexChanged += new System.EventHandler(this.lstPeriodicity_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(657, 51);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(657, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblDurationMonth
            // 
            this.lblDurationMonth.AutoSize = true;
            this.lblDurationMonth.Location = new System.Drawing.Point(184, 154);
            this.lblDurationMonth.Name = "lblDurationMonth";
            this.lblDurationMonth.Size = new System.Drawing.Size(38, 15);
            this.lblDurationMonth.TabIndex = 15;
            this.lblDurationMonth.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDurationMonth);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lstPeriodicity);
            this.Controls.Add(this.lblResultAmount);
            this.Controls.Add(this.lblNumberOfPayment);
            this.Controls.Add(this.lblReimbbursement);
            this.Controls.Add(this.grpBoxInterestRate);
            this.Controls.Add(this.txtBoxLoan);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.hsbDurationMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Emprunts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxInterestRate.ResumeLayout(false);
            this.grpBoxInterestRate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private HScrollBar hsbDurationMonth;
        private TextBox txtBoxName;
        private TextBox txtBoxLoan;
        private GroupBox grpBoxInterestRate;
        private RadioButton rbtnNine;
        private RadioButton rbtnEight;
        private RadioButton rbtnSeven;
        private Label lblReimbbursement;
        private Label lblNumberOfPayment;
        private Label lblResultAmount;
        private ListBox lstPeriodicity;
        private Button btnOk;
        private Button btnCancel;
        private Label lblDurationMonth;
    }
}