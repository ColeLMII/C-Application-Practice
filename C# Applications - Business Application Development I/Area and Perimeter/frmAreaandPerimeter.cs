using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_and_Perimeter
{
    public partial class frmAreaandPerimeter : Form
    {
        public frmAreaandPerimeter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtLgth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWdth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrmtr_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            //error handlings .... for users that cannot read instructions ;)
            if (txtLength.Text == "")
            {
                MessageBox.Show("You have failed to enter the Length, Please Try Again.");
            }
            else if (txtWidth.Text == "")
            {
                MessageBox.Show("You have failed to enter the Width, Please Try Again.");
            }

            else
            {
                MessageBox.Show("Enter your Width and Length.");
                //declares the variables and calculates the area and perimeter.
                decimal length = Convert.ToDecimal(txtLength.Text);
                decimal width = Convert.ToDecimal(txtWidth.Text);
                decimal area = width * length;
                decimal perimeter = (2 * width) + (2 * length);
            }
               
            //displays the area and perimeter
            txtArea.Text = area.ToString();
            txtPerimeter.Text = perimeter.ToString();

            //resets the focus
            txtLength.Focus();

        }

        private void txtExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAreaandPerimeter_Load(object sender, EventArgs e)
        {

        }
    }
}
