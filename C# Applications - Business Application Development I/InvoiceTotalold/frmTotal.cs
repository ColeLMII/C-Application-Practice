using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDiscountPercent_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //other declarations
        int count = 0;
        decimal totInvoice = 0m; 
        decimal aveInvoice = 0m;
        decimal laInv = 0m; //largest invoice
        decimal smInv = 0m; //smallest inv...

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtEnterSubtotal.Text == "")
            {
                MessageBox.Show("Enter your Subtotal.");
            }
            else
            {
                //the code below calculate discount percentage, amount, and subtotal
                decimal subtotal = Convert.ToDecimal(txtEnterSubtotal.Text);
                decimal DiscountPercentage = 0m; // 0m is used to denote the discount percentage is zero for the moment

                if (subtotal >= 500)
                {
                    DiscountPercentage = .2m; // so the m is like the percentage symbol

                }
                else if (subtotal >= 250 && subtotal < 500)
                {
                    DiscountPercentage = .5m;
                }
                else if (subtotal >= 100 && subtotal < 250)
                {
                    DiscountPercentage = .1m;
                }

                decimal DiscountAmount = subtotal * DiscountPercentage;
                decimal invTotal = subtotal - DiscountAmount;

                txtSubtotal.Text = subtotal.ToString();
                txtDiscountPercentage.Text = DiscountPercentage.ToString("p1");
                txtDiscountAmount.Text = DiscountAmount.ToString("c");
                txtTotal.Text = invTotal.ToString("c");

                //updates the count of invoices
                count++;
                txtNumberofInvoices.Text = count.ToString();
                totInvoice += invTotal;
                    txtTotalInvoice.Text = totInvoice.ToString("c");
                aveInvoice = (totInvoice / count);

                //Smallest and Largest code....
                laInv = Math.Max(laInv, invTotal);
                smInv = Math.Min(smInv, invTotal);

                txtInvoiceAverage.Text = aveInvoice.ToString("c"); //"c" currency formatting
                txtLarge.Text = laInv.ToString("c");
                txtSmall.Text = smInv.ToString("c"); // always show zero so how do you fucking fix it accoridng to the professor????

                //sets cursor on the Enter Subtotal text box.
                txtEnterSubtotal.Text = "";
                txtEnterSubtotal.Focus();
            }

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            totInvoice = 0m;
            aveInvoice = 0m;
            laInv = 0m;
            smInv = 0m;

            txtNumberofInvoices.Text = "";
            txtTotalInvoice.Text = "";
            txtInvoiceAverage.Text = "";

            txtEnterSubtotal.Focus();
            txtDiscountAmount.Text = "";
            txtDiscountPercentage.Text = "";
            txtSubtotal.Text = "";
            txtTotal.Text = "";
            txtSmall.Text = "";
            txtLarge.Text = ""; // is there a way to clear all textboxes
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtLarge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
