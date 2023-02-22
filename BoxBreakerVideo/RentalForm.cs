using BoxBreakerVideo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxBreakerVideo
{
    public partial class FormRentalForm : Form
    {
        public FormRentalForm()
        {
            InitializeComponent();
        }

        private void cbxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Connect to DB
            BoxBreakerVideoContext connection = new BoxBreakerVideoContext();


            //Grab selected movie, string first to avoid wrapping issues.

            string selectedTitle = cbxMovie.SelectedItem.ToString();
            Movie selectedMovie = connection.Movies.FirstOrDefault(movie => movie.Title == selectedTitle);

            //Change information boxes to selected.
            txtbxTitle.Text = selectedMovie.Title;
            txtbxGenre.Text = selectedMovie.Genre;
            txtbxRating.Text = selectedMovie.MaturityRating;
            txtbxPrice.Text = Convert.ToString(selectedMovie.MoviePrice);
            txtbxDesc.Text = selectedMovie.MovieDescription;
            pbxPoster.ImageLocation = selectedMovie.MoviePoster;

        }

        private void FormRentalForm_Load(object sender, EventArgs e)
        {

            PopulateMovieList();
        }

        private void PopulateMovieList()
        {
            //Connect to DB
            BoxBreakerVideoContext connection = new BoxBreakerVideoContext();

            //Refresh the ComboBox by clearing it
            cbxMovie.Items.Clear();

            //Populate the list
            List<Movie> movieList = connection.Movies.ToList();

            foreach (Movie movie in movieList)
            {
                cbxMovie.Items.Add(movie.Title);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            //Connect to DB
            BoxBreakerVideoContext connection = new BoxBreakerVideoContext();


            //Grab selected movie, string first to avoid wrapping issues (copied from cbx method)

            string selectedTitle = cbxMovie.SelectedItem.ToString();
            Movie selectedMovie = connection.Movies.FirstOrDefault(movie => movie.Title == selectedTitle);

            //Populate the listView with current order
            lstViewOrder.Items.Add(selectedMovie.Title + ", " + selectedMovie.MoviePrice);
            txtbxTotal.Text = Convert.ToString(selectedMovie.MoviePrice + total);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstViewOrder.Items.Clear();
            txtbxTotal.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
