using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_01 : Form
    {
        public Lab02_01()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cong_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    float number1 = float.Parse(textBox1.Text);         //Cộng
                    float number2 = float.Parse(textBox2.Text);
                    float result = number1 + number2;
                    Answer.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tru_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    float number1 = float.Parse(textBox1.Text);
                    float number2 = float.Parse(textBox2.Text);         //Trừ 
                    float result = number1 - number2;
                    Answer.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void nhan_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    float number1 = float.Parse(textBox1.Text);
                    float number2 = float.Parse(textBox2.Text);             //*
                    float result = number1 * number2;
                    Answer.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void chia_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    float number1 = float.Parse(textBox1.Text);
                    float number2 = float.Parse(textBox2.Text);
                    float result = number1 / number2;
                    Answer.Text = result.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
