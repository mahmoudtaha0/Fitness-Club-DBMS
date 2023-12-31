using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Manager;

namespace WinFormsApp1
{
    public partial class ManagerMain : Form
    {

        bool managePanelCollapsed;
        bool viewPanelCollapsed;

        Controller controller;
        Welcome welcome;
        string userSSN;

        public ManagerMain(string ssn, Welcome wel)
        {
            InitializeComponent();
            managePanelCollapsed = true;
            managePanelAniamtion.Enabled = false;
            viewPanelCollapsed = true;
            viewPanelAniamtion.Enabled = false;

            controller = new Controller();
            welcome = wel;
            userSSN = ssn;

            // load account name
            DataTable dt = controller.searchForManagers(ssn);
            usernameLabel.Text = (string)dt.Rows[0][1];     // username

            loadedFormPanel.Controls.Clear();
            loadedFormPanel.Enabled = false;


        }

        private void manage_button_Click(object sender, EventArgs e)
        {
        
            managePanelAniamtion.Enabled = true;
            formName.Text = "Manage";
            
        }
        private void receptionistButton_Click(object sender, EventArgs e)
        {

            // TODO: Load receptionist form

            formName.Text = "Manage";

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            managing_receptionist managing_Receptionist = new managing_receptionist() 
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            managing_Receptionist.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(managing_Receptionist);
            managing_Receptionist.Show();

        }

        private void trainersButton_Click(object sender, EventArgs e)
        {

            // Load appropriate form

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            managing_trainers managing_Trainers = new managing_trainers()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            managing_Trainers.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(managing_Trainers);
            managing_Trainers.Show();

        }

        private void managersButton_Click(object sender, EventArgs e)
        {

            formName.Text = "Manage";

            // Load appropriate form

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            managing_managers managing_managers = new managing_managers()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            managing_managers.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(managing_managers);
            managing_managers.Show();

        }

        private void devicesButton_Click(object sender, EventArgs e)
        {

            formName.Text = "Manage";

            // Load appropriate form

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            
             Manage_Devices manage_Devices = new Manage_Devices()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            manage_Devices.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(manage_Devices);
            manage_Devices.Show();

        }

        private void salariesButton_Click(object sender, EventArgs e)
        {

            formName.Text = "Manage";

            // Load appropriate form

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            Manage_Salaries manage_Salaries = new Manage_Salaries()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            manage_Salaries.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(manage_Salaries);
            manage_Salaries.Show();

        }

        private void respond_button_Click(object sender, EventArgs e)
        {
            //'R' To respond 
            //'S' To show all holidays requests

            formName.Text = "Respond";
            // Load appropriate form

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            holidays respondHolidays = new holidays()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            respondHolidays.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(respondHolidays);
            respondHolidays.Show();

        }

        private void view_button_Click(object sender, EventArgs e)
        {

            viewPanelAniamtion.Enabled = true;
            formName.Text = "View";
            
        }

        private void attendanceButton_Click(object sender, EventArgs e)
        {

            formName.Text = "View";

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            attendance attendanceFrom = new attendance()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            attendanceFrom.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(attendanceFrom);
            attendanceFrom.Show();

        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {

            formName.Text = "View";

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            statistics statisticsFrom = new statistics()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            statisticsFrom.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(statisticsFrom);
            statisticsFrom.Show();

        }

        private void financeButton_Click(object sender, EventArgs e)
        {

            formName.Text = "Finance";
            // Load appropriate form

            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            finance financeFrom = new finance()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            financeFrom.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(financeFrom);
            financeFrom.Show();

        }

        private void managePanelAniamtion_Tick(object sender, EventArgs e)
        {
            // if collapsed maximize
            if (managePanelCollapsed)
            {

                managePanel.Height += 10;
                if (managePanel.Size.Height == managePanel.MaximumSize.Height)
                {
                    managePanelCollapsed = false;
                    managePanelAniamtion.Enabled = false;
                }
            }
            else
            {

                managePanel.Height -= 10;
                if (managePanel.Size.Height == managePanel.MinimumSize.Height)
                {
                    managePanelCollapsed = true;
                    managePanelAniamtion.Enabled = false;
                }

            }

        }

        private void viewPanelAniamtion_Tick(object sender, EventArgs e)
        {

            // if collapsed maximize
            if (viewPanelCollapsed)
            {

                viewPanel.Height += 10;
                if (viewPanel.Size.Height == viewPanel.MaximumSize.Height)
                {
                    viewPanelCollapsed = false;
                    viewPanelAniamtion.Enabled = false;
                }
            }
            else
            {

                viewPanel.Height -= 10;
                if (viewPanel.Size.Height == viewPanel.MinimumSize.Height)
                {
                    viewPanelCollapsed = true;
                    viewPanelAniamtion.Enabled = false;
                }

            }

        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

            // Load appropriate form

            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            settings settingsFrom = new settings(this, welcome, userSSN)
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            settingsFrom.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(settingsFrom);
            settingsFrom.Show();

        }

        private void ManagerMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            welcome.Show();
        }
    }
}
