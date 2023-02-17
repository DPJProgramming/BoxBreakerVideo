using BoxBreakerVideo.Models;
using Microsoft.EntityFrameworkCore;

namespace BoxBreakerVideo {
	public partial class formUserLogin : Form {
		public formUserLogin() {
			InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e) {

        }

        /// <summary>
        /// opens a new form to rent a movie after validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e) {
            //make new connection to the database
            BoxBreakerVideoContext database = new BoxBreakerVideoContext();

            //if credentials are valid, open rental form
            if (database.Members.Where(data => data.MemberEmail == txtbxEmail.Text && data.MemberPassword == txtbxPassword.Text).Any()) {
                FormRentalForm newRental = new FormRentalForm();
                newRental.ShowDialog();
            }
            //otherwise failed login window pops up
            else {
                MessageBox.Show("Incorrect Email and/or Password");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnNewUser_Click(object sender, EventArgs e) {
            NewMemberForm newMember = new NewMemberForm();

            newMember.ShowDialog();
        }
    }
}