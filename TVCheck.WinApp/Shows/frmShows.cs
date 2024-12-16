using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVCheck.Data;
using TVCheck.Infrastructure;
using TVCheck.WinApp.Helpers;

namespace TVCheck.WinApp.Shows
{
    public partial class frmShows : Form
    {

        public frmShows()
        {
            InitializeComponent();
            dgvShows.AutoGenerateColumns = false;
            this.dgvShows.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvShows_KeyDown);
            this.KeyPreview = true;
        }

        private void frmShows_Load(object sender, EventArgs e)
        {
            LoadShows();

        }



        private void LoadShows(List<Show> shows = null)
        {
            dgvShows.DataSource = null;
            dgvShows.DataSource = shows ?? InMemoryDB.Shows;
        }

        private void btnAddShow_Click(object sender, EventArgs e)
        {
            if (new frmShowAddEdit().ShowDialog() == DialogResult.OK)
            { LoadShows(); }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            LoadShows(InMemoryDB.Shows.Where(FilterShows).ToList());
        }

        private bool FilterShows(Show show)
        {
            var filter = txtFilter.Text.ToLower();

            return show.Title.ToLower().Contains(filter);
        }

        private void dgvShows_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var choosenShow = dgvShows.GetRow() as Show;

            Form form = null;

            form = new frmShowAddEdit(choosenShow);

            if (form.ShowDialog() == DialogResult.OK)
                LoadShows();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var selectedShow=dgvShows.GetRow() as Show;

            if(selectedShow !=null)
            {
                InMemoryDB.Shows.Remove(selectedShow);
                LoadShows() ;
            }
            else
            {
                MessageBox.Show("Please select a show to remove");
            }

        }
        private void dgvShows_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) 
            {
                var selectedShow = dgvShows.GetRow() as Show;

                if (selectedShow != null)
                {
                    
                    InMemoryDB.Shows.Remove(selectedShow);
                    LoadShows();
                }
                else
                {
                    MessageBox.Show("Please select a show to remove.");
                }
            }
        }
    }
}
