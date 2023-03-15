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
            BoxBreakerVideoContext database = new();

            if (validInputs(database)) {

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
        private bool validInputs(BoxBreakerVideoContext database) {

            //validate first name
            //if its blank or contains something other than letters
            if (txtbxFirstName.Text.Equals("") || !txtbxFirstName.Text.All(Char.IsLetter)) {
                return false;
            }

            //validate last name
            //if its blank or contains something other than letters
            if (txtbxLastName.Text.Equals("") || !txtbxLastName.Text.All(Char.IsLetter)) {
                return false;
            }

            //validate Email
            //if field is blank or in the wrong format
            if (string.IsNullOrWhiteSpace(txtbxEmail.Text)) {
                return false;
            }
            try { 
                var emailAddress = new MailAddress(txtbxEmail.Text);
            }
            catch {
                return false;
            }

            //Checks if email is already in the database
            var doesEmailExist = database.Members.Where(m => m.MemberEmail == txtbxEmail.Text);
            if (doesEmailExist != null) {
                MessageBox.Show("Email already exists");
                return false;
            }
            
            //validate shipping address
            //if it's blank
            if(txtbxAddress.Text == "") {
                return false;
            }

            //validate password
            if(txtbxPassword.Text == "") {
                return false;
            }

            //validate phone number
            //if there is anything except a number
            //if not filled completely
            if(txtbxPhone.Text == "" || !txtbxPhone.MaskCompleted) {
                return false;
            }
            return true;
        }
    }
}
