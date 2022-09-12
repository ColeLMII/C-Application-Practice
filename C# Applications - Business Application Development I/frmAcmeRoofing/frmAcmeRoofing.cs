using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAcmeRoofing
{
    public partial class frmAcmeRoofing : Form
    {
        public frmAcmeRoofing()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtpricerper_TextChanged(object sender, EventArgs e)
        {

        }
        decimal jobtotals = 0m; //does this hold the total value of all jobs ?? not specific

        private void btnCal_Click(object sender, EventArgs e)
        {
            //variable declarations...
            if((txtpricerper.Text) == ""){
                MessageBox.Show(">You have not entered: Price for Square Foot. Please do so and continue...");
            }
            else if (txttotalsq.Text == ""){
                MessageBox.Show(">You have not entered: Total Square Feet. Please do so and continue...");
            }
            else{ 
                decimal priceper = Convert.ToDecimal(txtpricerper.Text);
                decimal totalsqprice = Convert.ToDecimal(txttotalsq.Text);
                decimal thisjobprice;
                

                /*
                 Calulcations below here....
                    + This job total.
                    + Collected Total of All Jobs.
                */

                thisjobprice = priceper * totalsqprice; // get this to display somewhere ....

                jobtotals += thisjobprice; // adds up all the totals. ( that zero migth cause an issue

                //displays this job total and collection of job totals.
                txtCTotalPrice.Text = Convert.ToString(thisjobprice);
                txtJobTotal.Text = Convert.ToString(jobtotals);

                //refocus...
                txtCName.Focus();

                /*
                //clear the recent values...
                    txtCName.Text = "";
                    txtpricerper.Text = "";
                    txttotalsq.Text = "";
                */
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // this should clear all the input txtboxes...
            txtJobTotal.Text = "";
            txtCTotalPrice.Text = "";
            txtJobTotal.Text = "";
            txtpricerper.Text = "";
            txttotalsq.Text = "";
            txtCName.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closes the program...
        }
    }
}
