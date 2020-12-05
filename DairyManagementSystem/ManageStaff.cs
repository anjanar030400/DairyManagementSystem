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
    public partial class ManageStaff : Form
    {
        public ManageStaff()
        {
            InitializeComponent();
        }

        private void ManageStaff_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from ManageStaff";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MStdataGridView.DataSource = ds.Tables[0];
        }

        private void stbtn_Click(object sender, EventArgs e)
        {
            if (sctxt.Text != "" && sntxt.Text != "" && satxt.Text != "" && gcomboBox.Text != "" && sstxt.Text!="" && swtxt.Text!="" && sptxt.Text != "")
            {

                Int64 Staff_Code = Int64.Parse(sctxt.Text);
                String Staff_Name = sntxt.Text;
                String Staff_Address = satxt.Text;
                String Gender = gcomboBox.Text;
                Int64 Salary = Int64.Parse(sstxt.Text);
                String Staff_Work = swtxt.Text;
                String Register_Date = dateTimePicker1.Text;
                Int64 Phone_No = Int64.Parse(sptxt.Text);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into ManageStaff(Staff_Code,Staff_Name,Staff_Address,Gender,Salary,Staff_Work,Register_Date,Phone_No) values(" + Staff_Code + ",'" + Staff_Name + "','" + Staff_Address + "','" + Gender + "',"+Salary+",'"+Staff_Work+"','" + Register_Date + "'," + Phone_No + ")";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sctxt.Clear();
                sntxt.Clear();
                satxt.Clear();
                sptxt.Clear();

            }
            else
            {
                MessageBox.Show("Empty Field not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtbtn_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Data will be deleted.Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from ManageStaff where Staff_Code=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }
        int Staff_Code;
        Int64 rowid;
        private void MStdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MStdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Staff_Code = int.Parse(MStdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from ManageStaff where Staff_Code=" + Staff_Code + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }
    }
}
