using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string st = @"Server =LAPTOP-7K27LUL2;Initial Catalog=QuanLySinhVien;integrated security=True";
        private void btnconnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(st);
                conn.Open();
                MessageBox.Show("Da ket noi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDisconect_Click(object sender, EventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Da dong");
            }
        }

        private void btnDemsv_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select count (*) form SinhVien";
            cmd.Connection = conn;
            object ob = cmd.ExecuteScalar();
            int n = (int)ob;
            MessageBox.Show($"Có {n} Sinh Vien");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select count(*) form SinhVien where StudentID =@ma";
            cmd.Connection = conn;
            object ob = cmd.ExecuteScalar();
        }
    }
}
