﻿namespace TVCheck.WinApp.Users
{
    partial class frmUsers
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
            dgvUsers = new DataGridView();
            Avatar = new DataGridViewImageColumn();
            UserName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            isActive = new DataGridViewCheckBoxColumn();
            RegistrationDate = new DataGridViewTextBoxColumn();
            btnAddUser = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { Avatar, UserName, Email, isActive, RegistrationDate });
            dgvUsers.Location = new Point(17, 56);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.Size = new Size(799, 329);
            dgvUsers.TabIndex = 0;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // Avatar
            // 
            Avatar.DataPropertyName = "Avatar";
            Avatar.HeaderText = "Avatar";
            Avatar.Name = "Avatar";
            Avatar.ReadOnly = true;
            // 
            // UserName
            // 
            UserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "Username";
            UserName.Name = "UserName";
            UserName.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // isActive
            // 
            isActive.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            isActive.DataPropertyName = "isActive";
            isActive.HeaderText = "Active";
            isActive.Name = "isActive";
            isActive.ReadOnly = true;
            isActive.Resizable = DataGridViewTriState.True;
            isActive.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // RegistrationDate
            // 
            RegistrationDate.DataPropertyName = "RegistrationDate";
            RegistrationDate.HeaderText = "Registration Date";
            RegistrationDate.Name = "RegistrationDate";
            RegistrationDate.ReadOnly = true;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.Black;
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(727, 391);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(89, 31);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(137, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(232, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 27);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 3;
            label1.Text = "Search by Username";
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 434);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnAddUser);
            Controls.Add(dgvUsers);
            Name = "frmUsers";
            Text = "frmUsers";
            Load += frmUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private Button btnAddUser;
        private DataGridViewImageColumn Avatar;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewCheckBoxColumn isActive;
        private DataGridViewTextBoxColumn RegistrationDate;
        private TextBox txtSearch;
        private Label label1;
    }
}