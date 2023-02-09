namespace BoxBreakerVideo {
    partial class FormRentalForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.cbxMovie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxMovie = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxDesc = new System.Windows.Forms.TextBox();
            this.pbxPoster = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxGenre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxRating = new System.Windows.Forms.TextBox();
            this.txtbxTitle = new System.Windows.Forms.TextBox();
            this.gbxMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxMovie
            // 
            this.cbxMovie.FormattingEnabled = true;
            this.cbxMovie.Location = new System.Drawing.Point(12, 12);
            this.cbxMovie.Name = "cbxMovie";
            this.cbxMovie.Size = new System.Drawing.Size(137, 23);
            this.cbxMovie.TabIndex = 0;
            this.cbxMovie.SelectedIndexChanged += new System.EventHandler(this.cbxMovie_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movies Available to Rent";
            // 
            // gbxMovie
            // 
            this.gbxMovie.Controls.Add(this.label7);
            this.gbxMovie.Controls.Add(this.btnCancel);
            this.gbxMovie.Controls.Add(this.btnCheckout);
            this.gbxMovie.Controls.Add(this.btnAdd);
            this.gbxMovie.Controls.Add(this.label6);
            this.gbxMovie.Controls.Add(this.txtbxDesc);
            this.gbxMovie.Controls.Add(this.pbxPoster);
            this.gbxMovie.Controls.Add(this.label5);
            this.gbxMovie.Controls.Add(this.txtbxPrice);
            this.gbxMovie.Controls.Add(this.label4);
            this.gbxMovie.Controls.Add(this.txtbxGenre);
            this.gbxMovie.Controls.Add(this.label3);
            this.gbxMovie.Controls.Add(this.label2);
            this.gbxMovie.Controls.Add(this.txtbxRating);
            this.gbxMovie.Controls.Add(this.txtbxTitle);
            this.gbxMovie.Location = new System.Drawing.Point(12, 116);
            this.gbxMovie.Name = "gbxMovie";
            this.gbxMovie.Size = new System.Drawing.Size(523, 302);
            this.gbxMovie.TabIndex = 2;
            this.gbxMovie.TabStop = false;
            this.gbxMovie.Text = "Movie Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Poster";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(383, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 36);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(383, 214);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(134, 37);
            this.btnCheckout.TabIndex = 12;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(383, 167);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 41);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add to Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Description";
            // 
            // txtbxDesc
            // 
            this.txtbxDesc.Enabled = false;
            this.txtbxDesc.Location = new System.Drawing.Point(160, 37);
            this.txtbxDesc.Multiline = true;
            this.txtbxDesc.Name = "txtbxDesc";
            this.txtbxDesc.Size = new System.Drawing.Size(217, 256);
            this.txtbxDesc.TabIndex = 9;
            // 
            // pbxPoster
            // 
            this.pbxPoster.Location = new System.Drawing.Point(383, 37);
            this.pbxPoster.Name = "pbxPoster";
            this.pbxPoster.Size = new System.Drawing.Size(134, 115);
            this.pbxPoster.TabIndex = 8;
            this.pbxPoster.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // txtbxPrice
            // 
            this.txtbxPrice.Enabled = false;
            this.txtbxPrice.Location = new System.Drawing.Point(6, 261);
            this.txtbxPrice.Name = "txtbxPrice";
            this.txtbxPrice.Size = new System.Drawing.Size(57, 23);
            this.txtbxPrice.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Genre";
            // 
            // txtbxGenre
            // 
            this.txtbxGenre.Enabled = false;
            this.txtbxGenre.Location = new System.Drawing.Point(6, 114);
            this.txtbxGenre.Name = "txtbxGenre";
            this.txtbxGenre.Size = new System.Drawing.Size(131, 23);
            this.txtbxGenre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // txtbxRating
            // 
            this.txtbxRating.Enabled = false;
            this.txtbxRating.Location = new System.Drawing.Point(6, 185);
            this.txtbxRating.Name = "txtbxRating";
            this.txtbxRating.Size = new System.Drawing.Size(57, 23);
            this.txtbxRating.TabIndex = 1;
            // 
            // txtbxTitle
            // 
            this.txtbxTitle.Enabled = false;
            this.txtbxTitle.Location = new System.Drawing.Point(6, 37);
            this.txtbxTitle.Name = "txtbxTitle";
            this.txtbxTitle.Size = new System.Drawing.Size(131, 23);
            this.txtbxTitle.TabIndex = 0;
            // 
            // FormRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 426);
            this.Controls.Add(this.gbxMovie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxMovie);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormRentalForm";
            this.Text = "RentalForm";
            this.gbxMovie.ResumeLayout(false);
            this.gbxMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbxMovie;
        private GroupBox gbxMovie;
        private PictureBox pbxPoster;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtbxTitle;
        private TextBox txtbxPrice;
        private TextBox txtbxGenre;
        private TextBox txtbxDesc;
        private TextBox txtbxRating;
        private Button btnCancel;
        private Button btnCheckout;
        private Button btnAdd;
        
    }
}