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
    public partial class Admin_Page : Form
    {
        public Admin_Page()
        {
            InitializeComponent();
        }

        private void mANAGEMILKRATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMilk mr = new ManageMilk();
            mr.Show();
        }

        private void mANAGESELLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSeller ms = new ManageSeller();
            ms.Show();
        }

        private void mANAGESTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStaff mst = new ManageStaff();
            mst.Show();
        }

        private void mANAGEFEEDBACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Feedback fb = new Feedback();
            fb.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void generateBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateBill  gb = new GenerateBill();
            gb.Show();
        }
    }
}
