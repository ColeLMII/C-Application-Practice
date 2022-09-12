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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //No.2
            Form CustomerForm = new frmAddCustomer();
            //this opens the form
            DialogResult selectedButton = CustomerForm.ShowDialog();
            
            //is the dialogue result functioning properly? okay then 
            if(selectedButton == DialogResult.OK)
            {
                lstCustomers.Items.Add(CustomerForm.Tag); //Tag, objects that we can store data in like a pointer...
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {// to delete one item at a time.
            int index = lstCustomers.SelectedIndex;

            if(index != -1)
            {
                string message = " Delete for sure?";

                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    lstCustomers.Items.RemoveAt(index);
                }
            }
            else
            {
                MessageBox.Show("No item has been deleted.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}