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
    public partial class Update_Program : Form
    {
        Controller controllerObj;
        public Update_Program()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectAllPrograms();
            comboBox_ProgName.DataSource = dt;
            comboBox_ProgName.DisplayMember = "name";
            comboBox_ProgName.ValueMember = "id";
        }


        private void comboBox_ProgName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Assign_Click(object sender, EventArgs e)
        {
            if (comboBox_ProgName.Text == " " || textBox_SSN_Trainee.Text == " ")
            {
                MessageBox.Show("Not all fields are filled!");
                return;
            }

            int id = Convert.ToInt32(comboBox_ProgName.SelectedValue.ToString());
            string ssn = textBox_SSN_Trainee.Text;
            int done = controllerObj.UpdateProgram(ssn, id);
            if (done == 0)
                MessageBox.Show("Update failed!");
            else
                MessageBox.Show("Update completed!");
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (comboBox_ProgName.Text == " ")
            {
                MessageBox.Show("Not all fields are filled!");
                return;
            }
            string prog = comboBox_ProgName.Text;
            DataTable dt = controllerObj.ViewProgram(prog);
            dataGridView_Prog.DataSource = dt;
        }

        private void textBox_Search_Trainee_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox_Search_Trainee.Text;
            DataTable dt = controllerObj.SearchTrainee(keyword);
            dataGridViewTrainee.DataSource = dt;
        }

        private void dataGridViewTrainee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            textBoxName_Trainee.Text = dataGridViewTrainee.Rows[rowindex].Cells[1].Value.ToString();
            textBox_SSN_Trainee.Text = dataGridViewTrainee.Rows[rowindex].Cells[0].Value.ToString();
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            dataGridViewTrainee.Rows.Clear();
            textBoxName_Trainee.Clear();
            textBox_Search_Trainee.Clear();
            textBox_SSN_Trainee.Clear();
        }
    }
}
