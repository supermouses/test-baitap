namespace ListView
{
    partial class ListView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.txtMaa = new System.Windows.Forms.TextBox();
            this.txtTenn = new System.Windows.Forms.TextBox();
            this.txtDiemm = new System.Windows.Forms.TextBox();
            this.btnThemm = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clMa = new System.Windows.Forms.ColumnHeader();
            this.clTen = new System.Windows.Forms.ColumnHeader();
            this.clDiem = new System.Windows.Forms.ColumnHeader();
            this.dsview = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaa
            // 
            this.txtMaa.Location = new System.Drawing.Point(557, 59);
            this.txtMaa.Name = "txtMaa";
            this.txtMaa.Size = new System.Drawing.Size(100, 23);
            this.txtMaa.TabIndex = 1;
            this.txtMaa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTenn
            // 
            this.txtTenn.Location = new System.Drawing.Point(557, 104);
            this.txtTenn.Name = "txtTenn";
            this.txtTenn.Size = new System.Drawing.Size(100, 23);
            this.txtTenn.TabIndex = 2;
            // 
            // txtDiemm
            // 
            this.txtDiemm.Location = new System.Drawing.Point(558, 153);
            this.txtDiemm.Name = "txtDiemm";
            this.txtDiemm.Size = new System.Drawing.Size(100, 23);
            this.txtDiemm.TabIndex = 3;
            this.txtDiemm.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnThemm
            // 
            this.btnThemm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnThemm.Location = new System.Drawing.Point(252, 265);
            this.btnThemm.Name = "btnThemm";
            this.btnThemm.Size = new System.Drawing.Size(82, 78);
            this.btnThemm.TabIndex = 4;
            this.btnThemm.Text = "Thêm ";
            this.btnThemm.UseVisualStyleBackColor = true;
            this.btnThemm.Click += new System.EventHandler(this.btnThemm_Click);
            // 
            // btnSua
            // 
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSua.Location = new System.Drawing.Point(426, 265);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 78);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Điểm";
            // 
            // clMa
            // 
            this.clMa.Text = "Mã";
            // 
            // clTen
            // 
            this.clTen.Text = "Tên";
            // 
            // clDiem
            // 
            this.clDiem.Text = "Điểm";
            // 
            // dsview
            // 
            this.dsview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMa,
            this.clTen,
            this.clDiem});
            this.dsview.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.dsview.Location = new System.Drawing.Point(252, 59);
            this.dsview.Name = "dsview";
            this.dsview.Size = new System.Drawing.Size(222, 123);
            this.dsview.TabIndex = 0;
            this.dsview.UseCompatibleStateImageBehavior = false;
            this.dsview.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 138);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoatToolStripMenuItem.Text = "Thoat";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemm);
            this.Controls.Add(this.txtDiemm);
            this.Controls.Add(this.txtTenn);
            this.Controls.Add(this.txtMaa);
            this.Controls.Add(this.dsview);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListView";
            this.Text = "ListVieww";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtMaa;
        private TextBox txtTenn;
        private TextBox txtDiemm;
        private Button btnThemm;
        private Button btnSua;
        private Label label1;
        private Label label2;
        private Label label3;
        private ColumnHeader clMa;
        private ColumnHeader clTen;
        private ColumnHeader clDiem;
        private System.Windows.Forms.ListView dsview;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem thoatToolStripMenuItem;
    }
}