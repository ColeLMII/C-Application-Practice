using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cboNames.Items.Add("Mike Smith");
            cboNames.Items.Add("Nancy Jones");
        }

        private void btnSelectPayment_Click(object sender, EventArgs e)
        {
            Form paymentForm = new frmPayment();
            DialogResult selectedButton = paymentForm.ShowDialog();
        }

        private bool IsValidData()
        {
            if (cboNames.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a customer.");
                cboNames.Focus();
                return false;
            }
            if (lblPayment.Text == "")
            {
                MessageBox.Show("You must enter a payment.");
                return false;
            }
            return true;
        }
    }
}