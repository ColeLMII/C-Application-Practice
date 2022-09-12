
namespace Payment
{
    partial class frmPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPaymentType = new System.Windows.Forms.GroupBox();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.rdoBillCustomer = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCreditCardType = new System.Windows.Forms.ListBox();
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.cbExpMonth = new System.Windows.Forms.ComboBox();
            this.cbExpYear = new System.Windows.Forms.ComboBox();
            this.chkDefaultMethod = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbPaymentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPaymentType
            // 
            this.gbPaymentType.Controls.Add(this.rdoBillCustomer);
            this.gbPaymentType.Controls.Add(this.rdoCreditCard);
            this.gbPaymentType.Location = new System.Drawing.Point(41, 29);
            this.gbPaymentType.Name = "gbPaymentType";
            this.gbPaymentType.Size = new System.Drawing.Size(230, 79);
            this.gbPaymentType.TabIndex = 0;
            this.gbPaymentType.TabStop = false;
            this.gbPaymentType.Text = "Payment Type";
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.AutoSize = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(21, 32);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(77, 17);
            this.rdoCreditCard.TabIndex = 0;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit Card";
            this.rdoCreditCard.UseVisualStyleBackColor = true;
            // 
            // rdoBillCustomer
            // 
            this.rdoBillCustomer.AutoSize = true;
            this.rdoBillCustomer.Location = new System.Drawing.Point(126, 32);
            this.rdoBillCustomer.Name = "rdoBillCustomer";
            this.rdoBillCustomer.Size = new System.Drawing.Size(85, 17);
            this.rdoBillCustomer.TabIndex = 1;
            this.rdoBillCustomer.TabStop = true;
            this.rdoBillCustomer.Text = "Bill Customer";
            this.rdoBillCustomer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credit Card Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Card Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Expiration Date";
            // 
            // lbCreditCardType
            // 
            this.lbCreditCardType.FormattingEnabled = true;
            this.lbCreditCardType.Location = new System.Drawing.Point(167, 136);
            this.lbCreditCardType.Name = "lbCreditCardType";
            this.lbCreditCardType.Size = new System.Drawing.Size(104, 17);
            this.lbCreditCardType.TabIndex = 4;
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Location = new System.Drawing.Point(167, 182);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCreditCardNumber.TabIndex = 5;
            // 
            // cbExpMonth
            // 
            this.cbExpMonth.FormattingEnabled = true;
            this.cbExpMonth.Location = new System.Drawing.Point(167, 218);
            this.cbExpMonth.Name = "cbExpMonth";
            this.cbExpMonth.Size = new System.Drawing.Size(85, 21);
            this.cbExpMonth.TabIndex = 6;
            // 
            // cbExpYear
            // 
            this.cbExpYear.FormattingEnabled = true;
            this.cbExpYear.Location = new System.Drawing.Point(258, 218);
            this.cbExpYear.Name = "cbExpYear";
            this.cbExpYear.Size = new System.Drawing.Size(85, 21);
            this.cbExpYear.TabIndex = 7;
            // 
            // chkDefaultMethod
            // 
            this.chkDefaultMethod.AutoSize = true;
            this.chkDefaultMethod.Location = new System.Drawing.Point(167, 266);
            this.chkDefaultMethod.Name = "chkDefaultMethod";
            this.chkDefaultMethod.Size = new System.Drawing.Size(143, 17);
            this.chkDefaultMethod.TabIndex = 8;
            this.chkDefaultMethod.Text = "Default Payment Method";
            this.chkDefaultMethod.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(62, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(167, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 387);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkDefaultMethod);
            this.Controls.Add(this.cbExpYear);
            this.Controls.Add(this.cbExpMonth);
            this.Controls.Add(this.txtCreditCardNumber);
            this.Controls.Add(this.lbCreditCardType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbPaymentType);
            this.Name = "frmPayment";
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.gbPaymentType.ResumeLayout(false);
            this.gbPaymentType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPaymentType;
        private System.Windows.Forms.RadioButton rdoBillCustomer;
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbCreditCardType;
        private System.Windows.Forms.TextBox txtCreditCardNumber;
        private System.Windows.Forms.ComboBox cbExpMonth;
        private System.Windows.Forms.ComboBox cbExpYear;
        private System.Windows.Forms.CheckBox chkDefaultMethod;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}