namespace BoxBreakerVideo {
	public partial class formUserLogin : Form {
		public formUserLogin() {
			InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e) {

        }

        /// <summary>
        /// opens a new form to rent a movie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e) {

            //validate user login data

            FormRentalForm newRental = new FormRentalForm();

            //fill drop down list of available movies ect

            newRental.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}