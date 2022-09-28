namespace Lab04
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bKhoa = new System.Windows.Forms.ComboBox();
            this.txtAveragescore = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThongTinSVDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyThongTinSVDataSet = new Lab04.QuanLyThongTinSVDataSet();
            this.InsertUpdate = new System.Windows.Forms.Button();
            this.dbFix = new System.Windows.Forms.Button();
            this.dbDelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultyTableAdapter = new Lab04.QuanLyThongTinSVDataSetTableAdapters.FacultyTableAdapter();
            this.studentTableAdapter = new Lab04.QuanLyThongTinSVDataSetTableAdapters.StudentTableAdapter();
            this.facultyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThongTinSVDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThongTinSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bKhoa);
            this.groupBox1.Controls.Add(this.txtAveragescore);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.txtStudentID);
            this.groupBox1.Location = new System.Drawing.Point(48, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 301);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Điểm TB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "MSSV";
            // 
            // bKhoa
            // 
            this.bKhoa.DataSource = this.facultyBindingSource1;
            this.bKhoa.DisplayMember = "FacultyID";
            this.bKhoa.FormattingEnabled = true;
            this.bKhoa.Location = new System.Drawing.Point(96, 167);
            this.bKhoa.Name = "bKhoa";
            this.bKhoa.Size = new System.Drawing.Size(121, 21);
            this.bKhoa.TabIndex = 3;
            this.bKhoa.ValueMember = "FacultyName";
            // 
            // txtAveragescore
            // 
            this.txtAveragescore.Location = new System.Drawing.Point(96, 210);
            this.txtAveragescore.Name = "txtAveragescore";
            this.txtAveragescore.Size = new System.Drawing.Size(100, 20);
            this.txtAveragescore.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(96, 118);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(100, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(96, 65);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 0;
            this.txtStudentID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AutoGenerateColumns = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.averageScoreDataGridViewTextBoxColumn,
            this.facultyIDDataGridViewTextBoxColumn});
            this.dgvStudent.DataSource = this.studentBindingSource;
            this.dgvStudent.Location = new System.Drawing.Point(506, 142);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.Size = new System.Drawing.Size(509, 301);
            this.dgvStudent.TabIndex = 2;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // averageScoreDataGridViewTextBoxColumn
            // 
            this.averageScoreDataGridViewTextBoxColumn.DataPropertyName = "AverageScore";
            this.averageScoreDataGridViewTextBoxColumn.HeaderText = "AverageScore";
            this.averageScoreDataGridViewTextBoxColumn.Name = "averageScoreDataGridViewTextBoxColumn";
            // 
            // facultyIDDataGridViewTextBoxColumn
            // 
            this.facultyIDDataGridViewTextBoxColumn.DataPropertyName = "FacultyID";
            this.facultyIDDataGridViewTextBoxColumn.HeaderText = "FacultyID";
            this.facultyIDDataGridViewTextBoxColumn.Name = "facultyIDDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.quanLyThongTinSVDataSetBindingSource;
            // 
            // quanLyThongTinSVDataSetBindingSource
            // 
            this.quanLyThongTinSVDataSetBindingSource.DataSource = this.quanLyThongTinSVDataSet;
            this.quanLyThongTinSVDataSetBindingSource.Position = 0;
            // 
            // quanLyThongTinSVDataSet
            // 
            this.quanLyThongTinSVDataSet.DataSetName = "QuanLyThongTinSVDataSet";
            this.quanLyThongTinSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InsertUpdate
            // 
            this.InsertUpdate.Location = new System.Drawing.Point(77, 458);
            this.InsertUpdate.Name = "InsertUpdate";
            this.InsertUpdate.Size = new System.Drawing.Size(75, 23);
            this.InsertUpdate.TabIndex = 3;
            this.InsertUpdate.Text = "Thêm";
            this.InsertUpdate.UseVisualStyleBackColor = true;
            this.InsertUpdate.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbFix
            // 
            this.dbFix.Location = new System.Drawing.Point(190, 458);
            this.dbFix.Name = "dbFix";
            this.dbFix.Size = new System.Drawing.Size(75, 23);
            this.dbFix.TabIndex = 4;
            this.dbFix.Text = "Sửa";
            this.dbFix.UseVisualStyleBackColor = true;
            // 
            // dbDelete
            // 
            this.dbDelete.Location = new System.Drawing.Point(312, 458);
            this.dbDelete.Name = "dbDelete";
            this.dbDelete.Size = new System.Drawing.Size(75, 23);
            this.dbDelete.TabIndex = 0;
            this.dbDelete.Text = "Xóa";
            this.dbDelete.UseVisualStyleBackColor = true;
            this.dbDelete.Click += new System.EventHandler(this.dbDelete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1011, 506);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "Faculty";
            this.facultyBindingSource.DataSource = this.quanLyThongTinSVDataSetBindingSource;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // facultyBindingSource1
            // 
            this.facultyBindingSource1.DataMember = "Faculty";
            this.facultyBindingSource1.DataSource = this.quanLyThongTinSVDataSetBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 541);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dbDelete);
            this.Controls.Add(this.dbFix);
            this.Controls.Add(this.InsertUpdate);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThongTinSVDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThongTinSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bKhoa;
        private System.Windows.Forms.TextBox txtAveragescore;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button dbFix;
        private System.Windows.Forms.Button dbDelete;
        private System.Windows.Forms.Button button4;
        private QuanLyThongTinSVDataSet quanLyThongTinSVDataSet;
        private System.Windows.Forms.BindingSource quanLyThongTinSVDataSetBindingSource;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private QuanLyThongTinSVDataSetTableAdapters.FacultyTableAdapter facultyTableAdapter;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private QuanLyThongTinSVDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyIDDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button InsertUpdate;
        private System.Windows.Forms.BindingSource facultyBindingSource1;
    }
}

