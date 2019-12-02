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
            this.panelLogin3 = new System.Windows.Forms.Panel();
            this.forgotPass = new System.Windows.Forms.LinkLabel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.OutButton = new System.Windows.Forms.Button();
            this.MinimunButton = new System.Windows.Forms.Button();
            this.dataGridViewFake = new System.Windows.Forms.DataGridView();
            this.panelLogin3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFake)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin3
            // 
            this.panelLogin3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogin3.Controls.Add(this.forgotPass);
            this.panelLogin3.Controls.Add(this.loginLabel);
            this.panelLogin3.Controls.Add(this.loginButton);
            this.panelLogin3.Controls.Add(this.userLabel);
            this.panelLogin3.Controls.Add(this.passTextBox);
            this.panelLogin3.Controls.Add(this.userTextBox);
            this.panelLogin3.Controls.Add(this.passLabel);
            this.panelLogin3.Location = new System.Drawing.Point(192, 12);
            this.panelLogin3.Name = "panelLogin3";
            this.panelLogin3.Size = new System.Drawing.Size(220, 299);
            this.panelLogin3.TabIndex = 2;
            // 
            // forgotPass
            // 
            this.forgotPass.AutoSize = true;
            this.forgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPass.LinkColor = System.Drawing.Color.Black;
            this.forgotPass.Location = new System.Drawing.Point(4, 207);
            this.forgotPass.Name = "forgotPass";
            this.forgotPass.Size = new System.Drawing.Size(130, 20);
            this.forgotPass.TabIndex = 6;
            this.forgotPass.TabStop = true;
            this.forgotPass.Text = "Quên Mật Khẩu ";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.SystemColors.Control;
            this.loginLabel.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginLabel.Location = new System.Drawing.Point(12, 23);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(244, 53);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Đăng Nhập";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(0, 240);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(220, 43);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Đăng Nhập";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userLabel.Location = new System.Drawing.Point(3, 113);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(173, 27);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Tên Đăng Nhập:";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(1, 184);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(219, 22);
            this.passTextBox.TabIndex = 5;
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(0, 137);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(220, 22);
            this.userTextBox.TabIndex = 2;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(3, 160);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(117, 27);
            this.passLabel.TabIndex = 3;
            this.passLabel.Text = "Mật Khẩu:";
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
            this.AcceptButton = this.loginButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 323);
            this.Controls.Add(this.dataGridViewFake);
            this.Controls.Add(this.MinimunButton);
            this.Controls.Add(this.OutButton);
            this.Controls.Add(this.panelLogin3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panelLogin3.ResumeLayout(false);
            this.panelLogin3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFake)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelLogin3;
        private System.Windows.Forms.LinkLabel forgotPass;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button OutButton;
        private System.Windows.Forms.Button MinimunButton;
        private System.Windows.Forms.DataGridView dataGridViewFake;

        #endregion
        //private System.Windows.Forms.Label label1;
    }
}