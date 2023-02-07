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

                //validate user login data
                //make new connection to database
            BoxBreakerVideoContext connection = new BoxBreakerVideoContext();

                //make a list of member objects from member table
            List<Member> memberList = connection.Members.ToList(); 

                //check each memebers email and password in table and compare with Login form input
            foreach (Member validMember in memberList) {
                    
                    //if valid, open rental form
                if (validMember.MemberEmail == txtbxEmail.Text && validMember.MemberPassword == txtbxPassword.Text) {
                    FormRentalForm newRental = new FormRentalForm();
                    newRental.ShowDialog();
                    break;
                }
                    //if invalid popup a notice
                else {
                    MessageBox.Show("Invalid Email or Password");
                    break;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}