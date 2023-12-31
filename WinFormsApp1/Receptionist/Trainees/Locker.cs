using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Receptionist
{
    public partial class Locker : Form
    {
        Controller controllerObj;
        public Locker()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectAllLockers();
            comboBox_Number.DataSource = dt;
            comboBox_Number.DisplayMember = "number";
            comboBox_Number.ValueMember = "number";
        }

        private void textBox_Search_Trainee_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox_Search_Trainee.Text;
            DataTable dt = controllerObj.SearchTrainee(keyword);
            dataGridView_Trainee.DataSource = dt;
        }

        private void btn_Assign_Click(object sender, EventArgs e)
        {
            if (comboBox_Number.Text == " " || textBox_SSN_Trainee.Text == " ")
            {
                MessageBox.Show("Not all fields are filled!");
                return;
            }
                

            string ssn = textBox_SSN_Trainee.Text;
            int locker = Convert.ToInt32(comboBox_Number.Text);

            int done = controllerObj.AssignLocker(ssn, locker);
            if (done == 0)
                MessageBox.Show("Assignment failed!");
            else 
                MessageBox.Show("Assignment completed!");

        }
        public void Clear()
        {
            textBox_Search_Trainee.Clear();
            textBox_SSN_Trainee.Clear();
            textBox_Name_Trainee.Clear();
            //dataGridView_Trainee.Rows.Clear();
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView_Trainee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            textBox_Name_Trainee.Text = dataGridView_Trainee.Rows[rowindex].Cells[1].Value.ToString();
            textBox_SSN_Trainee.Text = dataGridView_Trainee.Rows[rowindex].Cells[0].Value.ToString();
        }
    }
}
