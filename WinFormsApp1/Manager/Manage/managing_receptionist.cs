using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class managing_receptionist : Form
    {
        Controller controller;

        public managing_receptionist()
        {
            InitializeComponent();
            controller = new Controller();

            all_visible(false);
        }

        private void search_button_Click(object sender, EventArgs e)
        {

            DataTable dt = controller.searchForReceptionists(employee_name_tb.Text);
            resultsDataGrid.DataSource = dt;
            resultsDataGrid.Refresh();

            //search s = new search('R', "Receptionist");
            //s.Show();
        }

        private void choose_button_Click(object sender, EventArgs e)
        {
            if (managing_employee_functionality_combob.SelectedItem == null)
            {
                MessageBox.Show("Please select the Functionality and Type");
                return;
            }
            all_visible(false);

            string func = (managing_employee_functionality_combob.SelectedItem).ToString();

            employee_name_tb.Visible = true;
            employee_name_lbl.Visible = true;

            if (func == "Search")
            {
                search_button.Visible = true;
                resultsDataGrid.Visible = true;
            }
            else if (func == "Add")
            {
                add_button.Visible = true;
                add_update_panel.Visible = true;
            }
            else if (func == "Update")
            {
                update_button.Visible = true;
                add_update_panel.Visible = true;
            }
            else if (func == "Remove")
            {
                remove_button.Visible = true;
                employee_name_tb.Visible = false;
                name_combob.Visible = true;

                DataTable dt = controller.getAllReceptionists();
                name_combob.DataSource = dt;
                name_combob.DisplayMember = "person_name";
                name_combob.ValueMember = "ssn";
            }
        }
        private void all_visible(bool x)
        {
            add_button.Visible = x;
            update_button.Visible = x;
            search_button.Visible = x;
            remove_button.Visible = x;
            add_update_panel.Visible = x;
            employee_name_lbl.Visible = x;
            employee_name_tb.Visible = x;
            name_combob.Visible = x;
            resultsDataGrid.Visible = x;
        }

        private void add_button_Click(object sender, EventArgs e)
        {

            string selectDateAsString = employee_birth_date_db.Value.ToString("yyyy-MM-dd");

            int ret = controller.addReceptionists(employee_SSN_tb.Text, employee_name_tb.Text,
                employee_address_tb.Text, employee_gender_cb.Text, employee_phone_number_tb.Text,
                selectDateAsString, managerSSN_tb.Text,
                receptionist_email_tb.Text, receptionist_password_tb.Text);

            if (ret == 0)
            {
                MessageBox.Show("Couldn't Add! Make sure that ssn isn't included.");
            }
            else
            {
                MessageBox.Show("Added Successfuly!");
            }

            string[] lines = receptionist_skills_tb.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            char[] delimiterChars = { ',', '.', ':', '\t' };

            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(delimiterChars);
                for (int j = 0; j < words.Length; j++)
                {
                    int ret2 = controller.addSkills(employee_SSN_tb.Text, words[j]);
                }
            }

        }

        private void update_button_Click(object sender, EventArgs e)
        {

            string selectDateAsString = employee_birth_date_db.Value.ToString("yyyy-MM-dd");

            int ret = controller.updateReceptionists(employee_SSN_tb.Text, employee_name_tb.Text,
                employee_address_tb.Text, employee_gender_cb.Text, employee_phone_number_tb.Text,
                selectDateAsString, managerSSN_tb.Text,
                receptionist_email_tb.Text, receptionist_password_tb.Text);

            if (ret == 0)
            {
                MessageBox.Show("Couldn't Update! Make sure that ssn isn't included.");
            }
            else
            {
                MessageBox.Show("Updated Successfuly!");
            }

            //Delete the old certificates
            int ret1 = controller.deleteAllSkillsForReceptionist(employee_SSN_tb.Text);

            //Add the new Certificates
            string[] lines = receptionist_skills_tb.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            char[] delimiterChars = { ',', '.', ':', '\t' };

            for (int i = 0; i < lines.Length; i++)
            {
                string[] words = lines[i].Split(delimiterChars);
                for (int j = 0; j < words.Length; j++)
                {
                    int ret2 = controller.addSkills(employee_SSN_tb.Text, words[j]);
                }
            }
        }

        private void remove_button_Click(object sender, EventArgs e)
        {

            int ret = controller.deleteReceptionists(Convert.ToString(name_combob.SelectedValue));

            if (ret == 0)
            {
                MessageBox.Show("No rows are deleted");
            }
            else
            {
                MessageBox.Show("The row is deleted successfully!");
            }
            //To refresh it
            DataTable dt = controller.getAllReceptionists();
            name_combob.DataSource = dt;
            name_combob.DisplayMember = "person_name";
            name_combob.ValueMember = "ssn";
        }
    }
}
