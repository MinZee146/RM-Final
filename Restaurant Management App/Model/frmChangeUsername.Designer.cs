namespace Restaurant_Management_App.Model
{
    partial class frmChangeUsername
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbConfirm = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewusname = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOldusname = new Guna.UI.WinForms.GunaTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.btSave = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 165);
            this.panel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaLabel1.Location = new System.Drawing.Point(149, 62);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(159, 25);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Đổi tên tài khoản";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Restaurant_Management_App.Properties.Resources.cogwheel_3953226__1_;
            this.gunaPictureBox1.Location = new System.Drawing.Point(33, 27);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(95, 94);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(57, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nhập lại tên tài khoản mới";
            // 
            // tbConfirm
            // 
            this.tbConfirm.BaseColor = System.Drawing.Color.White;
            this.tbConfirm.BorderColor = System.Drawing.Color.Silver;
            this.tbConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirm.FocusedBaseColor = System.Drawing.Color.White;
            this.tbConfirm.FocusedBorderColor = System.Drawing.Color.Teal;
            this.tbConfirm.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbConfirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirm.Location = new System.Drawing.Point(57, 411);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.PasswordChar = '\0';
            this.tbConfirm.SelectedText = "";
            this.tbConfirm.Size = new System.Drawing.Size(271, 42);
            this.tbConfirm.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(57, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên tài khoản mới";
            // 
            // tbNewusname
            // 
            this.tbNewusname.BaseColor = System.Drawing.Color.White;
            this.tbNewusname.BorderColor = System.Drawing.Color.Silver;
            this.tbNewusname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNewusname.FocusedBaseColor = System.Drawing.Color.White;
            this.tbNewusname.FocusedBorderColor = System.Drawing.Color.Teal;
            this.tbNewusname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbNewusname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNewusname.Location = new System.Drawing.Point(57, 321);
            this.tbNewusname.Name = "tbNewusname";
            this.tbNewusname.PasswordChar = '\0';
            this.tbNewusname.SelectedText = "";
            this.tbNewusname.Size = new System.Drawing.Size(271, 42);
            this.tbNewusname.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(57, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên tài khoản hiện tại";
            // 
            // tbOldusname
            // 
            this.tbOldusname.BaseColor = System.Drawing.Color.White;
            this.tbOldusname.BorderColor = System.Drawing.Color.Silver;
            this.tbOldusname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOldusname.FocusedBaseColor = System.Drawing.Color.White;
            this.tbOldusname.FocusedBorderColor = System.Drawing.Color.Teal;
            this.tbOldusname.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbOldusname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldusname.Location = new System.Drawing.Point(57, 235);
            this.tbOldusname.Name = "tbOldusname";
            this.tbOldusname.PasswordChar = '\0';
            this.tbOldusname.SelectedText = "";
            this.tbOldusname.Size = new System.Drawing.Size(271, 42);
            this.tbOldusname.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(191)))), ((int)(((byte)(150)))));
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.btSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 81);
            this.panel2.TabIndex = 14;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(90)))), ((int)(((byte)(103)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(90)))), ((int)(((byte)(103)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(33, 13);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(139, 47);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.Text = "Lưu";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.btSave_Click_1);
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(90)))), ((int)(((byte)(103)))));
            this.btSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(90)))), ((int)(((byte)(103)))));
            this.btSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btSave.BorderRadius = 20;
            this.btSave.BorderSize = 0;
            this.btSave.FlatAppearance.BorderSize = 0;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btSave.ForeColor = System.Drawing.Color.White;
            this.btSave.Location = new System.Drawing.Point(209, 13);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(139, 47);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Đóng";
            this.btSave.TextColor = System.Drawing.Color.White;
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btExit_Click_1);
            // 
            // frmChangeUsername
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(400, 587);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNewusname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOldusname);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangeUsername";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangeUsername";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaTextBox tbConfirm;
        public System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaTextBox tbNewusname;
        public System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaTextBox tbOldusname;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public CustomControls.RJControls.RJButton rjButton1;
        public CustomControls.RJControls.RJButton btSave;
    }
}