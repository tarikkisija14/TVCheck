namespace TVCheck.WinApp
{
    partial class frmRegistration
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
            label1 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label5 = new Label();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            err = new ErrorProvider(components);
            btnRegistration = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 44);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(336, 36);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(160, 23);
            txtFirstName.TabIndex = 1;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 87);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(335, 84);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(160, 23);
            txtLastName.TabIndex = 3;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 134);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(336, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(160, 23);
            txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 173);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 8;
            label4.Text = "Username";
            label4.Click += label4_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(336, 165);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(160, 23);
            txtUsername.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(266, 213);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 10;
            label5.Text = "Password";
            label5.Click += label5_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(335, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(160, 23);
            txtPassword.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Resource1.superr;
            pictureBox1.Location = new Point(31, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = Color.Black;
            btnRegistration.Font = new Font("Segoe UI", 11F);
            btnRegistration.ForeColor = Color.White;
            btnRegistration.Location = new Point(424, 239);
            btnRegistration.Margin = new Padding(0);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Size = new Size(72, 32);
            btnRegistration.TabIndex = 13;
            btnRegistration.Text = "Submit";
            btnRegistration.UseVisualStyleBackColor = false;
            btnRegistration.Click += btnRegistration_Click;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(565, 298);
            Controls.Add(btnRegistration);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(label5);
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(label2);
            Controls.Add(txtFirstName);
            Controls.Add(label1);
            Name = "frmRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New User Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtUsername;
        private Label label5;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private ErrorProvider err;
        private Button btnRegistration;
    }
}