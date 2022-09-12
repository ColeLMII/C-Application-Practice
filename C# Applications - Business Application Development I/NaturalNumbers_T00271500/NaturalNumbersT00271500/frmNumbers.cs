using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaturalNumbersT00271500
{
    public partial class frmNumbers : Form
    {
        public frmNumbers()
        {
            InitializeComponent();
        }

        private void sumIT(decimal number)
        {
            try//performs sum of number calculation...
            {
                decimal sum = 0;

                for (int x = 0; x <= number; x++)
                {
                    sum+=x;
                }

                txtSumofNumbers.Text = Convert.ToString(sum);
            }
            catch (OverflowException)
            {
                txtError.Text = " Overflow Exception, Try Again.";
            }
            catch (FormatException)
            {
                txtError.Text = " Format Exception, Try Again.";
            }
            catch
            {
                txtError.Text = " General Error has occured, Try Again.";
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if(txtNumber.Text == "")
                {
                    MessageBox.Show("Please, Enter a valid NUMBER to calculate.");
                    
                }
            else
            {
                decimal number = Convert.ToDecimal(txtNumber.Text);
                //method call...
                sumIT(number);
                txtNumber.Focus();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSumofNumbers.Text = "";
            txtError.Text = "";
            txtNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
