namespace JumpArena.Views
{
    partial class frmSelectRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectRole));
            pnlDimOverlay = new Panel();
            Title = new Label();
            pnlSelectRole = new Panel();
            btnRoleAdmin = new Button();
            btnRoleAccountant = new Button();
            btnRoleManager = new Button();
            btnRoleNV = new Button();
            pnlDimOverlay.SuspendLayout();
            pnlSelectRole.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDimOverlay
            // 
            pnlDimOverlay.BackColor = Color.FromArgb(128, 0, 0, 0);
            pnlDimOverlay.Controls.Add(Title);
            pnlDimOverlay.Controls.Add(pnlSelectRole);
            pnlDimOverlay.Dock = DockStyle.Fill;
            pnlDimOverlay.Location = new Point(0, 0);
            pnlDimOverlay.Name = "pnlDimOverlay";
            pnlDimOverlay.Size = new Size(800, 450);
            pnlDimOverlay.TabIndex = 0;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Blue;
            Title.BorderStyle = BorderStyle.Fixed3D;
            Title.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(255, 128, 0);
            Title.Location = new Point(149, 9);
            Title.Margin = new Padding(0);
            Title.Name = "Title";
            Title.Size = new Size(508, 40);
            Title.TabIndex = 1;
            Title.Text = "CHÀO MỪNG ĐẾN VỚI JUMP ARENA";
            // 
            // pnlSelectRole
            // 
            pnlSelectRole.BackColor = Color.Transparent;
            pnlSelectRole.Controls.Add(btnRoleAdmin);
            pnlSelectRole.Controls.Add(btnRoleAccountant);
            pnlSelectRole.Controls.Add(btnRoleManager);
            pnlSelectRole.Controls.Add(btnRoleNV);
            pnlSelectRole.Location = new Point(192, 110);
            pnlSelectRole.Name = "pnlSelectRole";
            pnlSelectRole.Size = new Size(427, 254);
            pnlSelectRole.TabIndex = 0;
            pnlSelectRole.Visible = false;
            // 
            // btnRoleAdmin
            // 
            btnRoleAdmin.BackColor = Color.Silver;
            btnRoleAdmin.FlatAppearance.BorderSize = 0;
            btnRoleAdmin.FlatAppearance.CheckedBackColor = Color.Silver;
            btnRoleAdmin.FlatStyle = FlatStyle.Flat;
            btnRoleAdmin.Location = new Point(143, 192);
            btnRoleAdmin.Name = "btnRoleAdmin";
            btnRoleAdmin.Size = new Size(153, 40);
            btnRoleAdmin.TabIndex = 3;
            btnRoleAdmin.Text = "ADMIN";
            btnRoleAdmin.UseVisualStyleBackColor = false;
            btnRoleAdmin.Click += RoleButton_Click;
            // 
            // btnRoleAccountant
            // 
            btnRoleAccountant.BackColor = Color.Silver;
            btnRoleAccountant.FlatAppearance.BorderSize = 0;
            btnRoleAccountant.FlatAppearance.CheckedBackColor = Color.Silver;
            btnRoleAccountant.FlatStyle = FlatStyle.Flat;
            btnRoleAccountant.Location = new Point(143, 146);
            btnRoleAccountant.Name = "btnRoleAccountant";
            btnRoleAccountant.Size = new Size(153, 40);
            btnRoleAccountant.TabIndex = 2;
            btnRoleAccountant.Text = "KẾ TOÁN";
            btnRoleAccountant.UseVisualStyleBackColor = false;
            btnRoleAccountant.Click += RoleButton_Click;
            // 
            // btnRoleManager
            // 
            btnRoleManager.BackColor = Color.Silver;
            btnRoleManager.FlatAppearance.BorderSize = 0;
            btnRoleManager.FlatAppearance.CheckedBackColor = Color.Silver;
            btnRoleManager.FlatStyle = FlatStyle.Flat;
            btnRoleManager.Location = new Point(143, 100);
            btnRoleManager.Name = "btnRoleManager";
            btnRoleManager.Size = new Size(153, 40);
            btnRoleManager.TabIndex = 1;
            btnRoleManager.Text = "QUẢN LÝ";
            btnRoleManager.UseVisualStyleBackColor = false;
            btnRoleManager.Click += RoleButton_Click;
            // 
            // btnRoleNV
            // 
            btnRoleNV.BackColor = Color.Silver;
            btnRoleNV.FlatAppearance.BorderSize = 0;
            btnRoleNV.FlatAppearance.CheckedBackColor = Color.Silver;
            btnRoleNV.FlatStyle = FlatStyle.Flat;
            btnRoleNV.Location = new Point(143, 54);
            btnRoleNV.Name = "btnRoleNV";
            btnRoleNV.Size = new Size(153, 40);
            btnRoleNV.TabIndex = 0;
            btnRoleNV.Text = "NHÂN VIÊN";
            btnRoleNV.UseVisualStyleBackColor = false;
            btnRoleNV.Click += RoleButton_Click;
            // 
            // frmSelectRole
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlDimOverlay);
            Name = "frmSelectRole";
            Text = "frmSelectRole";
            Load += frmSelectRole_Load;
            pnlDimOverlay.ResumeLayout(false);
            pnlDimOverlay.PerformLayout();
            pnlSelectRole.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDimOverlay;
        private Panel pnlSelectRole;
        private Button btnRoleAdmin;
        private Button btnRoleAccountant;
        private Button btnRoleManager;
        private Button btnRoleNV;
        private Label Title;
    }
}