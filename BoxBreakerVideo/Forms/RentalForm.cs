using BoxBreakerVideo.Forms;
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
        private string memberFullName;
        private List<string> moviesRented;
        private int memberId;

        public FormRentalForm(string memberFullName, int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            this.memberFullName = memberFullName;
            moviesRented = new List<string>();
        }
        private decimal total;
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
            txtbxRunTime.Text = selectedMovie.MovieRuntime;
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


            //Connect to DB
            BoxBreakerVideoContext connection = new BoxBreakerVideoContext();


            //Grab selected movie, string first to avoid wrapping issues (copied from cbx method)

            string selectedTitle = cbxMovie.SelectedItem.ToString();
            Movie selectedMovie = connection.Movies.FirstOrDefault(movie => movie.Title == selectedTitle);

            //Check if movie is already in order
            bool doesMovieExist = false;
            foreach (ListViewItem item in lstViewOrder.Items)
            {
                if (item.Text.Contains(selectedMovie.Title))
                {
                    doesMovieExist = true;
                    break;
                }
            }

            if (!doesMovieExist)
            {
                decimal currentTotal = (decimal)selectedMovie.MoviePrice;

                //Populate the listView with current order
                lstViewOrder.Items.Add(selectedMovie.Title + ", " + selectedMovie.MoviePrice);
                moviesRented.Add(selectedMovie.Title + ", " + selectedMovie.MoviePrice);
                total += currentTotal;
                txtbxTotal.Text = Convert.ToString(total);
                
            }
            else
            {
                MessageBox.Show("Movie is already in the order.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstViewOrder.Items.Clear();
            total = 0;
            txtbxTotal.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //Open Summary form and pass fullname in as parameter
            OrderSummaryForm orderSummaryForm = new OrderSummaryForm(memberFullName, moviesRented,memberId);
            orderSummaryForm.ShowDialog();
        }
    }
}
