namespace TVCheck.WinApp
{
    partial class frmMain
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvTrending = new DataGridView();
            tabPage2 = new TabPage();
            txtSearch = new TextBox();
            pbSearch = new PictureBox();
            dgvAllShows = new DataGridView();
            tabPage3 = new TabPage();
            txtaAnimeSearch = new TextBox();
            pbAnimeAvatar = new PictureBox();
            dgvAnime = new DataGridView();
            pbAvatar = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrending).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllShows).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnimeAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(5, 151);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1012, 502);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvTrending);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1004, 474);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Trending";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTrending
            // 
            dgvTrending.AllowUserToAddRows = false;
            dgvTrending.AllowUserToDeleteRows = false;
            dgvTrending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrending.Location = new Point(6, 6);
            dgvTrending.Name = "dgvTrending";
            dgvTrending.ReadOnly = true;
            dgvTrending.Size = new Size(995, 462);
            dgvTrending.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtSearch);
            tabPage2.Controls.Add(pbSearch);
            tabPage2.Controls.Add(dgvAllShows);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1004, 474);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "All Shows";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(44, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(187, 23);
            txtSearch.TabIndex = 2;
            // 
            // pbSearch
            // 
            pbSearch.BorderStyle = BorderStyle.FixedSingle;
            pbSearch.Image = Resource1.images;
            pbSearch.Location = new Point(7, 33);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(31, 23);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 1;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            // 
            // dgvAllShows
            // 
            dgvAllShows.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllShows.Location = new Point(6, 62);
            dgvAllShows.Name = "dgvAllShows";
            dgvAllShows.Size = new Size(992, 406);
            dgvAllShows.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtaAnimeSearch);
            tabPage3.Controls.Add(pbAnimeAvatar);
            tabPage3.Controls.Add(dgvAnime);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1004, 474);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Anime";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtaAnimeSearch
            // 
            txtaAnimeSearch.BorderStyle = BorderStyle.FixedSingle;
            txtaAnimeSearch.Location = new Point(44, 33);
            txtaAnimeSearch.Name = "txtaAnimeSearch";
            txtaAnimeSearch.Size = new Size(187, 23);
            txtaAnimeSearch.TabIndex = 2;
            // 
            // pbAnimeAvatar
            // 
            pbAnimeAvatar.BorderStyle = BorderStyle.FixedSingle;
            pbAnimeAvatar.Image = Resource1.images;
            pbAnimeAvatar.Location = new Point(7, 33);
            pbAnimeAvatar.Name = "pbAnimeAvatar";
            pbAnimeAvatar.Size = new Size(32, 23);
            pbAnimeAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAnimeAvatar.TabIndex = 1;
            pbAnimeAvatar.TabStop = false;
            // 
            // dgvAnime
            // 
            dgvAnime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnime.Location = new Point(7, 62);
            dgvAnime.Name = "dgvAnime";
            dgvAnime.Size = new Size(991, 409);
            dgvAnime.TabIndex = 0;
            // 
            // pbAvatar
            // 
            pbAvatar.Image = Resource1.logo2;
            pbAvatar.Location = new Point(5, 12);
            pbAvatar.Name = "pbAvatar";
            pbAvatar.Size = new Size(158, 121);
            pbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAvatar.TabIndex = 1;
            pbAvatar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(169, 66);
            label1.Name = "label1";
            label1.Size = new Size(262, 28);
            label1.TabIndex = 2;
            label1.Text = "Hi User welcome to Tv Check";
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(882, 89);
            button1.Name = "button1";
            button1.Size = new Size(125, 44);
            button1.TabIndex = 3;
            button1.Text = "My Shows";
            button1.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1015, 665);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pbAvatar);
            Controls.Add(tabControl1);
            Name = "frmMain";
            Text = "Tv Check";
            Load += frmMain_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrending).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllShows).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAnimeAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAnime).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvTrending;
        private TabPage tabPage3;
        private PictureBox pbAvatar;
        private Label label1;
        private Button button1;
        private DataGridView dgvAllShows;
        private TextBox txtSearch;
        private PictureBox pbSearch;
        private TextBox txtaAnimeSearch;
        private PictureBox pbAnimeAvatar;
        private DataGridView dgvAnime;
    }
}