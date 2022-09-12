using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_PIN_Verification
{
    public partial class frmBankPIN : Form
    {
        public frmBankPIN()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {//easier to check length of a string than Int32...
                    string PIN = Convert.ToString(txtPIN.Text);
                    if(PIN.Length == 4 || PIN.Length == 6)
                    {
                        lstPINs.Items.Add(PIN); //adds the pin to the list...
                    }

                    else
                    {
                        MessageBox.Show("Insert a Pin that is 4 or 6 digits long.");
                        txtPIN.Focus();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verify all values.");
            }
        }

        // isvalid data and error handling methods....
        public bool IsValidData()
        {
            return
                isPresent(txtPIN, "PIN") &&
                IsInt32(txtPIN, "PIN");
        }

        public bool isPresent(TextBox textbox, string name)
        {
            if(textbox.Text == "")
            {
                MessageBox.Show(name + " is a required field.");
                textbox.Focus();
                return false;
            }
            else
                return true;
        }

        public bool IsInt32(TextBox textbox, string name)
        {
            //uses parsing, analyze (a string or text) into logical syntactic components, typically in order to test conformability to a logical grammar.
            //error handling...

            int number = 0;

            if(Int32.TryParse(textbox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an Integer.");
                textbox.Focus();
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //...
    }
}
