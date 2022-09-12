using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateDueDays_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to calculate the days until due date
            DateTime Today = DateTime.Today;
            DateTime Future = Convert.ToDateTime(txtFutureDate.Text);

            TimeSpan Days = Future - Today;
            
            //display in message box

            MessageBox.Show("Due Date Calculation:\n\n\n Current Date: " + Today + "\n Future Date: " + Future + "\n Days until Due Date: " + Days);

        }

        private void btnCalculateAge_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to calculate the age

            DateTime Birthday = Convert.ToDateTime(txtBirthDate.Text);
            DateTime Today = DateTime.Today;

            TimeSpan Age = (Today - Birthday);
            //aint right..
            //TimeSpan Ans = Age.Divide(365);
            
            //display in message box...
            MessageBox.Show("Age Calculation:\n\n\n Current Date: " + Today.Date + "\n Birth Date: " + Birthday.Date + "\n Age: " + ans);
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}