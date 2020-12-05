using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DairyManagementSystem
{
    public partial class WriteFeedback : Form
    {
        public WriteFeedback()
        {
            InitializeComponent();
        }

        private void smbtn_Click(object sender, EventArgs e)
        {
            if (fntxt.Text != "" && fetxt.Text != "" && fmtxt.Text != "")
            {

                String Name = fntxt.Text;
                String Email_Id = fetxt.Text;
                String Feedback = fmtxt.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into Feedback (Name,Email_Id,Feedback) values('"  +Name+ "','" + Email_Id + "','" + Feedback + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fntxt.Clear();
                fetxt.Clear();
                fmtxt.Clear();

            }
            else
            {
                MessageBox.Show("Empty Field not allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
