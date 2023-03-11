using BoxBreakerVideo.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
            PopulateAllLists();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PopulateAllLists()
        {
            //Connect to DB
            BoxBreakerVideoContext connection = new BoxBreakerVideoContext();

            //Refresh the ComboBox by clearing it
            cbxMovie.Items.Clear();
            cbxGenre.Items.Clear();
            cbxMaturityRating.Items.Clear();

            //Populate the list
            List<Movie> movieList = connection.Movies.ToList();

            foreach (Movie movie in movieList)
            {
                cbxMovie.Items.Add(movie.Title);

            }
            //Populate the Genre ComboBox
            string[] genreList = { "Sci-Fi", "Horror", "Drama", "Comedy", "Action" };
            foreach (string genre in genreList)
            {
                cbxGenre.Items.Add(genre);
            }

            //Populate the Maturity Rating 
            string[] maRating = { "NC-17", "R", "PG-13", "PG", "G", "Not Rated" };
            foreach (string rating in maRating)
            {
                cbxMaturityRating.Items.Add(rating);
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Connect to DB
            BoxBreakerVideoContext database = new BoxBreakerVideoContext();

            if (isValid())
            {
                //Grab selected movie from combobox.
                string selectedTitle = cbxMovie.SelectedItem.ToString();
                Movie selectedMovie = database.Movies.FirstOrDefault(movie => movie.Title == selectedTitle);

                //update selected movie object with new form info
                selectedMovie.Title = txtbxTitle.Text;
                selectedMovie.Genre = cbxGenre.Text;
                selectedMovie.MovieDescription = txtbxDesc.Text;
                selectedMovie.MovieRuntime = txtbxRuntime.Text;
                selectedMovie.ReleaseDate = dtpReleaseDate.Value;
                selectedMovie.MaturityRating = cbxMaturityRating.Text;
                selectedMovie.MoviePoster = txtbxLink.Text;
                selectedMovie.MoviePrice = Convert.ToDecimal(txtbxPrice.Text);
                database.SaveChanges();
                MessageBox.Show("Successfully edited movie.");

                //Close form after completion
                Close();
            }
        }
        private Boolean isValid()
        {
            //variable for checking validity of data
            decimal checkType;

            //Checks that an item is selected
            if (cbxMovie.SelectedItem == null)
            {
                MessageBox.Show("Please select a movie");
                return false;
            }

            //checks that all fields are filled in
            else if(txtbxTitle.Text == "" || txtbxDesc.Text == "" || txtbxRuntime.Text == "" ||
                    dtpReleaseDate.Value == null || txtbxPrice.Text == "" || cbxGenre.Text == "" || 
                    cbxMaturityRating.Text == "" || txtbxLink.Text == "") 
            {
                MessageBox.Show("Make sure all information is present");
                return false;
            }

            //check that all fields are the right data type
            else if (decimal.TryParse(txtbxTitle.Text, out checkType) || decimal.TryParse(txtbxDesc.Text, out checkType) ||
                     decimal.TryParse(txtbxRuntime.Text, out checkType) || !decimal.TryParse(txtbxPrice.Text, out checkType) ||
                     decimal.TryParse(cbxGenre.Text, out checkType) || decimal.TryParse(cbxMaturityRating.Text, out checkType) ||
                     decimal.TryParse(txtbxLink.Text, out checkType)) 
            {
                MessageBox.Show("Make sure the information is of the correct type (i.e. Price is a number, 120Min(not just 120), ect)");
                return false;
            }
            else 
            {
                return true;
            }
        }

        private void cbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxMaturityRating_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
