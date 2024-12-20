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

namespace TVCheck.WinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //dgvAllShows.AutoGenerateColumns = false;
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadShows();
            LoadAnime();
            
        }

        private void LoadAnime(List<Anime> anime=null)
        {
            dgvAnime.DataSource = null;
            dgvAnime.DataSource= anime?? InMemoryDB.Animes;
        }

        private void LoadShows(List<Show>shows = null)
        {
            dgvAllShows.DataSource = null;
            dgvAllShows.DataSource = shows ?? InMemoryDB.Shows;
        }
    }
}
