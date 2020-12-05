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
    public partial class GenerateBill : Form
    {
        
        public GenerateBill()
        {
            InitializeComponent();
        }

        private void GB_Load(object sender, EventArgs e)
        {
            this.Location = new Point(350, 170);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox4.Text!="")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select UserId,TotalMilkQuantity,TotalAmount,BDate from Bill where BId=" + textBox4.Text + ""; ;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                
                if(ds.Tables[0].Rows.Count!=0)
                {
                    textBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                    textBox2.Text = ds.Tables[0].Rows[0][1].ToString();
                    textBox3.Text = ds.Tables[0].Rows[0][2].ToString();
                    setDatagridView1(Int64.Parse(textBox4.Text));
                }
                else
                {
                    MessageBox.Show("No records exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Enter some data.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void setDatagridView1 (Int64 BId)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from  Bill where BId=" + BId + ""; 
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox4.Text!="" && textBox3.Text!="")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from  Bill where BId=" + textBox4.Text + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                if (ds.Tables[0].Rows.Count==0)
                {
                    
                }
                else
                {
                    MessageBox.Show("Payment of " + dateTimePicker1.Text +  " Done." , " Information ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
    }
}
