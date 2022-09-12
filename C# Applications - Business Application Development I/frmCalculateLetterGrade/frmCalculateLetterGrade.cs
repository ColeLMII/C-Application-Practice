using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCalculateGrade
{
    public partial class frmCalculateLetterGrade : Form
    {
        public frmCalculateLetterGrade()
        {
            InitializeComponent();
            
        }

        private void lblNumberGrade_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
        if(txtNumberGrade.Text == "")
            {
                MessageBox.Show("**Please enter the number grade and the select calculate.**");
            }
        else
            {
                //program determines the letter grade based off the number grade entered.

                decimal lGrade = Convert.ToDecimal(txtNumberGrade.Text); //q2
                string v;

                if (lGrade >= 90)
                {
                    v = "A";
                }
                else if (lGrade >= 80 && lGrade <= 89)
                {
                    v = "B";
                }
                else if (lGrade >= 70 && lGrade <= 79)
                {
                    v = "C";

                }
                else if (lGrade >= 60 && lGrade <= 69)
                {
                    v = "D";
                }
                else
                {
                    v = "F";
                }

                txtLetterGrade.Text = v;

                txtNumberGrade.Focus(); // refocuses pointer for the user.
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //should shut the program down.
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumberGrade.Text = "";
            txtLetterGrade.Text = "";

            txtNumberGrade.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
