namespace ListView
{
    public partial class ListView : Form
    {
        public ListView()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {afêfêfêfè
             
        }

        private void textBox3_TextChangsed(object sender, EventArgs e)
        {

        }

        private void btnThemm_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txtMaa.Text);
            lvi.SubItems.Add(txtTenn.Text);
            lvi.SubItems.Add(txtDiemm.Text);
            dsview.Items.Add(lvi);
            //dsview.Items.Add(txtMaa.Text, txtTenn.Text, txtDiemm.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();    
        }d22432525253432423

        private void btnSua_Click(object sender, EventArgs e)
        {
            Form2 fi = new Form2();
            if(fi.ShowDialog() == DialogResult.OK)
            {
                 ListViewItem li = new ListViewItem();
                li.SubItems.Add(fi.Ten);
                li.SubItems.Add(fi.Diem);
                dsview.Items.Add(li);
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}