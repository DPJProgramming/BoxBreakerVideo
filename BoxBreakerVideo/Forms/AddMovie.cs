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

namespace BoxBreakerVideo.Forms {
    public partial class AddMovieForm : Form {
        public AddMovieForm() {
            InitializeComponent();
        }

        private void AddMovie_Load(object sender, EventArgs e) {

            //populate genre combo box
            string[] genreList = { "Sci-Fi", "Horror", "Drama", "Comedy", "Action" };
            foreach (string genre in genreList) {
                cmbbxGenre.Items.Add(genre);
            }

            //Populate Maturuty Rating combobox
            string[] maRating = { "NC-17", "R", "PG-13", "PG", "G", "Not Rated" };
            foreach(string rating in maRating) {
                cmbbxMaturityRating.Items.Add(rating);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        private void button1_Click(object sender, EventArgs e) {

            //open database connection
            BoxBreakerVideoContext database = new BoxBreakerVideoContext();

            //create movie object with all form information
            if (isValid()) {
                Movie newMovie = new Movie() {
                    Title = txtbxTitle.Text,
                    Genre = cmbbxGenre.Text,
                    MovieDescription = txtbxDescription.Text,
                    MovieRuntime = txtbxRuntime.Text,
                    ReleaseDate = datebxReleaseDate.Value,
                    MaturityRating = cmbbxMaturityRating.Text,
                    MoviePoster = txtbxMoviePoster.Text,
                    MoviePrice = Convert.ToDecimal(txtbxPrice.Text)
                };

                //insert new movie into database
                database.Add(newMovie);
                database.SaveChanges();

                MessageBox.Show("Movie Added Successfully");
            }
            
            //if an entry is invalid the isValid method will show the appropriate warning message
        }

        private bool isValid() {
            if (string.IsNullOrWhiteSpace(txtbxTitle.Text) || string.IsNullOrWhiteSpace(txtbxDescription.Text) ||
               string.IsNullOrWhiteSpace(txtbxRuntime.Text) || datebxReleaseDate.Value == null ||
               string.IsNullOrWhiteSpace(txtbxPrice.Text) || string.IsNullOrWhiteSpace(cmbbxGenre.Text) ||
               string.IsNullOrWhiteSpace(cmbbxMaturityRating.Text) || string.IsNullOrWhiteSpace(txtbxMoviePoster.Text)) {

                MessageBox.Show("Make sure all information is present");

                return false;
            }

            //variable to check data type of text entries
            decimal checkType;

            //check that all fields are the right data type
            if (decimal.TryParse(txtbxTitle.Text, out checkType) || decimal.TryParse(txtbxDescription.Text, out checkType) ||
                decimal.TryParse(txtbxRuntime.Text, out checkType) || !decimal.TryParse(txtbxPrice.Text, out checkType) ||
                decimal.TryParse(cmbbxGenre.Text, out checkType) || decimal.TryParse(cmbbxMaturityRating.Text, out checkType) ||
                decimal.TryParse(txtbxMoviePoster.Text, out checkType)) {

                MessageBox.Show("Make sure the information is of the correct type (i.e. Price is a number, 120Min(not just 120), ect)");

                return false;
            }

            return true;
        }
    }
}
