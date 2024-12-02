namespace TVCheck.WinApp.Users
{
    partial class frmUsersAddEdit
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
            components = new System.ComponentModel.Container();
            pbAvatar = new PictureBox();
            label1 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            dtpRegDate = new DateTimePicker();
            label6 = new Label();
            btnLoadAvatar = new Button();
            btnSave = new Button();
            cbIsActive = new CheckBox();
            err = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbAvatar
            // 
            pbAvatar.BorderStyle = BorderStyle.FixedSingle;
            pbAvatar.Location = new Point(12, 41);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(192, 175);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 0;
            pbAvatar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 41);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(220, 61);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(114, 23);
            txtFirstName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(340, 41);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(340, 61);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(114, 23);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 87);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(221, 105);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(114, 23);
            txtUsername.TabIndex = 6;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(340, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(114, 23);
            txtPassword.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(340, 87);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 131);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "Email";
            label5.Click += label5_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(220, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 23);
            txtEmail.TabIndex = 10;
            // 
            // dtpRegDate
            // 
            dtpRegDate.Location = new Point(220, 193);
            dtpRegDate.Name = "dtpRegDate";
            dtpRegDate.Size = new Size(128, 23);
            dtpRegDate.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(221, 175);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 12;
            label6.Text = "Registration Date";
            // 
            // btnLoadAvatar
            // 
            btnLoadAvatar.Location = new Point(12, 222);
            btnLoadAvatar.Name = "btnLoadAvatar";
            btnLoadAvatar.Size = new Size(192, 35);
            btnLoadAvatar.TabIndex = 13;
            btnLoadAvatar.Text = "Load Avatar";
            btnLoadAvatar.UseVisualStyleBackColor = true;
            btnLoadAvatar.Click += btnLoadAvatar_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(371, 229);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 28);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbIsActive
            // 
            cbIsActive.AutoSize = true;
            cbIsActive.Location = new Point(367, 193);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(59, 19);
            cbIsActive.TabIndex = 15;
            cbIsActive.Text = "Active";
            cbIsActive.UseVisualStyleBackColor = true;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmUsersAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 273);
            Controls.Add(cbIsActive);
            Controls.Add(btnSave);
            Controls.Add(btnLoadAvatar);
            Controls.Add(label6);
            Controls.Add(dtpRegDate);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Controls.Add(pbAvatar);
            Name = "frmUsersAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUsersAddEdit";
            Load += frmUsersAddEdit_Load;
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbAvatar;
        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private DateTimePicker dtpRegDate;
        private Label label6;
        private Button btnLoadAvatar;
        private Button btnSave;
        private CheckBox cbIsActive;
        private ErrorProvider err;
        private OpenFileDialog openFileDialog1;
    }
}