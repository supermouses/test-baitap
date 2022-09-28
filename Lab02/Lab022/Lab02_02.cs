using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab022
{
    public partial class Lab02_02 : Form
    {
        public Lab02_02()
        {
            InitializeComponent();
        }

        private void Lab02_02_Load(object sender, EventArgs e)
        {

        }
        private int ChonHang(string studentID)
        {
            for(int i = 0; i< dgvStudentID.Rows.Count; i++ )
            {
                if(dgvStudentID.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }
            }
            return -1;
        }
        private void ThemSua(int selectedRow)
        {
            dgvStudentID.Rows[selectedRow].Cells[0].Value = txtStudentID.Text;
            dgvStudentID.Rows[selectedRow].Cells[1].Value = txtFullName.Text;
            dgvStudentID.Rows[selectedRow].Cells[2].Value = optFemale.Checked ? "Nữ" : "Nam";
            dgvStudentID.Rows[selectedRow].Cells[3].Value = float.Parse(txtAverageScore.Text).ToString();
            dgvStudentID.Rows[selectedRow].Cells[4].Value = cmbKhoa.Text;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentID.Text == "" || txtFullName.Text == "" || txtAverageScore.Text == "")
                   throw new Exception("Xin vui lòng nhập đầy đủ thông tin sinh viên!");
                int chonhangr = ChonHang(txtStudentID.Text);
                if (chonhangr == -1);
                {
                    chonhangr = dgvStudentID.Rows.Add();
                    ThemSua(chonhangr);
                    MessageBox.Show("Đã Thêm Dữ Liệu vào!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int chonhangr = ChonHang(txtStudentID.Text);
                if (chonhangr == -1)
                {
                    throw new Exception("Không tìm thấy mssv cần xóa!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Xóa ? ", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvStudentID.Rows.RemoveAt(chonhangr);
                        MessageBox.Show("Đã Xóa Sinh Viên Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
