namespace WindowsFormsApp1
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
            this.btnconnect = new System.Windows.Forms.Button();
            this.btnDisconect = new System.Windows.Forms.Button();
            this.btnDemsv = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(94, 36);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(143, 90);
            this.btnconnect.TabIndex = 0;
            this.btnconnect.Text = "Connection ";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // btnDisconect
            // 
            this.btnDisconect.Location = new System.Drawing.Point(94, 150);
            this.btnDisconect.Name = "btnDisconect";
            this.btnDisconect.Size = new System.Drawing.Size(143, 90);
            this.btnDisconect.TabIndex = 0;
            this.btnDisconect.Text = "Disconect ";
            this.btnDisconect.UseVisualStyleBackColor = true;
            this.btnDisconect.Click += new System.EventHandler(this.btnDisconect_Click);
            // 
            // btnDemsv
            // 
            this.btnDemsv.Location = new System.Drawing.Point(305, 130);
            this.btnDemsv.Name = "btnDemsv";
            this.btnDemsv.Size = new System.Drawing.Size(129, 48);
            this.btnDemsv.TabIndex = 1;
            this.btnDemsv.Text = "Demsv";
            this.btnDemsv.UseVisualStyleBackColor = true;
            this.btnDemsv.Click += new System.EventHandler(this.btnDemsv_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(310, 203);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(124, 59);
            this.txtMa.TabIndex = 3;
            this.txtMa.Text = "Xem Thong TinSV theo ma";
            this.txtMa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDemsv);
            this.Controls.Add(this.btnDisconect);
            this.Controls.Add(this.btnconnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.Button btnDisconect;
        private System.Windows.Forms.Button btnDemsv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button txtMa;
    }
}

