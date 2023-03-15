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
            lstbxMovieList.Items.Clear();

            //create list of memberMovie objects attached to loggedInMember
            List<MemberMovie> movieList = database.MemberMovies.Where(m => m.MemberId == loggedInMember.MemberId).ToList();

            foreach (MemberMovie movie in movieList) {

                string? movieTitle = (from m in database.Movies where m.MovieId == movie.MovieId select m.Title).SingleOrDefault();

                //string title = database.Movies.Where(m => m.MovieId == movie.MovieId)
                lstbxMovieList.Items.Add(movieTitle + "          " + movie.CheckoutDate.Date + "        " + "       " + movie.DueDate.Date);
            }
        }
    }
}
