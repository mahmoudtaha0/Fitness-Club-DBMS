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
    public partial class Assign_Trainers : Form
    {
        Controller controllerObj;
        public Assign_Trainers()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox_Search_Trainee.Text;
            DataTable dt = controllerObj.SearchTrainee(keyword);
            dataGridView_Trainee.DataSource = dt;
        }
        
        private void textBox_Search_Trainer_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxName_Trainer.Text;
            DataTable dt = controllerObj.SearchTrainer(keyword);
            dataGridViewTrainer.DataSource = dt;
        }

        private void dataGridView_Trainee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            textBox_Name_Trainee.Text = dataGridView_Trainee.Rows[rowindex].Cells[1].Value.ToString();
            textBox_SSN_Trainee.Text = dataGridView_Trainee.Rows[rowindex].Cells[0].Value.ToString();
        }
        
        private void dataGridViewTrainer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            textBoxName_Trainer.Text = dataGridViewTrainer.Rows[rowindex].Cells[1].Value.ToString();
            textBox_SSN_Trainer.Text = dataGridViewTrainer.Rows[rowindex].Cells[0].Value.ToString();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox_Search_Trainee.Clear();
            textBox_Search_Trainer.Clear();
            textBox_SSN_Trainer.Clear();
            textBox_SSN_Trainee.Clear();
            textBoxName_Trainer.Clear();
            textBox_Name_Trainee.Clear();
            //dataGridViewTrainer.Rows.Clear();
            //dataGridView_Trainee.Rows.Clear();
        }

        private void btn_Assign_Click(object sender, EventArgs e)
        {
            if (textBox_SSN_Trainee.Text == " " || textBox_SSN_Trainer.Text == " ")
            {
                MessageBox.Show("Not all fields are filled!");
                return;
            }
   
            string traineessn = textBox_SSN_Trainee.Text;
            string trainerssn = textBox_SSN_Trainer.Text;

            int done = controllerObj.AssignTrainer(traineessn, trainerssn);
            if (done == 0)
                MessageBox.Show("Assignment Failed!");
            else 
                MessageBox.Show("Assignment Completed!");

        }

        private void Assign_Trainers_Load(object sender, EventArgs e)
        {
 
        }

        private void dataGridView_Trainee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


//TODO: add exit button
//TODO: figure out a neater way for sqldataadapter DONE
//TODO: assign query DONE
//TODO: ADD logo
