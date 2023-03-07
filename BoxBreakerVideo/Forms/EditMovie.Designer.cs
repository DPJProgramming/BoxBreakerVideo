namespace BoxBreakerVideo.Forms
{
    partial class EditMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbxMovie = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtpReleaseDate = new DateTimePicker();
            label9 = new Label();
            txtbxTitle = new TextBox();
            txtbxLink = new TextBox();
            txtbxDesc = new TextBox();
            txtbxRuntime = new TextBox();
            txtbxPrice = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            cbxGenre = new ComboBox();
            cbxMaturityRating = new ComboBox();
            SuspendLayout();
            // 
            // cbxMovie
            // 
            cbxMovie.FormattingEnabled = true;
            cbxMovie.Location = new Point(105, 35);
            cbxMovie.Name = "cbxMovie";
            cbxMovie.Size = new Size(156, 23);
            cbxMovie.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Selected Movie";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 152);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 204);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 4;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 38);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 5;
            label5.Text = "Runtime (ex. 120 min)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 103);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 6;
            label6.Text = "Maturity Rating";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(401, 152);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 7;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(451, 204);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 8;
            label8.Text = "Release Date";
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(401, 222);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(200, 23);
            dtpReleaseDate.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(414, 296);
            label9.Name = "label9";
            label9.Size = new Size(165, 15);
            label9.TabIndex = 10;
            label9.Text = "Link to Image of Movie Poster";
            // 
            // txtbxTitle
            // 
            txtbxTitle.Location = new Point(75, 100);
            txtbxTitle.Name = "txtbxTitle";
            txtbxTitle.Size = new Size(100, 23);
            txtbxTitle.TabIndex = 11;
            // 
            // txtbxLink
            // 
            txtbxLink.Location = new Point(401, 341);
            txtbxLink.Name = "txtbxLink";
            txtbxLink.Size = new Size(200, 23);
            txtbxLink.TabIndex = 12;
            // 
            // txtbxDesc
            // 
            txtbxDesc.Location = new Point(12, 225);
            txtbxDesc.Multiline = true;
            txtbxDesc.Name = "txtbxDesc";
            txtbxDesc.Size = new Size(249, 139);
            txtbxDesc.TabIndex = 13;
            // 
            // txtbxRuntime
            // 
            txtbxRuntime.Location = new Point(549, 35);
            txtbxRuntime.Name = "txtbxRuntime";
            txtbxRuntime.Size = new Size(100, 23);
            txtbxRuntime.TabIndex = 14;
            // 
            // txtbxPrice
            // 
            txtbxPrice.Location = new Point(451, 144);
            txtbxPrice.Name = "txtbxPrice";
            txtbxPrice.Size = new Size(100, 23);
            txtbxPrice.TabIndex = 15;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(12, 395);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(249, 52);
            btnConfirm.TabIndex = 16;
            btnConfirm.Text = "Confirm Edit";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(401, 395);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(248, 52);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbxGenre
            // 
            cbxGenre.FormattingEnabled = true;
            cbxGenre.Location = new Point(75, 149);
            cbxGenre.Name = "cbxGenre";
            cbxGenre.Size = new Size(144, 23);
            cbxGenre.TabIndex = 18;
            // 
            // cbxMaturityRating
            // 
            cbxMaturityRating.FormattingEnabled = true;
            cbxMaturityRating.Location = new Point(514, 100);
            cbxMaturityRating.Name = "cbxMaturityRating";
            cbxMaturityRating.Size = new Size(121, 23);
            cbxMaturityRating.TabIndex = 19;
            // 
            // EditMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 459);
            Controls.Add(cbxMaturityRating);
            Controls.Add(cbxGenre);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtbxPrice);
            Controls.Add(txtbxRuntime);
            Controls.Add(txtbxDesc);
            Controls.Add(txtbxLink);
            Controls.Add(txtbxTitle);
            Controls.Add(label9);
            Controls.Add(dtpReleaseDate);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxMovie);
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditMovie";
            Text = "Edit Movie";
            Load += EditMovie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxMovie;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpReleaseDate;
        private Label label9;
        private TextBox txtbxTitle;
        private TextBox txtbxLink;
        private TextBox txtbxDesc;
        private TextBox txtbxRuntime;
        private TextBox txtbxPrice;
        private Button btnConfirm;
        private Button btnCancel;
        private ComboBox cbxGenre;
        private ComboBox cbxMaturityRating;
    }
}