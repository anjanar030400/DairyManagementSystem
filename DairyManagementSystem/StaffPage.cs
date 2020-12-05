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
    public partial class StaffPage : Form
    {
        public StaffPage()
        {
            InitializeComponent();
        }

        private void mANAGESELLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSeller ms = new ManageSeller();
            ms.Show();
        }

        private void mANAGEMILKRATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MilkRate mm = new MilkRate();
            mm.Show();
        }

        private void mANAGEFEEDBACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteFeedback wfb = new WriteFeedback();
            wfb.Show();
        }

        private void mANAGESTAFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AST ast = new AST();
            ast.Show();
        }
    }
}
