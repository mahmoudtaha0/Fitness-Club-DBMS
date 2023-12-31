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
    public partial class managing_managers : Form
    {
        Controller controller;
        public managing_managers()
        {
            InitializeComponent();
            controller = new Controller();

            all_visible(false);
        }

        private void managing_managers_Load(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            DataTable dt = controller.searchForManagersWithName(employee_name_tb.Text);
            resultsDataGrid.DataSource = dt;
            resultsDataGrid.Refresh();
            //search s = new search('M', (name_combob.SelectedItem).ToString());
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

                DataTable dt = controller.getAllManagers();
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


        private void update_button_Click_1(object sender, EventArgs e)
        {
            string selectDateAsString = employee_birth_date_db.Value.ToString("yyyy-MM-dd");

            int ret = controller.updateManagers(employee_SSN_tb.Text, employee_name_tb.Text,
                employee_address_tb.Text, employee_gender_combob.Text, employee_phone_number_tb.Text,
                selectDateAsString, manager_email_tb.Text, manager_password_tb.Text);

            if (ret == 0)
            {
                MessageBox.Show("Couldn't Update! Make sure that ssn isn't included.");
            }
            else
            {
                MessageBox.Show("Updated Successfuly!");
            }
        }

        private void remove_button_Click_1(object sender, EventArgs e)
        {
            int ret = controller.deleteManagers(Convert.ToString(name_combob.SelectedValue));

            if (ret == 0)
            {
                MessageBox.Show("No rows are deleted");
            }
            else
            {
                MessageBox.Show("The row is deleted successfully!");
            }
            //To refresh it
            DataTable dt = controller.getAllManagers();
            name_combob.DataSource = dt;
            name_combob.DisplayMember = "person_name";
            name_combob.ValueMember = "ssn";
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string selectDateAsString = employee_birth_date_db.Value.ToString("yyyy-MM-dd");

            int ret = controller.addManagers(employee_SSN_tb.Text, employee_name_tb.Text,
                employee_address_tb.Text, employee_gender_combob.Text, employee_phone_number_tb.Text,
                selectDateAsString, manager_email_tb.Text, manager_password_tb.Text);

            if (ret == 0)
            {
                MessageBox.Show("Couldn't Add! Make sure that ssn isn't included.");
            }
            else
            {
                MessageBox.Show("Added Successfuly!");
            }
        }
    }
}
