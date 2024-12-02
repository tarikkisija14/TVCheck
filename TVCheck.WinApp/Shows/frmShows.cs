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
            
        }

        private void frmShows_Load(object sender, EventArgs e)
        {
            LoadShows();
        }

        private void LoadShows(List<Show>shows =null)
        {
            dgvShows.DataSource = null;
            dgvShows.DataSource = shows ?? InMemoryDB.Shows;
        }
    }
}
