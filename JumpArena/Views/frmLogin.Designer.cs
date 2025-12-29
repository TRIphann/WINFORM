namespace JumpArena.Views
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pnlDimOverlay = new Panel();
            btnBack = new Button();
            btnShowPass = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            txtUsername = new TextBox();
            pnlDimOverlay.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDimOverlay
            // 
            pnlDimOverlay.BackColor = Color.FromArgb(128, 0, 0, 0);
            pnlDimOverlay.Controls.Add(btnBack);
            pnlDimOverlay.Controls.Add(btnShowPass);
            pnlDimOverlay.Controls.Add(label2);
            pnlDimOverlay.Controls.Add(txtPassword);
            pnlDimOverlay.Controls.Add(btnLogin);
            pnlDimOverlay.Controls.Add(label1);
            pnlDimOverlay.Controls.Add(txtUsername);
            pnlDimOverlay.Dock = DockStyle.Fill;
            pnlDimOverlay.Location = new Point(0, 0);
            pnlDimOverlay.Name = "pnlDimOverlay";
            pnlDimOverlay.Size = new Size(800, 450);
            pnlDimOverlay.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Silver;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(15, 11);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(122, 32);
            btnBack.TabIndex = 6;
            btnBack.Text = "< Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnShowPass
            // 
            btnShowPass.BackColor = Color.Transparent;
            btnShowPass.FlatAppearance.BorderSize = 0;
            btnShowPass.FlatStyle = FlatStyle.Flat;
            btnShowPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowPass.ForeColor = SystemColors.ButtonFace;
            btnShowPass.Location = new Point(669, 212);
            btnShowPass.Name = "btnShowPass";
            btnShowPass.Size = new Size(24, 39);
            btnShowPass.TabIndex = 5;
            btnShowPass.Text = "👁️";
            btnShowPass.UseVisualStyleBackColor = false;
            btnShowPass.Click += btnShowPass_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(202, 221);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(360, 221);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(303, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(262, 274);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(303, 40);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(202, 166);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(360, 170);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(303, 27);
            txtUsername.TabIndex = 0;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDimOverlay);
            Name = "frmLogin";
            Text = "frmLogin";
            pnlDimOverlay.ResumeLayout(false);
            pnlDimOverlay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDimOverlay;
        private Label label2;
        private Label label1;
        private TextBox txtUsername;


        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnShowPass;
        private Button btnBack;
    }
}