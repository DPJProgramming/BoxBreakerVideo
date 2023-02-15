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
            //BoxBreakerVideoContext.Update();
            //make new connection to database
            BoxBreakerVideoContext connection = new BoxBreakerVideoContext();

            //make a list of member objects from member table
            List<Member> memberList = connection.Members.ToList(); 

            //check each members email and password in table and compare with Login form input
            foreach (Member validMember in memberList) {
                Console.WriteLine(validMember.MemberEmail);
                Console.WriteLine(validMember.MemberPassword);

                //if valid, open rental form
                if (validMember.MemberEmail == txtbxEmail.Text && validMember.MemberPassword == txtbxPassword.Text) {

                    FormRentalForm newRental = new FormRentalForm();
                    newRental.ShowDialog();
                    break;
                }
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