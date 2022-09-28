using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form2 : Form
    {
        public string Ma
        {
            get { return txtMa.Text; }
            set { txtMa.Text = value; }
        }
        public string Ten
        {
            get { return txtTen.Text; }
            set { txtTen.Text = value; }
        }
        public string Diem
        {
            get { return txtDiem.Text; }
            set { txtDiem.Text = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            
        }
    }
}
