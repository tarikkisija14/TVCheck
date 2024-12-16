namespace TVCheck.WinApp.Shows
{
    partial class frmShows
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
            dgvShows = new DataGridView();
            Avatar = new DataGridViewImageColumn();
            Title = new DataGridViewTextBoxColumn();
            AverageRating = new DataGridViewTextBoxColumn();
            IsCompleted = new DataGridViewCheckBoxColumn();
            SeasonCount = new DataGridViewTextBoxColumn();
            PremiereDate = new DataGridViewTextBoxColumn();
            btnAddShow = new Button();
            label1 = new Label();
            txtFilter = new TextBox();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShows).BeginInit();
            SuspendLayout();
            // 
            // dgvShows
            // 
            dgvShows.AllowUserToAddRows = false;
            dgvShows.AllowUserToDeleteRows = false;
            dgvShows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShows.Columns.AddRange(new DataGridViewColumn[] { Avatar, Title, AverageRating, IsCompleted, SeasonCount, PremiereDate });
            dgvShows.Location = new Point(12, 57);
            dgvShows.Name = "dgvShows";
            dgvShows.ReadOnly = true;
            dgvShows.Size = new Size(776, 355);
            dgvShows.TabIndex = 0;
            dgvShows.CellContentClick += dgvShows_CellContentClick;
            // 
            // Avatar
            // 
            Avatar.DataPropertyName = "Avatar";
            Avatar.HeaderText = "Show Picture";
            Avatar.Name = "Avatar";
            Avatar.ReadOnly = true;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // AverageRating
            // 
            AverageRating.DataPropertyName = "AverageRating";
            AverageRating.HeaderText = "Imdb Rating";
            AverageRating.Name = "AverageRating";
            AverageRating.ReadOnly = true;
            // 
            // IsCompleted
            // 
            IsCompleted.DataPropertyName = "IsCompleted";
            IsCompleted.HeaderText = "Is Completed?";
            IsCompleted.Name = "IsCompleted";
            IsCompleted.ReadOnly = true;
            // 
            // SeasonCount
            // 
            SeasonCount.DataPropertyName = "SeasonCount";
            SeasonCount.HeaderText = "Number of Seasons";
            SeasonCount.Name = "SeasonCount";
            SeasonCount.ReadOnly = true;
            // 
            // PremiereDate
            // 
            PremiereDate.DataPropertyName = "PremiereDate";
            PremiereDate.HeaderText = "Premiere Date";
            PremiereDate.Name = "PremiereDate";
            PremiereDate.ReadOnly = true;
            // 
            // btnAddShow
            // 
            btnAddShow.BackColor = Color.Black;
            btnAddShow.ForeColor = Color.White;
            btnAddShow.Location = new Point(681, 418);
            btnAddShow.Name = "btnAddShow";
            btnAddShow.Size = new Size(107, 35);
            btnAddShow.TabIndex = 1;
            btnAddShow.Text = "Add Show";
            btnAddShow.UseVisualStyleBackColor = false;
            btnAddShow.Click += btnAddShow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 2;
            label1.Text = "Search by Title";
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(111, 25);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(176, 23);
            txtFilter.TabIndex = 3;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Black;
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(568, 418);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(107, 35);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove Show";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // frmShows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 458);
            Controls.Add(btnRemove);
            Controls.Add(txtFilter);
            Controls.Add(label1);
            Controls.Add(btnAddShow);
            Controls.Add(dgvShows);
            Name = "frmShows";
            Text = "Shows List";
            Load += frmShows_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShows;
        private Button btnAddShow;
        private DataGridViewImageColumn Avatar;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn AverageRating;
        private DataGridViewCheckBoxColumn IsCompleted;
        private DataGridViewTextBoxColumn SeasonCount;
        private DataGridViewTextBoxColumn PremiereDate;
        private Label label1;
        private TextBox txtFilter;
        private Button btnRemove;
    }
}