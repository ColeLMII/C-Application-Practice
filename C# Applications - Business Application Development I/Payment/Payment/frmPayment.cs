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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lbCreditCardType.Items.Add("Visa");
            lbCreditCardType.Items.Add("Mastercard");
            lbCreditCardType.Items.Add("American Express");
            lbCreditCardType.SelectedIndex = 0;

            string[] months =
            {
                "Select a month...","January","February","March","April",
                "May","June","July","August","September","October","November","December"
            };
        }
    }
}
