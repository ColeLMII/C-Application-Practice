
namespace frmAcmeRoofing
{
    partial class frmAcmeRoofing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcmeRoofing));
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpricerper = new System.Windows.Forms.TextBox();
            this.txttotalsq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCTotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJobTotal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(195, 115);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(147, 23);
            this.txtCName.TabIndex = 0;
            this.txtCName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price per Square Foot:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Square Feet:";
            // 
            // txtpricerper
            // 
            this.txtpricerper.Location = new System.Drawing.Point(195, 168);
            this.txtpricerper.Name = "txtpricerper";
            this.txtpricerper.Size = new System.Drawing.Size(147, 23);
            this.txtpricerper.TabIndex = 4;
            this.txtpricerper.TextChanged += new System.EventHandler(this.txtpricerper_TextChanged);
            // 
            // txttotalsq
            // 
            this.txttotalsq.Location = new System.Drawing.Point(195, 222);
            this.txttotalsq.Name = "txttotalsq";
            this.txttotalsq.Size = new System.Drawing.Size(147, 23);
            this.txttotalsq.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(387, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Computed Total Price:";
            // 
            // txtCTotalPrice
            // 
            this.txtCTotalPrice.Location = new System.Drawing.Point(399, 136);
            this.txtCTotalPrice.Name = "txtCTotalPrice";
            this.txtCTotalPrice.ReadOnly = true;
            this.txtCTotalPrice.Size = new System.Drawing.Size(147, 23);
            this.txtCTotalPrice.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(434, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Job Total:";
            // 
            // txtJobTotal
            // 
            this.txtJobTotal.Location = new System.Drawing.Point(399, 211);
            this.txtJobTotal.Name = "txtJobTotal";
            this.txtJobTotal.ReadOnly = true;
            this.txtJobTotal.Size = new System.Drawing.Size(147, 23);
            this.txtJobTotal.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(146, 301);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 29);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(246, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 29);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCal.Location = new System.Drawing.Point(350, 301);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(96, 29);
            this.btnCal.TabIndex = 12;
            this.btnCal.Text = "&Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(101, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(399, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Acme Roofing Company - Bidding System";
            // 
            // frmAcmeRoofing
            // 
            this.AcceptButton = this.btnCal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(621, 432);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtJobTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCTotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttotalsq);
            this.Controls.Add(this.txtpricerper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAcmeRoofing";
            this.Text = "Acme Roofing Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpricerper;
        private System.Windows.Forms.TextBox txttotalsq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJobTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label6;
    }
}

