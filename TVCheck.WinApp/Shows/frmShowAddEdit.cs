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

        private Show? show;

        public frmShowAddEdit(Show? choosenshow=null)
        {
            InitializeComponent();
            this.show = choosenshow ?? new Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {


                show.Title = txtTitle.Text;
                show.Description = rtxtDescription.Text;
                show.PremiereDate = dtpPremiereDate.Value;
                show.SeasonCount = (int)nuSeasonCount.Value;
                show.IsCompleted = cbIsCompleted.Checked;
                show.AverageRating = (int)nuAverageRating.Value;
                show.Genres = clbGenres.CheckedItems.Cast<Genre>().ToList();
                show.StreamingServcies = clbStreamingServices.CheckedItems.Cast<StreamingService>().ToList();
                show.Cast = clbActors.CheckedItems.Cast<Actor>().ToList();

                if (show.ID == 0)
                {
                    show.ID = InMemoryDB.Shows.Count + 1;
                }
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
            LoadData();

        }

        private void LoadData()
        {
            txtTitle.Text = show.Title;
            rtxtDescription.Text = show.Description;
            dtpPremiereDate.Value = show.PremiereDate;
            nuSeasonCount.Value = show.SeasonCount;
            cbIsCompleted.Checked = show.IsCompleted;
            nuAverageRating.Value = (decimal)show.AverageRating;
            foreach (var genre in show.Genres)
            {
                for (int i = 0; i < clbGenres.Items.Count; i++)
                {
                    if (clbGenres.Items[i] is Genre item && item.ID == genre.ID) 
                    {
                        clbGenres.SetItemChecked(i, true);  
                        break;
                    }
                }
            }

           
            foreach (var actor in show.Cast)
            {
                for (int i = 0; i < clbActors.Items.Count; i++)
                {
                    if (clbActors.Items[i] is Actor item && item.ID == actor.ID) 
                    {
                        clbActors.SetItemChecked(i, true);  
                        break;
                    }
                }
            }

            
            foreach (var service in show.StreamingServcies)
            {
                for (int i = 0; i < clbStreamingServices.Items.Count; i++)
                {
                    if (clbStreamingServices.Items[i] is StreamingService item && item.ID == service.ID) 
                    {
                        clbStreamingServices.SetItemChecked(i, true); 
                        break;
                    }
                }
            }
        }

        private void LoadGenres()
        {
            clbGenres.LoadCheckedData(InMemoryDB.Genres, selectedItems: show.Genres);
        }

        private void LoadActors()
        {
            clbActors.LoadCheckedData(InMemoryDB.Actors, selectedItems: show.Cast);
        }

        private void LoadStreamingServices()
        {
            clbStreamingServices.LoadCheckedData(InMemoryDB.StreamingServices, selectedItems: show.StreamingServcies);
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
