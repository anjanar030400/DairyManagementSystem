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
    public partial class ManageMilk : Form
    {
        public ManageMilk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ftxt.Text != "" && btxt.Text != "" && ctxt.Text != "")
            {

                Int64 fat_percentage = Int64.Parse(ftxt.Text);
                Int64 buffalosmilkrate_rupees = Int64.Parse(btxt.Text);
                Int64 cowsmilkrate_rupees = Int64.Parse(ctxt.Text);
                String updated_date = dateTimePicker1.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source =(LocalDB)\\MSSQLLocalDB;Initial Catalog =Dairydb;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "insert into Milkrate(fat_percentage,buffalosmilkrate_rupees,cowsmilkrate_rupees,updated_date) values(" + fat_percentage + "," + buffalosmilkrate_rupees + "," + cowsmilkrate_rupees + ",'" + updated_date + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ftxt.Clear();
                btxt.Clear();
                ctxt.Clear();

            }
            else
            {
                MessageBox.Show("Empty Field not allowed","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will delete your unsaved data.", "Are you sure ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
            }
            
        }
    }
}