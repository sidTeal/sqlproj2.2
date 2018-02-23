using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tisdale_Project_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string[] employeeArray = DatabaseManager.getEmployeeNames();
            cbViewEmployee.DataSource = employeeArray;

            string[] customerArray = DatabaseManager.getCustomerNames();
            cbViewCustomer.DataSource = customerArray;

            
        }
        
        private void lbEmployeeDateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlModifyCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bnAddCustomer_Click(object sender, EventArgs e)
        {
            
            string[] employeeArray = DatabaseManager.getEmployeeNames();
            string out0 = employeeArray[0];
            string out1 = employeeArray[1];

            tbCustomerFirstName.Text = out0;
            tbCustomerLastName.Text = out1;
        }

        private void cbViewCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = cbViewCustomer.Text;
            if (selection != "")
            {
                string[] name = new string[1];

                selection = selection.Replace(",", "");
                name = selection.Split(' ');
                //name[0] = last name
                //name[1] = first name

                dgvViewCustomer.DataSource = DatabaseManager.viewCustomer(name[0], name[1]);
                
            }


        }

        private void cbViewEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
