using BoxBreakerVideo.Forms;
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
        /// opens a new form to rent a movie is user login is successful
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e) {
            //make new connection to the database
            BoxBreakerVideoContext database = new BoxBreakerVideoContext();

            //if credentials are valid based on Where query, open rental form
            if (database.Members.Where(data => data.MemberEmail == txtbxEmail.Text && data.MemberPassword == txtbxPassword.Text).Any())
            {
                //Retrieve logged-in members data
                Member loggedInMember = database.Members.FirstOrDefault(data => data.MemberEmail == txtbxEmail.Text && data.MemberPassword == txtbxPassword.Text);

                //Store member's full name in variable
                string memberFullName = $"{loggedInMember.MemberFname} {loggedInMember.MemberLname}";

                FormRentalForm newRental = new FormRentalForm(memberFullName, loggedInMember.MemberId);
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

        private void button1_Click(object sender, EventArgs e) {
            if (txtbxEmail.Text.Contains("test.com")) {
                AdminForm admin = new AdminForm();
                admin.ShowDialog();
            }
            else {
                MessageBox.Show("Access Denied");
            }
        }
    }
}