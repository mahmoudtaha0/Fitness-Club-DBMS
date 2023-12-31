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
    public partial class statistics : Form
    {

        Controller controller;

        public statistics()
        {
            InitializeComponent();

            controller = new Controller();

        }

        private void statistics_view_button_Click(object sender, EventArgs e)
        {

        }
    }
}
