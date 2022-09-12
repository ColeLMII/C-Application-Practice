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
			cbCustomerType.Items.Add("R");
			cbCustomerType.Items.Add("T");
			cbCustomerType.Items.Add("C");
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
            /*decimal subtotal = Decimal.Parse(txtSubtotal.Text);
			decimal discountPercent = .25m;
			decimal discountAmount = subtotal * discountPercent;
			decimal invoiceTotal = subtotal - discountAmount;

			discountAmount = Math.Round(discountAmount, 2);
			invoiceTotal = Math.Round(invoiceTotal, 2);

			txtDiscountPercent.Text = discountPercent.ToString("p1");
			txtDiscountAmount.Text = discountAmount.ToString();
			txtTotal.Text = invoiceTotal.ToString();

			txtSubtotal.Focus();*/

            {/* Copy and PAste this in here
				string customerType = cbCustomerType.Text;

decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);

decimal discountPercent = .0m;


if (customerType == "R" || customerType == "r")

{

if (subtotal < 100)

discountPercent = .1m;

else if (subtotal >= 100 && subtotal < 250)

discountPercent = .15m;

else if (subtotal >= 250 && subtotal < 500)

discountPercent = .25m;

else if (subtotal >= 500)

discountPercent = .30m;

}

else if (customerType == "C" || customerType == "c")

{

discountPercent = .2m;

}

else if (customerType == "T" || customerType == "t")

{

if (subtotal < 500)

discountPercent = .4m;

else

discountPercent = .5m;

}

else

{

discountPercent = .1m;

}


decimal discountAmount = subtotal * discountPercent;

decimal invoiceTotal = subtotal - discountAmount;


txtDiscountPercent.Text = discountPercent.ToString("p1");

txtDiscountAmount.Text = discountAmount.ToString("c");

txtTotal.Text = invoiceTotal.ToString("c");


cbCustomerType.Focus();
			 */
            }

            try
            {
                if (txtSubtotal.Text == "")
                {
                    MessageBox.Show("Enter a value for Subtotal");
                }
                else
                {
                    string customerType = cbCustomerType.Text;
                    decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
                    decimal discountPercent = .0m;

                    if(customerType =="R" || customerType == "r")
                    {
                        ...
                    }
                    else if(customerType == "C" || customerType == "c")
                    {
                        discountPercent = .2m;
                    }
                    else if(customerType =="T" || customerType == "t")
                    {
                        ...
                    }

                    cbCustomerType.Focus();
                }
            }

            catch ()
            {

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}