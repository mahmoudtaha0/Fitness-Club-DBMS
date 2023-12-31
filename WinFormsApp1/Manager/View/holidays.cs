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
    public partial class holidays : Form
    {

        Controller controller;

        public holidays()
        {
            InitializeComponent();

            controller = new Controller();

            //if (show == 'R')
            //{
            //    respond_panel.Visible = true;
            //    respond_panel.Enabled = true;
            //    view_requests_dgv.Visible = false;
            //    view_requests_dgv.Enabled = false;

            //}
            //else if (show == 'S')
            //{
            //    view_requests_dgv.Visible = true;
            //    view_requests_dgv.Enabled = true;
            //    respond_panel.Visible = false;
            //    respond_panel.Enabled = false;
            //}

        }

        private void holidays_requests_combob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void holidays_Load(object sender, EventArgs e)
        {

            DataTable dt = controller.viewPendingHolidays();

            view_requests_dgv.DataSource = dt;
            view_requests_dgv.Refresh();

        }

        private void view_requests_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void view_requests_dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            string ssn = view_requests_dgv.Rows[rowindex].Cells[0].Value.ToString();
            string startDate = view_requests_dgv.Rows[rowindex].Cells[2].Value.ToString();
            string endDate = view_requests_dgv.Rows[rowindex].Cells[3].Value.ToString();


            ssnTb.Text = ssn;
            startDateTb.Text = startDate;
            endDateTb.Text = endDate;

        }


        private void holidays_approve_button_Click(object sender, EventArgs e)
        {

            controller.acceptHoliday(ssnTb.Text, startDateTb.Text, endDateTb.Text);
            DataTable dt = controller.viewPendingHolidays();

            view_requests_dgv.DataSource = dt;
            view_requests_dgv.Refresh();

        }

        private void holidays_reject_button_Click(object sender, EventArgs e)
        {

            controller.rejectHoliday(ssnTb.Text, startDateTb.Text, endDateTb.Text);
            DataTable dt = controller.viewPendingHolidays();

            view_requests_dgv.DataSource = dt;
            view_requests_dgv.Refresh();

        }
    }
}
