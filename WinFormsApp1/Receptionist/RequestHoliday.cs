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
    public partial class RequestHoliday : Form
    {
        Controller controllerObj;
        public RequestHoliday()
        {
            InitializeComponent();
            controllerObj = new Controller();
            label_status.Visible = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void request_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Please enter SSN!");

            string ssn = textBox1.Text;
            string startdate = dateTimePicker1.Text;
            string enddate = dateTimePicker2.Text;

            int done = controllerObj.RequestHoliday(ssn, startdate, enddate);
            if (done == 0)
                MessageBox.Show("Request Failed!");
            else
            {
                MessageBox.Show("Request Completed");
                label_status.Visible = true;
            }
        }

        private void RequestHoliday_Load(object sender, EventArgs e)
        {

        }
    }
}
