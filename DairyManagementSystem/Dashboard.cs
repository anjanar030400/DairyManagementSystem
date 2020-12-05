using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit ?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login abs = new Login();
            abs.Show();
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Seller das = new Seller();
            das.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff bas = new Staff();
            bas.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Us aus = new About_Us();
            aus.Show();
        }

        private void servicesAndFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Services_and_Facility sf = new Services_and_Facility();
            sf.Show();
        }

        private void milkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Milk_Storage ms = new Milk_Storage();
            ms.Show();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contact_us cu = new Contact_us();
            cu.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void milkRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MilkRate mr = new MilkRate();
            mr.Show();
        }
    }
}
