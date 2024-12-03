namespace TVCheck.WinApp.Shows
{
    partial class frmShowAddEdit
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
            pcbAvatar = new PictureBox();
            btnLoadAvatar = new Button();
            label1 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            rtxtDescription = new RichTextBox();
            nuSeasonCount = new NumericUpDown();
            label3 = new Label();
            cbIsCompleted = new CheckBox();
            dtpPremiereDate = new DateTimePicker();
            label4 = new Label();
            nuAverageRating = new NumericUpDown();
            label5 = new Label();
            clbGenres = new CheckedListBox();
            label6 = new Label();
            label7 = new Label();
            clbStreamingServices = new CheckedListBox();
            label8 = new Label();
            clbActors = new CheckedListBox();
            btnSave = new Button();
            err = new ErrorProvider(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pcbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuSeasonCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuAverageRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pcbAvatar
            // 
            pcbAvatar.BorderStyle = BorderStyle.FixedSingle;
            pcbAvatar.Location = new Point(27, 12);
            pcbAvatar.Name = "pcbAvatar";
            pcbAvatar.Size = new Size(220, 274);
            pcbAvatar.TabIndex = 0;
            pcbAvatar.TabStop = false;
            pcbAvatar.Click += pcbAvatar_Click;
            // 
            // btnLoadAvatar
            // 
            btnLoadAvatar.Location = new Point(24, 292);
            btnLoadAvatar.Name = "btnLoadAvatar";
            btnLoadAvatar.Size = new Size(223, 38);
            btnLoadAvatar.TabIndex = 1;
            btnLoadAvatar.Text = "Load Show Image";
            btnLoadAvatar.UseVisualStyleBackColor = true;
            btnLoadAvatar.Click += btnLoadAvatar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 12);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(260, 34);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(119, 23);
            txtTitle.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 16);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(406, 34);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(120, 69);
            rtxtDescription.TabIndex = 5;
            rtxtDescription.Text = "";
            // 
            // nuSeasonCount
            // 
            nuSeasonCount.Location = new Point(260, 78);
            nuSeasonCount.Name = "nuSeasonCount";
            nuSeasonCount.Size = new Size(120, 23);
            nuSeasonCount.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 60);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 7;
            label3.Text = "Season Count";
            // 
            // cbIsCompleted
            // 
            cbIsCompleted.AutoSize = true;
            cbIsCompleted.Location = new Point(532, 34);
            cbIsCompleted.Name = "cbIsCompleted";
            cbIsCompleted.Size = new Size(96, 19);
            cbIsCompleted.TabIndex = 8;
            cbIsCompleted.Text = "Is Completed";
            cbIsCompleted.UseVisualStyleBackColor = true;
            // 
            // dtpPremiereDate
            // 
            dtpPremiereDate.Location = new Point(260, 131);
            dtpPremiereDate.Name = "dtpPremiereDate";
            dtpPremiereDate.Size = new Size(119, 23);
            dtpPremiereDate.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(262, 111);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 10;
            label4.Text = "PremiereDate";
            // 
            // nuAverageRating
            // 
            nuAverageRating.Location = new Point(406, 131);
            nuAverageRating.Name = "nuAverageRating";
            nuAverageRating.Size = new Size(120, 23);
            nuAverageRating.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 111);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 12;
            label5.Text = "Average Rating";
            // 
            // clbGenres
            // 
            clbGenres.FormattingEnabled = true;
            clbGenres.Location = new Point(262, 192);
            clbGenres.Name = "clbGenres";
            clbGenres.Size = new Size(120, 94);
            clbGenres.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 174);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 14;
            label6.Text = "Genres";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(406, 174);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 16;
            label7.Text = "Streaming Services";
            // 
            // clbStreamingServices
            // 
            clbStreamingServices.FormattingEnabled = true;
            clbStreamingServices.Location = new Point(406, 192);
            clbStreamingServices.Name = "clbStreamingServices";
            clbStreamingServices.Size = new Size(120, 94);
            clbStreamingServices.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(552, 174);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 18;
            label8.Text = "Actors";
            // 
            // clbActors
            // 
            clbActors.FormattingEnabled = true;
            clbActors.Location = new Point(552, 192);
            clbActors.Name = "clbActors";
            clbActors.Size = new Size(120, 94);
            clbActors.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Black;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(552, 294);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 34);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmShowAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 341);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(clbActors);
            Controls.Add(label7);
            Controls.Add(clbStreamingServices);
            Controls.Add(label6);
            Controls.Add(clbGenres);
            Controls.Add(label5);
            Controls.Add(nuAverageRating);
            Controls.Add(label4);
            Controls.Add(dtpPremiereDate);
            Controls.Add(cbIsCompleted);
            Controls.Add(label3);
            Controls.Add(nuSeasonCount);
            Controls.Add(rtxtDescription);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(btnLoadAvatar);
            Controls.Add(pcbAvatar);
            Name = "frmShowAddEdit";
            Text = "Add Show";
            Load += frmShowAddEdit_Load;
            ((System.ComponentModel.ISupportInitialize)pcbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuSeasonCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuAverageRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbAvatar;
        private Button btnLoadAvatar;
        private Label label1;
        private TextBox txtTitle;
        private Label label2;
        private RichTextBox rtxtDescription;
        private NumericUpDown nuSeasonCount;
        private Label label3;
        private CheckBox cbIsCompleted;
        private DateTimePicker dtpPremiereDate;
        private Label label4;
        private NumericUpDown nuAverageRating;
        private Label label5;
        private CheckedListBox clbGenres;
        private Label label6;
        private Label label7;
        private CheckedListBox clbStreamingServices;
        private Label label8;
        private CheckedListBox clbActors;
        private Button btnSave;
        private ErrorProvider err;
        private OpenFileDialog openFileDialog1;
    }
}