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
            btnAddShow = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShows).BeginInit();
            SuspendLayout();
            // 
            // dgvShows
            // 
            dgvShows.AllowUserToAddRows = false;
            dgvShows.AllowUserToDeleteRows = false;
            dgvShows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShows.Location = new Point(12, 57);
            dgvShows.Name = "dgvShows";
            dgvShows.ReadOnly = true;
            dgvShows.Size = new Size(776, 355);
            dgvShows.TabIndex = 0;
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
            // 
            // frmShows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 458);
            Controls.Add(btnAddShow);
            Controls.Add(dgvShows);
            Name = "frmShows";
            Text = "Shows List";
            Load += frmShows_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShows).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvShows;
        private Button btnAddShow;
    }
}