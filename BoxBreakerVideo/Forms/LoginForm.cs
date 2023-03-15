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
        /// opens a new form to rent a movie if user login is successful
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e) {
            //make new connection to the database
            BoxBreakerVideoContext database = new BoxBreakerVideoContext();

            //if credentials are valid based on Where query, open rental form
            if (isValid(database)) {
                //Retrieve logged-in members data
                Member loggedInMember = GetLoggedInMember(database);

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

        /// <summary>
        /// makes a member object from login credentials
        /// </summary>
        /// <param name="database"></param>
        /// <returns></returns>
        private Member? GetLoggedInMember(BoxBreakerVideoContext database) {
            return database.Members.FirstOrDefault(data => data.MemberEmail == txtbxEmail.Text && data.MemberPassword == txtbxPassword.Text);
        }

        /// <summary>
        /// checks if logging in member is in database aka already a member
        /// </summary>
        /// <param name="database"></param>
        /// <returns></returns>
        private bool isValid(BoxBreakerVideoContext database) {
            return database.Members.Where(data => data.MemberEmail == txtbxEmail.Text && data.MemberPassword == txtbxPassword.Text).Any();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnNewUser_Click(object sender, EventArgs e) {
            NewMemberForm newMember = new NewMemberForm();
            newMember.ShowDialog();
        }

        /// <summary>
        /// Opens an administration form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {

            BoxBreakerVideoContext database = new BoxBreakerVideoContext();

            string enteredEmail = txtbxEmail.Text;
            Member administrator = database.Members.FirstOrDefault(a => a.MemberEmail.EndsWith("test.com"));

            if (administrator != null && administrator.MemberEmail == enteredEmail) {
                AdminForm admin = new AdminForm();
                admin.ShowDialog();
            }
            else {
                MessageBox.Show("Access Denied");
            }
        }

        /// <summary>
        /// Opens a form which Allows a member to view their currently checked out movies if their login credentials are valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewAccount_Click(object sender, EventArgs e) {

            BoxBreakerVideoContext database = new BoxBreakerVideoContext();
            
            if (isValid(database)) {

                Member loggedInMember = GetLoggedInMember(database);
                MemberAccount accountForm = new MemberAccount(loggedInMember, database);
                accountForm.ShowDialog();
            }
        }
    }
}