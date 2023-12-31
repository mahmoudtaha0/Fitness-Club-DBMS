using DBapplication;
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
    public partial class Manage_Devices : Form
    {
        Controller controllerObj;
        public Manage_Devices()
        {
            InitializeComponent();
            all_visible(false);
            controllerObj = new Controller();

            DataTable dt = controllerObj.getAllTrainers();
            ((ListBox)devices_supervised_checklist).DataSource = dt;
            ((ListBox)devices_supervised_checklist).DisplayMember = "person_name";
            ((ListBox)devices_supervised_checklist).ValueMember = "ssn";
        }

        private void Manage_Devices_Load(object sender, EventArgs e)
        {

        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (name_combob.SelectedItem == null)
            {
                MessageBox.Show("Please select the Device");
                return;
            }
            int ret = controllerObj.deleteDevices((name_combob.Text).ToString());
            if (ret == 0)
            {
                MessageBox.Show("No rows are deleted");
            }
            else
            {
                MessageBox.Show("The row is deleted successfully!");
            }
            // To refresh the combobox after deleting
            DataTable dt = controllerObj.SelectDevicesNamesAndIds();
            name_combob.DataSource = dt;
            name_combob.ValueMember = "id";
            name_combob.DisplayMember = "device_name";
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.searchForDevices(device_name_tb.Text);
            resultsDataGrid.DataSource = dt;
            resultsDataGrid.Refresh();
            //search s = new search('D' , (name_combob.SelectedItem).ToString());
            //s.Show();
        }

        private void choose_button_Click(object sender, EventArgs e)
        {
            if (managing_devices_combob.SelectedItem == null)
            {
                MessageBox.Show("Please select the Functionality");
                return;
            }
            all_visible(false);

            string func = (managing_devices_combob.SelectedItem).ToString();

            device_name_tb.Visible = true;
            device_name_lbl.Visible = true;

            if (func == "Search for Device")
            {
                search_button.Visible = true;
                resultsDataGrid.Visible = true;
            }
            else if (func == "Add Device")
            {
                add_button.Visible = true;
                add_update_panel.Visible = true;
            }
            else if (func == "Update Device")
            {
                update_button.Visible = true;
                add_update_panel.Visible = true;
            }
            else if (func == "Remove Device")
            {
                remove_button.Visible = true;
                device_name_tb.Visible = false;
                name_combob.Visible = true;
                //devices name comboBox
                DataTable dt = controllerObj.SelectDevicesNamesAndIds();
                name_combob.DataSource = dt;
                name_combob.ValueMember = "id";
                name_combob.DisplayMember = "device_name";
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            string selectDateAsString = device_date_of_purchase_db.Value.ToString("yyyy-MM-dd");
            int ret=0;

            if (devices_supervised_checklist.CheckedItems.Count == 0)
            {
                MessageBox.Show("The device should be supervised by at least one trainer");
                return;
            }
            else
            {
                ret = controllerObj.addDevices(Convert.ToInt16(device_id_tb.Text), device_name_tb.Text,
                device_manufacturer_name_combob.Text, device_muscles_group_combob.Text, selectDateAsString);

                //If so, loop through all checked Trainers
                for (int i = 0; i < devices_supervised_checklist.CheckedItems.Count; i++)
                {
                    int ret2 = controllerObj.addSpecializedInTrainers(Convert.ToInt16(device_id_tb.Text), devices_supervised_checklist.CheckedItems[i].ToString());
                }

                //foreach (object itemChecked in devices_supervised_checklist.CheckedItems)
                //{
                //    DataRowView castedItem = itemChecked as DataRowView;
                //    string trainerSSN = castedItem["ssn"];
                //    int? id = castedItem["ID"];
                //}

                //for (int i = 0; i < devices_supervised_checklist.Items.Count; i++)
                //{
                //    if (devices_supervised_checklist.GetItemChecked(i) == true)
                //    {
                //       // MessageBox.Show("This is the value of ceckhed Item " + devices_supervised_checklist.Items[i].ToString());
                //        int ret2 = controllerObj.addSpecializedInTrainers(Convert.ToInt16(device_id_tb.Text), devices_supervised_checklist.Items[i].ToString());
                //    }

                //}
            }

            if (ret == 0)
            {
                MessageBox.Show("Couldn't Add! Make sure that ssn isn't included.");
            }
            else
            {
                MessageBox.Show("Added Successfuly!");
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            string selectDateAsString = device_date_of_purchase_db.Value.ToString("yyyy-MM-dd");

            int ret = controllerObj.updateDevices(Convert.ToInt16(device_id_tb.Text), device_name_tb.Text,
                device_manufacturer_name_combob.Text, device_muscles_group_combob.Text, selectDateAsString);

            if (ret == 0)
            {
                MessageBox.Show("Couldn't Update! Make sure that ssn isn't included.");
            }
            else
            {
                MessageBox.Show("Updated Successfuly!");
            }

            int ret2 = controllerObj.deleteAllSpecializedInTrainers(Convert.ToInt16(device_id_tb.Text));
            for (int i = 0; i < devices_supervised_checklist.CheckedItems.Count; i++)
            {
                int ret3 = controllerObj.addSpecializedInTrainers(Convert.ToInt16(device_id_tb.Text), devices_supervised_checklist.CheckedItems[i].ToString());
            }
        }

        private void all_visible (bool x)
        {
            add_button.Visible = x;
            update_button.Visible = x;
            search_button.Visible = x;
            remove_button.Visible = x;
            add_update_panel.Visible=x;
            device_name_lbl.Visible = x;
            device_name_tb.Visible=x;
            name_combob.Visible = x;
            resultsDataGrid.Visible = x;
        }
    }
}
