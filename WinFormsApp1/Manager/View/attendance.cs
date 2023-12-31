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
    public partial class attendance : Form
    {

        Controller controller;

        public attendance()
        {
            InitializeComponent();

            controller = new Controller();

        }

        private void attendance_Load(object sender, EventArgs e)
        {
            ////To take the date as "02/2022".
            ////Manager could view attendance of every month separatly
            //attendance_date_db.CustomFormat = "yyyy-MM-dd";



        }

        private void attendance_view_button_Click(object sender, EventArgs e)
        {

            string selectDateAsString = attendance_date_db.Value.ToString("yyyy-MM-dd");

            DataTable dt = controller.viewAttendanceByName(attendance_SSN_db.Text, selectDateAsString);

            attendance_dgv.DataSource = dt;
            attendance_dgv.Refresh();

        }
    }
}
