using Receptionist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Receptionist
{
    public partial class settings_receptionist : Form
    {

        Controller controller;

        ReceptionistMain receptionistMain;
        Welcome welcome;
        string manSSN;

        public settings_receptionist(ReceptionistMain receptionist, Welcome wel, string ssn)
        {
            InitializeComponent();

            controller = new Controller();

            receptionistMain = receptionist;
            welcome = wel;
            manSSN = ssn;

        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {

            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            var inputPassword = currentPasswordTb.Text;
            string encryptedPassword = EncryptionClass.EncryptString(key, inputPassword);

            DataTable dt = controller.getReceptionistsEmailAndPassword(manSSN);

            string email = (string)dt.Rows[0][0];
            string password = (string)dt.Rows[0][1];

            dt = controller.loginReceptionist(email, password);
            if (dt == null)
            {
                MessageBox.Show("Something is wrong... Try again later");
            }
            else
            {

                if (encryptedPassword != password)
                {
                    MessageBox.Show("Incorrect current password... Please try again.");
                }
                else
                {

                    if (newPasswordTb.Text != repNewPasswordTb.Text)
                    {
                        MessageBox.Show("Password mismatch... Make sure you enter the same password.");
                    }
                    else
                    {

                        encryptedPassword = EncryptionClass.EncryptString(key, newPasswordTb.Text);

                        int ret = controller.updateReceptionistPassword(manSSN, encryptedPassword);

                        if (ret == 0)
                        {
                            MessageBox.Show("Couldn't change password");
                        }
                        else
                        {
                            MessageBox.Show("Password changed.");
                        }

                    }

                }

            }


        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

            this.Close();
            receptionistMain.Close();
            welcome.Show();

        }
    }
}
