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
    public partial class ManageMemberships : Form
    {
        Controller controllerObj;
        public ManageMemberships()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_name.Text == "" || textBox_fees.Text == "" || textBox_duration.Text == "")
            {
                MessageBox.Show("Please fill all data!");
                return;
            }

            int id = Convert.ToInt32(textBox_id.Text);
            string name = textBox_name.Text;
            int fees = Convert.ToInt32(textBox_fees.Text);
            int duration = Convert.ToInt32(textBox_duration.Text);

            int done = controllerObj.AddMembership(id, name, fees, duration);
            if (done == 0)
                MessageBox.Show("Insertion Unuccessfull!");
            else MessageBox.Show("Insertion Successfull!");
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_name.Text == "" || textBox_fees.Text == "" || textBox_duration.Text == "")
            {
                MessageBox.Show("Please fill all data!");
                return;
            }

            int id = Convert.ToInt32(textBox_id.Text);
            string name = textBox_name.Text;
            int fees = Convert.ToInt32(textBox_fees.Text);
            int duration = Convert.ToInt32(textBox_duration.Text);

            int done = controllerObj.UpdateMembership(id, name, fees, duration);
            if (done == 0)
                MessageBox.Show("Update Unuccessfull!");
            else MessageBox.Show("Update Successfull!");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (textBox_cancel.Text == "")
            {
                MessageBox.Show("Please enter data!");
                return;
            }

            int id = Convert.ToInt32(textBox_cancel.Text);

            int done = controllerObj.CancelMembership(id);
            if (done == 0)
                MessageBox.Show("Cancellation Unsuccesfull!");
            else MessageBox.Show("Cancellation Successfull!");
        }
    }
}
