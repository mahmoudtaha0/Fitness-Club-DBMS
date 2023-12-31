using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class finance : Form
    {

        Controller controller;

        public finance()
        {
            InitializeComponent();

            controller = new Controller();

        }

        private void transaction_button_Click(object sender, EventArgs e)
        {

            string selectDateAsString = transaction_date_dp.Value.ToString("yyyy-MM-dd");

            int ret = controller.addTransaction(transaction_SSN_tb.Text, selectDateAsString,
                Convert.ToInt32(transaction_amount_tb.Text), transaction_type_combob.Text, transaction_description_tb.Text);

            if (ret == 0)
            {
                MessageBox.Show("Couldn't Add!");
            }
            else
            {
                MessageBox.Show("Added Successfuly!");
            }

        }
    }
}
