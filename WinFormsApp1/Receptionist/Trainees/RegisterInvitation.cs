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
    public partial class RegisterInvitation : Form
    {
        Controller controllerObj;
        public RegisterInvitation()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (textBox_guestname.Text == "" || textBox_mobile.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill all data!");
                return;
            }

            string name = textBox_guestname.Text;
            string mobile = textBox_mobile.Text;
            string ssn = textBox2.Text;
            string date = dateTimePicker1.Text;

            int done = controllerObj.AddInvitation(name, mobile, ssn, date);
            if (done == 0)
                MessageBox.Show("Invitation Registered!");
            else MessageBox.Show("Invitation Not Registered!");
        }
    }
}
