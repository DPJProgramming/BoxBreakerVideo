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
using System.Net.Mail; //used for validating email
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BoxBreakerVideo {
    public partial class NewMemberForm : Form {
        public NewMemberForm() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }


        /// <summary>
        /// opens connection to the database and adds the new member to the members table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {

            if (validInputs()) {
                using BoxBreakerVideoContext database = new();

                //insert into database
                Member newMember = new Member() {
                    MemberFname = txtbxFirstName.Text,
                    MemberLname = txtbxLastName.Text,
                    MemberEmail = txtbxEmail.Text,
                    MemberPhone = txtbxPhone.Text,
                    MemberAddress= txtbxAddress.Text,
                    MemberPassword = txtbxPassword.Text
                };
                database.Members.Add(newMember);
                database.SaveChanges();
                MessageBox.Show("Registration Successfull");
                Close();
            }
            else {
                MessageBox.Show("Registration Unsuccessfull");
            }

        }

        /// <summary>
        /// validates input from new member form
        /// </summary>
        /// <returns> true if inputs are valid false if not</returns>
        private bool validInputs() {

            //validate first name
            if (txtbxFirstName.Text.Equals("") || !txtbxFirstName.Text.All(Char.IsLetter)) {
                return false;
            }

            //validate last name
            if (txtbxLastName.Text.Equals("") || !txtbxLastName.Text.All(Char.IsLetter)) {
                return false;
            }

            //validate Email
            if (txtbxEmail.Text.Equals("")) {
                return false;
            }

            //second email validation
            try { 
                var emailAddress = new MailAddress(txtbxEmail.Text);
            }
            catch {
                return false;
            }      
            return true;
        }
    }
}
