using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TvCheck.WinApp.Helpers;
using TVCheck.Data;
using TVCheck.Infrastructure;
using TVCheck.WinApp.Helpers;

namespace TVCheck.WinApp.Shows
{
    public partial class frmShowAddEdit : Form
    {
        public frmShowAddEdit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {
                Show shows = new Show
                {
                    Title = txtTitle.Text,
                    Description = rtxtDescription.Text,
                    PremiereDate = dtpPremiereDate.Value,
                    SeasonCount = (int)nuSeasonCount.Value,
                    IsCompleted = cbIsCompleted.Checked,
                    AverageRating = (int)nuAverageRating.Value,
                    Genres = clbGenres.CheckedItems.Cast<Genre>().ToList(),
                    StreamingServcies = clbStreamingServices.CheckedItems.Cast<StreamingService>().ToList(),
                    Cast = clbActors.CheckedItems.Cast<Actor>().ToList()
                };
                InMemoryDB.Shows.Add(shows);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateEntry()
        {
            return Validatorr.ValidateEntry(txtTitle, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(rtxtDescription, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(cbIsCompleted, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(nuSeasonCount, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(dtpPremiereDate, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(nuAverageRating, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(nuSeasonCount, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(clbGenres, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(clbActors, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(clbStreamingServices, err, Resources.Get(Keyss.RequiredField));

        }

        private void frmShowAddEdit_Load(object sender, EventArgs e)
        {
            LoadGenres();
            LoadActors();
            LoadStreamingServices();
        }

        private void LoadStreamingServices()
        {
            clbStreamingServices.LoadCheckedData(InMemoryDB.StreamingServices);
        }

        private void LoadActors()
        {
            clbActors.LoadCheckedData(InMemoryDB.Actors);
        }

        private void LoadGenres()
        {
            clbGenres.LoadCheckedData(InMemoryDB.Genres);
        }

        private void pcbAvatar_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadAvatar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pcbAvatar.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
