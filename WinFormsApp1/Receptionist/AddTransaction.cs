using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Receptionist
{
    public partial class AddTransaction : Form
    {
        Controller controllerObj;
        public AddTransaction()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void label_trdate_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox_amount.Text == "")
            {
                MessageBox.Show("Please enter all data!");
                return;
            }
            
            string ssn = textBox2.Text;
            string date = dateTimePicker1.Text;
            string type = comboBox_type.Text;
            string amount = textBox_amount.Text;
            string description = comboBox_description.Text;

            int done = controllerObj.addTransaction(ssn, date, Convert.ToInt32(amount), type, description);

            if (done == 0)
                MessageBox.Show("Transaction not added");
            else MessageBox.Show("Transaction added successfully");
        }
    }
}
