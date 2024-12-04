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

namespace TVCheck.WinApp.Shows
{
    public partial class frmShows : Form
    {
        public frmShows()
        {
            InitializeComponent();
            dgvShows.AutoGenerateColumns = false;
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
            var filter= txtFilter.Text.ToLower();

            return show.Title.ToLower().Contains(filter);
        }
    }
}
