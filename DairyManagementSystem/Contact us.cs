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
    public partial class Contact_us : Form
    {
        public Contact_us()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cntxt.Text != "" && cetxt.Text != "" && cmtxt.Text != "")
            {

                String Yourname = cntxt.Text;
                String Youremail = cetxt.Text;
                String Yourmessage = cmtxt.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into ContactTable (Yourname,Youremail,Yourmessage) values('" + Yourname + "','" + Youremail + "','" + Yourmessage + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cntxt.Clear();
                cetxt.Clear();
                cmtxt.Clear();

            }
            else
            {
                MessageBox.Show("Empty Field not allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
