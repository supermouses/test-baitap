using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    StudentContextDB context = new StudentContextDB();
            //    List<Faculty> listFalcultys = context.Faculties.ToList();
            //    List<Student> listStudent = context.Students.ToList();
            //    FillFalcultyCombobox(listFalcultys);
            //    BindGrid(listStudent);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //// TODO: This line of code loads data into the 'quanLyThongTinSVDataSet.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.quanLyThongTinSVDataSet.Student);
            //// TODO: This line of code loads data into the 'quanLyThongTinSVDataSet.Faculty' table. You can move, or remove it, as needed.
            //this.facultyTableAdapter.Fill(this.quanLyThongTinSVDataSet.Faculty);
            //// TODO: This line of code loads data into the 'quanLyThongTinSVDataSet.Faculty' table. You can move, or remove it, as needed.
            //this.facultyTableAdapter.Fill(this.quanLyThongTinSVDataSet.Faculty);
            //// TODO: This line of code loads data into the 'quanLyThongTinSVDataSet.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.quanLyThongTinSVDataSet.Student);
            //// TODO: This line of code loads data into the 'quanLyThongTinSVDataSet.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.quanLyThongTinSVDataSet.Student);
            //// TODO: This line of code loads data into the 'quanLyThongTinSVDataSet.Faculty' table. You can move, or remove it, as needed.
            //this.facultyTableAdapter.Fill(this.quanLyThongTinSVDataSet.Faculty);
            //// TODO: This line of code loads data into the 'quanLyThongTinSVDataSet.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.quanLyThongTinSVDataSet.Student);
        }
        private void FillFalcultyCombobox(List<Faculty> ListFalcultys)
        {
            this.bKhoa.DataSource = ListFalcultys;
            this.bKhoa.DisplayMember = "FacultyName";
            this.bKhoa.ValueMember = "FacultyID";
        }
        private void BindGrid(List<Student>ListStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in ListStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                dgvStudent.Rows[index].Cells[1].Value = item.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[1].Value = item.AverageScore;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
        private int GetSelectedRow(string studentID)
        {
            for (int i = 0; i < dgvStudent.Rows.Count; i++)
            {
                if (dgvStudent.Rows[i].Cells[0].Value.ToString() == studentID)
                {
                    return i;
                }

            }

            return -1;
        }
        private void them (int selectedRow)
        {
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtStudentID.Text;
            dgvStudent.Rows[selectedRow].Cells[0].Value = txtFullName.Text;
            dgvStudent.Rows[selectedRow].Cells[0].Value = float.Parse(txtAveragescore.Text).ToString();
            dgvStudent.Rows[selectedRow].Cells[0].Value = bKhoa.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentID.Text == "" || txtFullName.Text == "" || txtAveragescore.Text == "")
                    throw new Exception("Vui long nhap day du thong tin sinh vien!");

                int selectedRow = GetSelectedRow(txtStudentID.Text);
                //TH Them moi
                {
                    selectedRow = dgvStudent.Rows.Add();
                    them(selectedRow);
                    MessageBox.Show("them moi du lieu thanh cong!", "Thong bao", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dbDelete_Click(object sender, EventArgs e)
        {
               try
                {
                    int selectedRow = GetSelectedRow(txtStudentID.Text);
                    if (selectedRow == -1)
                    {
                        throw new Exception("Khong tim thay MSSV can xoa!");
                    }
                    else
                    {
                        DialogResult dr = MessageBox.Show("Ban co muon xoa ?", "YES/NO", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            dgvStudent.Rows.RemoveAt(selectedRow); //xoa thong tin sinh vien tai dong tim thay
                            MessageBox.Show("Xoa sinh vien thanh cong!", "Thong Bao", MessageBoxButtons.OK);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
