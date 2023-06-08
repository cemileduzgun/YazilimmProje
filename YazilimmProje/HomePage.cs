using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazilimmProje
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ManageCategorıes manageCategorıes = new ManageCategorıes();
            manageCategorıes.Show();  // form2 göster diyoruz
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ManageProducks manageProducks = new ManageProducks();
            manageProducks.Show();  // form2 göster diyoruz
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ManageCustomers manageCustomers = new ManageCustomers();
            manageCustomers.Show();  // form2 göster diyoruz
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser();  
            manageUser.Show(); 
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ManageOrders manageOrders  =    new ManageOrders(); 
            manageOrders.Show();
            this.Hide();
        }
    }
}
