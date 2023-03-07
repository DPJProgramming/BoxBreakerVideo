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
    public partial class OrderSummaryForm : Form
    {
        private string memberFullName;
        private List<string> moviesRented;
        private int memberId;

        public OrderSummaryForm(string memberFullName, List<string> moviesRented, int memberId)
        {
            InitializeComponent();
            this.memberId = memberId;
            this.memberFullName = memberFullName;
            this.moviesRented = moviesRented;
        }

        private void OrderSummaryForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Populate()
        {
            decimal total = 0;
            txtbxFName.Text = memberFullName;
            dtpDO.Value = DateTime.Today;
            dtpDR.Value = DateTime.Today.AddDays(7);
            foreach (string rentedMovie in moviesRented)
            {
                lstviewRented.Items.Add(rentedMovie);
                string[] movieInfo = rentedMovie.Split(',');
                string movieTitle = movieInfo[0].Trim();
                decimal price = decimal.Parse(movieInfo[1].Trim());
                total += price;
            }
            txtbxTotal.Text = total.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Connect to database
            BoxBreakerVideoContext database = new BoxBreakerVideoContext();



            //Create new MemberMovie object for each rented movie
            foreach (string rentedMovie in moviesRented)
            {
                string[] movieInfo = rentedMovie.Split(',');
                string movieTitle = movieInfo[0].Trim();
                decimal moviePrice = decimal.Parse(movieInfo[1].Trim());

                //Grab movie id from database based on movie title
                Movie movie = database.Movies.FirstOrDefault(m => m.Title == movieTitle);
                long movieId = movie.MovieId;

                //Create new MemberMovie object and add it to the database
                MemberMovie memberMovie = new MemberMovie()
                {
                    MovieId = movieId,
                    MemberId = memberId,
                    CheckoutDate = dtpDO.Value,
                    DueDate = dtpDR.Value,
                    Movie = movie
                };
                database.MemberMovies.Add(memberMovie);
            }

            database.SaveChanges();

            Close();
        }
    }
}
