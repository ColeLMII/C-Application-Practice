using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubeCalculator
{
    public partial class frmCubeCalculator : Form
    {
        public frmCubeCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal userVal = Convert.ToDecimal(txtInteger.Text);
            decimal result = 1;

            for (int x = 0; x < 3; x++)
                result = result * userVal;

            txtCubeResult.Text = Convert.ToString(result);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
