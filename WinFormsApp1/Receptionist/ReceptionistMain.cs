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
using WinFormsApp1.Manager;
using WinFormsApp1.Receptionist;

namespace Receptionist
{
    public partial class ReceptionistMain : Form
    {

        bool managePanelCollapsed;
        bool viewPanelCollapsed;

        Controller controller;
        Welcome welcome;
        string userSSN;

        public ReceptionistMain(string ssn, Welcome wel)
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
            DataTable dt = controller.searchForReceptionists(ssn);
            usernameLabel.Text = (string)dt.Rows[0][1];     // username

            loadedFormPanel.Controls.Clear();
            loadedFormPanel.Enabled = false;
        }

        private void trainees_button_Click(object sender, EventArgs e)
        {

            managePanelAniamtion.Enabled = true;
            formName.Text = "Trainees";

            //manage m = new manage();
            //m.Show();
        }
        private void membershipsButton_Click(object sender, EventArgs e)
        {

            formName.Text = "Trainees";

            // TODO: Load receptionist form

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            ManageMemberships manageMemberships = new ManageMemberships()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            manageMemberships.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(manageMemberships);
            manageMemberships.Show();

        }

        private void invitationsButton_Click(object sender, EventArgs e)
        {

            formName.Text = "Trainees";

            // Load appropriate form

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            RegisterInvitation registerInvitation = new RegisterInvitation()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            registerInvitation.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(registerInvitation);
            registerInvitation.Show();

        }

        private void programsButton_Click(object sender, EventArgs e)
        {

            formName.Text = "Trainees";

            // Load appropriate form

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            Update_Program update_Program = new Update_Program()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            update_Program.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(update_Program);
            update_Program.Show();

        }

        private void lockersButton_Click(object sender, EventArgs e)
        {

            formName.Text = "Trainees";

            // Load appropriate form

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();

            Locker locker = new Locker()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            locker.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(locker);
            locker.Show();

        }


        private void request_button_Click(object sender, EventArgs e)
        {


            //'R' To respond 
            //'S' To show all holidays requests

            formName.Text = "Requests";
            // Load appropriate form

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            RequestHoliday requestHoliday = new RequestHoliday()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            requestHoliday.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(requestHoliday);
            requestHoliday.Show();

            //holidays h = new holidays( 'R' );
            //h.Show();
        }

        private void trainers_button_Click(object sender, EventArgs e)
        {

            viewPanelAniamtion.Enabled = true;
            formName.Text = "Trainers";

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            formName.Text = "Trainers";

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            Login_Trainers login_Trainers = new Login_Trainers()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            login_Trainers.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(login_Trainers);
            login_Trainers.Show();

        }

        private void assignTrainersButton_Click(object sender, EventArgs e)
        {

            formName.Text = "Trainers";

            // Remove pass form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            Assign_Trainers assign_Trainers = new Assign_Trainers()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            assign_Trainers.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(assign_Trainers);
            assign_Trainers.Show();

        }

        private void financeButton_Click(object sender, EventArgs e)
        {

            formName.Text = "Finance";

            // Load appropriate form
            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            AddTransaction addTransaction = new AddTransaction()
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            addTransaction.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(addTransaction);
            addTransaction.Show();
        }

        private void traineesPanelAniamtion_Tick(object sender, EventArgs e)
        {
            // if collapsed maximize
            if (managePanelCollapsed)
            {

                traineesPanel.Height += 10;
                if (traineesPanel.Size.Height == traineesPanel.MaximumSize.Height)
                {
                    managePanelCollapsed = false;
                    managePanelAniamtion.Enabled = false;
                }
            }
            else
            {

                traineesPanel.Height -= 10;
                if (traineesPanel.Size.Height == traineesPanel.MinimumSize.Height)
                {
                    managePanelCollapsed = true;
                    managePanelAniamtion.Enabled = false;
                }

            }

        }

        private void trainersPanelAniamtion_Tick(object sender, EventArgs e)
        {

            // if collapsed maximize
            if (viewPanelCollapsed)
            {

                trainersPanel.Height += 10;
                if (trainersPanel.Size.Height == trainersPanel.MaximumSize.Height)
                {
                    viewPanelCollapsed = false;
                    viewPanelAniamtion.Enabled = false;
                }
            }
            else
            {

                trainersPanel.Height -= 10;
                if (trainersPanel.Size.Height == trainersPanel.MinimumSize.Height)
                {
                    viewPanelCollapsed = true;
                    viewPanelAniamtion.Enabled = false;
                }

            }

        }

        private void ReceptionistMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            welcome.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {

            // Load appropriate form

            loadedFormPanel.Enabled = true;
            loadedFormPanel.Controls.Clear();
            settings_receptionist settingsFrom = new settings_receptionist(this, welcome, userSSN)
            { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            settingsFrom.FormBorderStyle = FormBorderStyle.None;
            loadedFormPanel.Controls.Add(settingsFrom);
            settingsFrom.Show();

        }
    }
}