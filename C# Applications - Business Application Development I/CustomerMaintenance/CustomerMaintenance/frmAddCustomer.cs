using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        public bool isValidData()
        { //No.3 
            return
            isPresent(txtFirstName, "First Name ") &&
            isPresent(txtLastName, "Last Name ") &&
            isPresent(txtEmail, "Email ");

        }

        public bool isPresent(TextBox textbox, string x)
        {//No.3 
            if (textbox.Text == " ")
            {
                MessageBox.Show(x + "is a required field.");
                textbox.Focus();
                return false;
            }

            else
                return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {//No.4?
            try
            {
                if (isValidData())
                { //No.5
                    string customer = null;
                    customer = txtFirstName.Text + " " + txtLastName.Text + " " + txtEmail.Text;

                    //tag this data to send it to frmCustomer
                    this.Tag = customer;
                    this.DialogResult = DialogResult.OK; 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fix your errors.");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}