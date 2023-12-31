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
    public partial class Login_Trainers : Form
    {
        Controller controllerObj;
        public Login_Trainers()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        /*private void Login_Trainers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gymDataSet.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.gymDataSet.Attendance);

        }*/

        private void button_Clear_Click(object sender, EventArgs e)
        {
            //dataGridViewTrainer.Rows.Clear();
            textBoxName_Trainer.Clear();
            textBox_Search_Trainer.Clear();
            textBox_SSN_Trainer.Clear();
        }

        private void textBox_Search_Trainer_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox_Search_Trainer.Text;
            DataTable dt = controllerObj.SearchTrainer(keyword);
            dataGridViewTrainer.DataSource = dt;
        }

        private void dataGridViewTrainer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            textBoxName_Trainer.Text = dataGridViewTrainer.Rows[rowindex].Cells[1].Value.ToString();
            textBox_SSN_Trainer.Text = dataGridViewTrainer.Rows[rowindex].Cells[0].Value.ToString();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (comboBox_Type.Text == " " || textBox_SSN_Trainer.Text == " ")
            {
                MessageBox.Show("Not all fields are filled!");
                return;
            }

            string type = comboBox_Type.Text;
            string ssn = textBox_SSN_Trainer.Text;
            string date = dateTimePicker2.Text;
            int done = controllerObj.Attended(ssn, date, type);
            if (done == 0)
                MessageBox.Show("Login failed!");
            else
                MessageBox.Show("Login completed!");
        }
    }
}
