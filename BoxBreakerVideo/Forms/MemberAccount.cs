using BoxBreakerVideo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxBreakerVideo.Forms {
    public partial class MemberAccount : Form {
        public MemberAccount(Member loggedInMember, BoxBreakerVideoContext database) {
            InitializeComponent();

            //For welcome message showing members first name
            lblFirstName.Text = loggedInMember.MemberFname;
            lstbxMovieTitles.Items.Clear();

            //create list of memberMovie objects attached to loggedInMember
            List<MemberMovie> movieList = database.MemberMovies.Where(m => m.MemberId == loggedInMember.MemberId).ToList();

            foreach (MemberMovie movie in movieList) {

                //get title of movie from id
                string? movieTitle = (from m in database.Movies where m.MovieId == movie.MovieId select m.Title).SingleOrDefault();

                //If movie is due, remove it from members account
                //To test quickly, append .AddDays(8) to DateTime.Today in if statement
                if (movie.DueDate < DateTime.Today) {
                    MessageBox.Show($"{movieTitle} was due on {movie.DueDate.ToShortDateString()} and will be removed");
                    database.MemberMovies.Remove(movie);
                    database.SaveChanges();
                }
                else {
                    //movieTitle = (from m in database.Movies where m.MovieId == movie.MovieId select m.Title).SingleOrDefault();

                    //fill in information on form
                    lstbxMovieTitles.Items.Add(movieTitle);
                    lstbxCheckoutDate.Items.Add(movie.CheckoutDate.Date);
                    lstbxDueDate.Items.Add(movie.DueDate.Date);
                }
            }
        }
    }
}
