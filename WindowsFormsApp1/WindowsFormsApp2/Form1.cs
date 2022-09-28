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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = null;
        string str = @"Server =LAPTOP-7K27LUL2;Initial Catalog=QuanLySinhVien;integrated security=True";

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnn == null) cnn = new SqlConnection(str);
            if (cnn.State == ConnectionState.Closed) cnn.Open();
            SqlCommand cmd = new SqlCommand(str);
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into SinhVien(StudentID, FullName, Averagescore, FacultyID"values @ma ,@ten, @diem, @makhoa)";
            cmd.Connection = cnn;
            cmd.Parameters.Add("@ma", SqlDbType.NVarChar).Value = textBox1;
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = textBox2;
            cmd.Parameters.Add("@diem", SqlDbType.NVarChar).Value = textBox3;
            cmd.Parameters.Add("@makhoa", SqlDbType.NVarChar).Value = textBox4;
            int result = cmd.ExecuteNonQuery();
            //if (result > 0)
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                cnn = new SqlConnection(str);
                cnn.Open();
                MessageBox.Show("Da ket noi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //listView2.Items.Clear();
            ListViewItem dong;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem item = new ListViewItem(dr[1].ToString());
                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(dr[4].ToString());
                item.SubItems.Add(subitem);
                lvSinhVien.Items.Add(item);
            }
            lvSinhVien.View = View.Details;
            lvSinhVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvSinhVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvSinhVien.GridLines = true;
            lvSinhVien.View = View.Details;
            lvSinhVien.Columns.Add("Ma", 150);
            lvSinhVien.Columns.Add("Ten", 150);
            lvSinhVien.Columns.Add("Diem", 150);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*str = "Select StudentID, FullName, AverageScore, FacultyID from SinhVien";
            SqlConnection = new SqlConnection(str);
            cnn.Open();
            SqlCommand = new SqlCommand(str);
            SqlDataReader = cmd.ExecuteReader();
            lvSinhVien.Items.Clear();
            while (Reader.Read())
                lvSinhVien lv = new ListViewItem(Reader.GetInt32(0).ToString());
            lv.SubItems.Add(Reader.GetString(1));
            lv.SubItems.Add(Reader.GetString(2));
            listView1.Items.Add(lv);*/
        } 
}
}