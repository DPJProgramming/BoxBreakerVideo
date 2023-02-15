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
            //BoxBreakerVideoContext.Update();
            using BoxBreakerVideoContext database = new();

            //validate inputs

            if (validInputs()) {
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

        }

        /// <summary>
        /// validates input from new member form
        /// </summary>
        /// <returns> true if inputs are valid false if not</returns>
        private bool validInputs() {
            return true;
        }
    }
}
