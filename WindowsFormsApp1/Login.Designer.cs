namespace QLSB
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PanelLogin3 = new System.Windows.Forms.Panel();
            this.ForgotPass = new System.Windows.Forms.LinkLabel();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.OutButton = new System.Windows.Forms.Button();
            this.MinimunButton = new System.Windows.Forms.Button();
            this.dataGridViewFake = new System.Windows.Forms.DataGridView();
            this.PanelLogin3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFake)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLogin3
            // 
            this.PanelLogin3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelLogin3.Controls.Add(this.ForgotPass);
            this.PanelLogin3.Controls.Add(this.LoginLabel);
            this.PanelLogin3.Controls.Add(this.LoginButton);
            this.PanelLogin3.Controls.Add(this.UserLabel);
            this.PanelLogin3.Controls.Add(this.PassTextBox);
            this.PanelLogin3.Controls.Add(this.UserTextBox);
            this.PanelLogin3.Controls.Add(this.PassLabel);
            this.PanelLogin3.Location = new System.Drawing.Point(192, 12);
            this.PanelLogin3.Name = "PanelLogin3";
            this.PanelLogin3.Size = new System.Drawing.Size(220, 299);
            this.PanelLogin3.TabIndex = 2;
            // 
            // ForgotPass
            // 
            this.ForgotPass.AutoSize = true;
            this.ForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPass.LinkColor = System.Drawing.Color.Black;
            this.ForgotPass.Location = new System.Drawing.Point(4, 207);
            this.ForgotPass.Name = "ForgotPass";
            this.ForgotPass.Size = new System.Drawing.Size(130, 20);
            this.ForgotPass.TabIndex = 6;
            this.ForgotPass.TabStop = true;
            this.ForgotPass.Text = "Quên Mật Khẩu ";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.SystemColors.Control;
            this.LoginLabel.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginLabel.Location = new System.Drawing.Point(12, 23);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(244, 53);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Đăng Nhập";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(0, 240);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(220, 43);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Đăng Nhập";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserLabel.Location = new System.Drawing.Point(3, 113);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(173, 27);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "Tên Đăng Nhập:";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(1, 184);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.Size = new System.Drawing.Size(219, 22);
            this.PassTextBox.TabIndex = 5;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(0, 137);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(220, 22);
            this.UserTextBox.TabIndex = 2;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(3, 160);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(117, 27);
            this.PassLabel.TabIndex = 3;
            this.PassLabel.Text = "Mật Khẩu:";
            // 
            // OutButton
            // 
            this.OutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutButton.Location = new System.Drawing.Point(568, 2);
            this.OutButton.Name = "OutButton";
            this.OutButton.Size = new System.Drawing.Size(35, 33);
            this.OutButton.TabIndex = 3;
            this.OutButton.Text = "X";
            this.OutButton.UseVisualStyleBackColor = true;
            this.OutButton.Click += new System.EventHandler(this.OutButton_Click);
            // 
            // MinimunButton
            // 
            this.MinimunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimunButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimunButton.Location = new System.Drawing.Point(523, 2);
            this.MinimunButton.Name = "MinimunButton";
            this.MinimunButton.Size = new System.Drawing.Size(39, 33);
            this.MinimunButton.TabIndex = 4;
            this.MinimunButton.Text = "_";
            this.MinimunButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimunButton.UseVisualStyleBackColor = true;
            this.MinimunButton.Click += new System.EventHandler(this.MinimunButton_Click);
            // 
            // dataGridViewFake
            // 
            this.dataGridViewFake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFake.Location = new System.Drawing.Point(-19, -19);
            this.dataGridViewFake.Name = "dataGridViewFake";
            this.dataGridViewFake.RowHeadersWidth = 51;
            this.dataGridViewFake.RowTemplate.Height = 24;
            this.dataGridViewFake.Size = new System.Drawing.Size(0, 0);
            this.dataGridViewFake.TabIndex = 5;
            // 
            // Login
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 323);
            this.Controls.Add(this.dataGridViewFake);
            this.Controls.Add(this.MinimunButton);
            this.Controls.Add(this.OutButton);
            this.Controls.Add(this.PanelLogin3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.PanelLogin3.ResumeLayout(false);
            this.PanelLogin3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFake)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel PanelLogin3;
        private System.Windows.Forms.LinkLabel ForgotPass;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Button MinimunButton;
        private System.Windows.Forms.DataGridView dataGridViewFake;

        #endregion
        //private System.Windows.Forms.Label label1;
    }
}