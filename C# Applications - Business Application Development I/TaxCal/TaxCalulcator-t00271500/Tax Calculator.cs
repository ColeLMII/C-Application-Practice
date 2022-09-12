using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variable declarations
            decimal TaxableIncome= .0m;
            decimal TaxOwed= .0m;

            if(txtTaxableIncome.Text == "")
            {
                MessageBox.Show("*You must enter your Taxable Income.*");
            }
            else
            {
                TaxableIncome = Convert.ToDecimal(txtTaxableIncome.Text);
                TaxOwed = .0m;

                if(TaxableIncome >= 0 && TaxableIncome <= 9225)
                {
                    TaxOwed = (TaxableIncome * .10m);
                    txtTaxOwed.Text = Convert.ToString(TaxOwed);
                }
                else if(TaxableIncome > 9225 && TaxableIncome <= 37450)
                {
                    TaxOwed = (TaxableIncome - 9225) * .15m + 922.5m;
                    txtTaxOwed.Text = Convert.ToString(TaxOwed);
                }
                else if (TaxableIncome > 37450 && TaxableIncome <= 90750)
                {
                    TaxOwed = (TaxableIncome - 37450) * .25m + 5156.25m;
                    txtTaxOwed.Text = Convert.ToString(TaxOwed);
                }
                else if (TaxableIncome > 90750 && TaxableIncome <= 189300)
                {
                    TaxOwed = (TaxableIncome - 90750) * .28m + 18481.25m;
                    txtTaxOwed.Text = Convert.ToString(TaxOwed);
                }
                else if (TaxableIncome > 189300 && TaxableIncome <= 411500)
                {
                    TaxOwed = (TaxableIncome - 189300) * .33m + 46075.25m;
                    txtTaxOwed.Text = Convert.ToString(TaxOwed);
                }
                else if (TaxableIncome > 411500 && TaxableIncome <= 413200)
                {
                    TaxOwed = (TaxableIncome - 411500) * .35m + 119401.25m;
                    txtTaxOwed.Text = Convert.ToString(TaxOwed);
                }
                else
                {
                    TaxOwed = (TaxableIncome - 413200) * .396m + 922.5m;
                    txtTaxOwed.Text = Convert.ToString(TaxOwed);
                }
            }

        }

        private void ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //variable declarations
            decimal TaxableIncome = .0m;
            decimal TaxOwed = .0m;

            if (txtTaxableIncome.Text == "")
            {
                MessageBox.Show("*You must enter your Taxable Income.*");
            }
            else
            {
                TaxableIncome = Convert.ToDecimal(txtTaxableIncome.Text);
                TaxOwed = .0m;

                if (TaxableIncome >= 0 && TaxableIncome <= 9225)
                {
                    TaxOwed = (TaxableIncome * .10m);
                    txtTaxOwed.Text = Convert.ToString(TaxOwed);
                }
                else if (TaxableIncome > 9225 && TaxableIncome <= 37450)
                {
                    TaxOwed = (TaxableIncome - 9225) * .15m + 922.5m;
                    txtTaxOwed.Text = Convert.ToString(TaxOwed);
                }
                else if (TaxableIncome > 37450 && TaxableIncome <= 90750)
                {
                    TaxOwed = (TaxableIncome - 37450) * .25m + 5156.25m;
                    txtTaxOwed.Text = Convert.ToString(TaxOwed);
                }
                else if (TaxableIncome > 90750 && TaxableIncome <= 189300)
                {
                    TaxOwed = (TaxableIncome - 90750) * .28m + 18481.25m;
                    txtTaxOwed.Text = Convert.ToString(TaxOwed);
                }
                else if (TaxableIncome > 189300 && TaxableIncome <= 411500)
                {
                    TaxOwed = (TaxableIncome - 189300) * .33m + 46075.25m;
                    txtTaxOwed.Text = Convert.ToString(TaxOwed);
                }
                else if (TaxableIncome > 411500 && TaxableIncome <= 413200)
                {
                    TaxOwed = (TaxableIncome - 411500) * .35m + 119401.25m;
                    txtTaxOwed.Text = Convert.ToString(TaxOwed);
                }
                else
                {
                    TaxOwed = (TaxableIncome - 413200) * .396m + 922.5m;
                    txtTaxOwed.Text = Convert.ToString(TaxOwed);
                }
            }

        }
    }
}
