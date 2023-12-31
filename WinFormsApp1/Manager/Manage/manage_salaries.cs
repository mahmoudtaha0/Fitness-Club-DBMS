using Microsoft.VisualBasic;
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
    public partial class Manage_Salaries : Form
    {
        Controller controllerObj;

        public Manage_Salaries()
        {
            InitializeComponent();
            controllerObj = new Controller();

            all_visible(false);
        }

        private void Manage_Salaries_Load(object sender, EventArgs e)
        {
        }

        private void choose_button_Click(object sender, EventArgs e)
        {
            if (managing_salaries_combob.SelectedItem == null)
            {
                MessageBox.Show("Please select the Functionality");
                return;
            }
            all_visible(false);

            string func = (managing_salaries_combob.SelectedItem).ToString();

            if (func == "Search for an Employee Salary In Certain Month")
            {
                search_button.Visible = true;
                panel_date.Visible = true;
                panel_ssn.Visible = true;
                all_salaries_dgv.Visible = true;
            }
            else if (func == "Add Salary")
            {
                add_button.Visible = true;
                add_update_salary_panel.Visible = true;
                panel_date.Visible = true;
                panel_ssn.Visible = true;
            }
            else if (func == "Update Salary")
            {
                update_button.Visible = true;
                add_update_salary_panel.Visible = true;
                panel_date.Visible = true;
                panel_ssn.Visible = true;
            }
            else if (func == "Search for All Employees Salaries In Certain Month")
            {
                search_button.Visible = true;
                all_salaries_dgv.Visible = true;
                panel_date.Visible = true;
            }
            else if (func == "Search for an Employee All Salaries")
            {
                search_button.Visible = true;
                all_salaries_dgv.Visible = true;
                panel_ssn.Visible = true;
            }
        }
        private void all_visible(bool x)
        {
            add_button.Visible = x;
            update_button.Visible = x;
            search_button.Visible = x;
            add_update_salary_panel.Visible = x;
            panel_date.Visible = x;
            panel_ssn.Visible = x;
            all_salaries_dgv.Visible = x;
        }

        private void search_button_Click_1(object sender, EventArgs e)
        {
            string func = (managing_salaries_combob.SelectedItem).ToString();
            string selectDateAsString = salary_date_db.Value.ToString("yyyy-MM-dd");

            if (func == "Search for an Employee Salary In Certain Month")
            {
                DataTable dt = controllerObj.searchForAnEmployeeSalaryInCertainMonth(salary_SSN_db.Text, selectDateAsString);
                all_salaries_dgv.DataSource = dt;
                all_salaries_dgv.Refresh();
            }
            else if (func == "Search for All Employees Salaries In Certain Month")
            {
                DataTable dt = controllerObj.searchForAllEmployeesSalariesInCertainMonth(selectDateAsString);
                all_salaries_dgv.DataSource = dt;
                all_salaries_dgv.Refresh();
            }
            else if (func == "Search for an Employee All Salaries")
            {
                DataTable dt = controllerObj.searchForAnEmployeeSalaries(salary_SSN_db.Text);
                all_salaries_dgv.DataSource = dt;
                all_salaries_dgv.Refresh();
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string selectDateAsString = salary_date_db.Value.ToString("yyyy-MM-dd");

            int ret = controllerObj.addSalary(salary_SSN_db.Text, selectDateAsString,
                Convert.ToInt16(salary_gross_db.Text), Convert.ToInt16(salary_taxes_db.Text), Convert.ToInt16(salary_bonus_db.Text), Convert.ToInt16(salary_penalty_db.Text));

            if (ret == 0)
            {
                MessageBox.Show("Couldn't Add salary");
            }
            else
            {
                MessageBox.Show("Added Successfuly!");
            }
        }

        private void update_button_Click_1(object sender, EventArgs e)
        {
            string selectDateAsString = salary_date_db.Value.ToString("yyyy-MM-dd");

            int ret = controllerObj.updateSalary(salary_SSN_db.Text, selectDateAsString,
                Convert.ToInt16(salary_gross_db.Text), Convert.ToInt16(salary_taxes_db.Text), Convert.ToInt16(salary_bonus_db.Text), Convert.ToInt16(salary_penalty_db.Text));
            if (ret == 0)
            {
                MessageBox.Show("Couldn't update salary");
            }
            else
            {
                MessageBox.Show("updated Successfuly!");
            }
        }
    }

        
}
