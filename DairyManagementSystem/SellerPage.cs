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
    public partial class SellerPage : Form
    {
        public SellerPage()
        {
            InitializeComponent();
        }

        private void SellerPage_Load(object sender, EventArgs e)
        {

        }

        private void mANAGEMILKRATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MilkRate mr = new MilkRate();
            mr.Show();
        }

        private void gIVEFEEDBACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteFeedback wfb = new WriteFeedback();
            wfb.Show();
        }

        private void bILLDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BD bd = new BD();
            bd.Show();
        }

        private void vIEWPROFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ASL asl = new ASL();
            asl.Show();
        }
    }
}
