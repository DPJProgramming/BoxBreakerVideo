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

namespace BoxBreakerVideo.Forms
{
    public partial class EditMovie : Form
    {
        public EditMovie()
        {
            InitializeComponent();
        }

        private void EditMovie_Load(object sender, EventArgs e)
        {
            PopulateMovieList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void cbxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Connect to DB
            BoxBreakerVideoContext connection = new BoxBreakerVideoContext();


            //Grab selected movie, string first to avoid wrapping issues.

            string selectedTitle = cbxMovie.SelectedItem.ToString();
            Movie selectedMovie = connection.Movies.FirstOrDefault(movie => movie.Title == selectedTitle);

            //Change information boxes to selected.
            txtbxTitle.Text = selectedMovie.Title;
            cbxGenre.Text = selectedMovie.Genre;
            cbxMaturityRating.Text = selectedMovie.MaturityRating;
            txtbxPrice.Text = Convert.ToString(selectedMovie.MoviePrice);
            txtbxDesc.Text = selectedMovie.MovieDescription;
            txtbxRuntime.Text = selectedMovie.MovieRuntime;
            txtbxLink.Text = selectedMovie.MoviePoster;
            dtpReleaseDate.Value = selectedMovie.ReleaseDate;
        }
    }
}
