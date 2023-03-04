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
            string[] genreList = { "Sci-Fi", "Horror", "Drama", "Comedy" };
            foreach (string genre in genreList) {
                cmbbxGenre.Items.Add(genre);
            }

            //Populate Maturuty Rating combobox
            string[] maRating = { "NC-17", "R", "PG-13", "PG", "G" };
            foreach(string rating in maRating) {
                cmbbxMaturityRating.Items.Add(rating);
            }
        }
    }
}
