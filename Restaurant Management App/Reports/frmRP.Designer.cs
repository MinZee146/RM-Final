namespace Restaurant_Management_App.Reports
{
    partial class frmRP
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
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ngaybd = new Guna.UI.WinForms.GunaDateTimePicker();
            this.ngaykt = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaButton11 = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(416, 180);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(167)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(160, 55);
            this.gunaButton1.TabIndex = 15;
            this.gunaButton1.Text = "In Báo Cáo";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(35, 89);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(119, 23);
            this.gunaLabel1.TabIndex = 16;
            this.gunaLabel1.Text = "Ngày bắt đầu";
            // 
            // ngaybd
            // 
            this.ngaybd.BaseColor = System.Drawing.Color.White;
            this.ngaybd.BorderColor = System.Drawing.Color.Transparent;
            this.ngaybd.CustomFormat = null;
            this.ngaybd.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ngaybd.FocusedColor = System.Drawing.Color.Teal;
            this.ngaybd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaybd.ForeColor = System.Drawing.Color.Black;
            this.ngaybd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaybd.Location = new System.Drawing.Point(39, 112);
            this.ngaybd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngaybd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngaybd.Name = "ngaybd";
            this.ngaybd.OnHoverBaseColor = System.Drawing.Color.White;
            this.ngaybd.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.ngaybd.OnHoverForeColor = System.Drawing.Color.Black;
            this.ngaybd.OnPressedColor = System.Drawing.Color.Black;
            this.ngaybd.Size = new System.Drawing.Size(223, 39);
            this.ngaybd.TabIndex = 17;
            this.ngaybd.Text = "9/12/2023";
            this.ngaybd.Value = new System.DateTime(2023, 12, 9, 0, 0, 0, 0);
            // 
            // ngaykt
            // 
            this.ngaykt.BaseColor = System.Drawing.Color.White;
            this.ngaykt.BorderColor = System.Drawing.Color.Transparent;
            this.ngaykt.CustomFormat = null;
            this.ngaykt.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.ngaykt.FocusedColor = System.Drawing.Color.Teal;
            this.ngaykt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaykt.ForeColor = System.Drawing.Color.Black;
            this.ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaykt.Location = new System.Drawing.Point(353, 112);
            this.ngaykt.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ngaykt.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ngaykt.Name = "ngaykt";
            this.ngaykt.OnHoverBaseColor = System.Drawing.Color.White;
            this.ngaykt.OnHoverBorderColor = System.Drawing.Color.Teal;
            this.ngaykt.OnHoverForeColor = System.Drawing.Color.Black;
            this.ngaykt.OnPressedColor = System.Drawing.Color.Black;
            this.ngaykt.Size = new System.Drawing.Size(223, 39);
            this.ngaykt.TabIndex = 19;
            this.ngaykt.Text = "9/12/2023";
            this.ngaykt.Value = new System.DateTime(2023, 12, 9, 0, 0, 0, 0);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(349, 89);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(123, 23);
            this.gunaLabel2.TabIndex = 18;
            this.gunaLabel2.Text = "Ngày kết thúc";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(107)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.gunaButton11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 71);
            this.panel1.TabIndex = 20;
            // 
            // gunaButton11
            // 
            this.gunaButton11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton11.AnimationHoverSpeed = 0.07F;
            this.gunaButton11.AnimationSpeed = 0.03F;
            this.gunaButton11.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton11.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(227)))), ((int)(((byte)(213)))));
            this.gunaButton11.BorderColor = System.Drawing.Color.Black;
            this.gunaButton11.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton11.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton11.ForeColor = System.Drawing.Color.White;
            this.gunaButton11.Image = global::Restaurant_Management_App.Properties.Resources.close1;
            this.gunaButton11.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton11.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton11.Location = new System.Drawing.Point(574, 12);
            this.gunaButton11.Name = "gunaButton11";
            this.gunaButton11.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(144)))), ((int)(((byte)(114)))));
            this.gunaButton11.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton11.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton11.OnHoverImage = null;
            this.gunaButton11.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton11.Radius = 20;
            this.gunaButton11.Size = new System.Drawing.Size(54, 50);
            this.gunaButton11.TabIndex = 8;
            this.gunaButton11.Click += new System.EventHandler(this.gunaButton11_Click);
            // 
            // frmRP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(166)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(640, 260);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ngaykt);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.ngaybd);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDateTimePicker ngaybd;
        private Guna.UI.WinForms.GunaDateTimePicker ngaykt;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton gunaButton11;
    }
}