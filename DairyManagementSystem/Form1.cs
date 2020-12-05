using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DairyManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserIdTxt_MouseEnter(object sender, EventArgs e)
        {
            if(UserIdTxt.Text=="User Id")
            {
                UserIdTxt.Clear();
            }
        }

        private void PassTxt_MouseClick(object sender, MouseEventArgs e)
        {
            if(PassTxt.Text=="Password")
            {
                PassTxt.Clear();
                PassTxt.PasswordChar = '*';
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from LoginTable where UserId ='" + UserIdTxt.Text + "' and Pass='" + PassTxt.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count!=0)
            {
                this.Hide();
                Dashboard dsa = new Dashboard();
                dsa.Show();
            }
            else
            {
                MessageBox.Show("Wrong User Id or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
