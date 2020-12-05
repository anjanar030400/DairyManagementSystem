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
    public partial class ManageSeller : Form
    {
        public ManageSeller()
        {
            InitializeComponent();
        }

        

       

        private void ManageSeller_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from ManageSeller";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MSdataGridView.DataSource = ds.Tables[0];
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        int Seller_Code;
        Int64 rowid;
        private void MSdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MSdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Seller_Code = int.Parse(MSdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from ManageSeller where Seller_Code=" + Seller_Code + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            
        }

        private void sbutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text!="" && textBox5.Text!="")
            {

                Int64 Seller_Code = Int64.Parse(textBox1.Text);
                String Seller_Name = textBox2.Text;
                String Seller_Address = textBox3.Text;
                String Animal_Cattle = comboBox1.Text;
                String Register_Date = dateTimePicker1.Text;
                Int64 Sell_Milk = Int64.Parse(textBox5.Text);
               

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into ManageSeller(Seller_Code,Seller_Name,Seller_Address,Animal_Cattle,Register_Date,Sell_Milk) values(" + Seller_Code + ",'" + Seller_Name + "','" + Seller_Address + "','"+Animal_Cattle+"','" + Register_Date + "',"+Sell_Milk+")";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();

            }
            else
            {
                MessageBox.Show("Empty Field not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be deleted.Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {



                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from ManageSeller where Seller_Code=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void rbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from ManageSeller";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }
    }

       
    }
