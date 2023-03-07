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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //make new connection to database
            BoxBreakerVideoContext database = new BoxBreakerVideoContext();

            //make a movie object from the database row that matches the text box input. If there is a match, delete that movie
            //if not, show an error
            try
            {
                Movie movieToDelete = database.Movies.Where(movie => movie.Title == txtbxDeleteMovie.Text).First();
                database.Remove(movieToDelete);
                MessageBox.Show($"{txtbxDeleteMovie.Text} Deleted Succesfully");
                database.SaveChanges();
                txtbxDeleteMovie.Clear();
            }
            catch
            {
                MessageBox.Show("Movie Not Found");
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            //make new connection to database
            BoxBreakerVideoContext database = new BoxBreakerVideoContext();

            //make a member object from the database row that matches the text box input. If there is a match, delete that member
            //if not, show an error
            try
            {
                Member memberToDelete = database.Members.Where(member => member.MemberEmail == txtbxDeleteMember.Text).First();
                database.Remove(memberToDelete);
                MessageBox.Show($"{txtbxDeleteMember.Text} Deleted Succesfully");
                database.SaveChanges();
                txtbxDeleteMember.Clear();
            }
            catch
            {
                MessageBox.Show("Member Does Not Exist");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMovieForm addMovie = new AddMovieForm();
            addMovie.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditMovie editMovie = new EditMovie();
            editMovie.ShowDialog();
        }
    }
}
