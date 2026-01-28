using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace JumpArena
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
            this.pnlDimOverlay = new System.Windows.Forms.Panel();
            this.pnlSelectRole = new System.Windows.Forms.Panel();
            this.btnRoleAdmin = new System.Windows.Forms.Button();
            this.btnRoleAccountant = new System.Windows.Forms.Button();
            this.btnRoleManager = new System.Windows.Forms.Button();
            this.btnRoleNV = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDimOverlay.SuspendLayout();
            this.pnlSelectRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDimOverlay
            // 
            this.pnlDimOverlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlDimOverlay.Controls.Add(this.pnlSelectRole);
            this.pnlDimOverlay.Controls.Add(this.lblTitle);
            this.pnlDimOverlay.Controls.Add(this.btnClose);
            this.pnlDimOverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDimOverlay.Location = new System.Drawing.Point(0, 0);
            this.pnlDimOverlay.Name = "pnlDimOverlay";
            this.pnlDimOverlay.Size = new System.Drawing.Size(782, 403);
            this.pnlDimOverlay.TabIndex = 0;
            // 
            // pnlSelectRole
            // 
            this.pnlSelectRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlSelectRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelectRole.Controls.Add(this.btnRoleAdmin);
            this.pnlSelectRole.Controls.Add(this.btnRoleAccountant);
            this.pnlSelectRole.Controls.Add(this.btnRoleManager);
            this.pnlSelectRole.Controls.Add(this.btnRoleNV);
            this.pnlSelectRole.Location = new System.Drawing.Point(245, 110);
            this.pnlSelectRole.Name = "pnlSelectRole";
            this.pnlSelectRole.Size = new System.Drawing.Size(310, 280);
            this.pnlSelectRole.TabIndex = 2;
            // 
            // btnRoleAdmin
            // 
            this.btnRoleAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRoleAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoleAdmin.FlatAppearance.BorderSize = 0;
            this.btnRoleAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleAdmin.ForeColor = System.Drawing.Color.White;
            this.btnRoleAdmin.Location = new System.Drawing.Point(55, 215);
            this.btnRoleAdmin.Name = "btnRoleAdmin";
            this.btnRoleAdmin.Size = new System.Drawing.Size(200, 45);
            this.btnRoleAdmin.TabIndex = 3;
            this.btnRoleAdmin.Text = "ADMIN";
            this.btnRoleAdmin.UseVisualStyleBackColor = false;
            // 
            // btnRoleAccountant
            // 
            this.btnRoleAccountant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRoleAccountant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoleAccountant.FlatAppearance.BorderSize = 0;
            this.btnRoleAccountant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleAccountant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleAccountant.ForeColor = System.Drawing.Color.White;
            this.btnRoleAccountant.Location = new System.Drawing.Point(55, 150);
            this.btnRoleAccountant.Name = "btnRoleAccountant";
            this.btnRoleAccountant.Size = new System.Drawing.Size(200, 45);
            this.btnRoleAccountant.TabIndex = 2;
            this.btnRoleAccountant.Text = "KẾ TOÁN";
            this.btnRoleAccountant.UseVisualStyleBackColor = false;
            // 
            // btnRoleManager
            // 
            this.btnRoleManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRoleManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoleManager.FlatAppearance.BorderSize = 0;
            this.btnRoleManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleManager.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleManager.ForeColor = System.Drawing.Color.White;
            this.btnRoleManager.Location = new System.Drawing.Point(55, 85);
            this.btnRoleManager.Name = "btnRoleManager";
            this.btnRoleManager.Size = new System.Drawing.Size(200, 45);
            this.btnRoleManager.TabIndex = 1;
            this.btnRoleManager.Text = "QUẢN LÝ";
            this.btnRoleManager.UseVisualStyleBackColor = false;
            // 
            // btnRoleNV
            // 
            this.btnRoleNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRoleNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoleNV.FlatAppearance.BorderSize = 0;
            this.btnRoleNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleNV.ForeColor = System.Drawing.Color.White;
            this.btnRoleNV.Location = new System.Drawing.Point(55, 20);
            this.btnRoleNV.Name = "btnRoleNV";
            this.btnRoleNV.Size = new System.Drawing.Size(200, 45);
            this.btnRoleNV.TabIndex = 0;
            this.btnRoleNV.Text = "NHÂN VIÊN";
            this.btnRoleNV.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(66, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(650, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "WELCOME TO JUMP ARENA";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(747, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSelectRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JumpArena.Properties.Resources.jump_arena_khu_vui_choi_bat_nhun_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.pnlDimOverlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmSelectRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSelectRole";
            this.pnlDimOverlay.ResumeLayout(false);
            this.pnlDimOverlay.PerformLayout();
            this.pnlSelectRole.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel pnlDimOverlay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlSelectRole;
        private System.Windows.Forms.Button btnRoleNV;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRoleAdmin;
        private System.Windows.Forms.Button btnRoleAccountant;
        private System.Windows.Forms.Button btnRoleManager;
    }
}