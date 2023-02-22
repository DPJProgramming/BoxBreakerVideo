namespace BoxBreakerVideo
{
    partial class FormRentalForm
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
            gbxMovie = new GroupBox();
            label7 = new Label();
            btnCancel = new Button();
            btnCheckout = new Button();
            btnAdd = new Button();
            label6 = new Label();
            txtbxDesc = new TextBox();
            pbxPoster = new PictureBox();
            label5 = new Label();
            txtbxPrice = new TextBox();
            label4 = new Label();
            txtbxGenre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtbxRating = new TextBox();
            txtbxTitle = new TextBox();
            lstViewOrder = new ListView();
            label8 = new Label();
            txtbxTotal = new TextBox();
            btnClear = new Button();
            gbxMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPoster).BeginInit();
            SuspendLayout();
            // 
            // cbxMovie
            // 
            cbxMovie.FormattingEnabled = true;
            cbxMovie.Location = new Point(12, 12);
            cbxMovie.Name = "cbxMovie";
            cbxMovie.Size = new Size(137, 23);
            cbxMovie.TabIndex = 0;
            cbxMovie.SelectedIndexChanged += cbxMovie_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 15);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 1;
            label1.Text = "Movies Available to Rent";
            // 
            // gbxMovie
            // 
            gbxMovie.Controls.Add(label7);
            gbxMovie.Controls.Add(btnCancel);
            gbxMovie.Controls.Add(btnCheckout);
            gbxMovie.Controls.Add(btnAdd);
            gbxMovie.Controls.Add(label6);
            gbxMovie.Controls.Add(txtbxDesc);
            gbxMovie.Controls.Add(pbxPoster);
            gbxMovie.Controls.Add(label5);
            gbxMovie.Controls.Add(txtbxPrice);
            gbxMovie.Controls.Add(label4);
            gbxMovie.Controls.Add(txtbxGenre);
            gbxMovie.Controls.Add(label3);
            gbxMovie.Controls.Add(label2);
            gbxMovie.Controls.Add(txtbxRating);
            gbxMovie.Controls.Add(txtbxTitle);
            gbxMovie.Location = new Point(12, 153);
            gbxMovie.Name = "gbxMovie";
            gbxMovie.Size = new Size(523, 302);
            gbxMovie.TabIndex = 2;
            gbxMovie.TabStop = false;
            gbxMovie.Text = "Movie Details";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(383, 19);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 14;
            label7.Text = "Poster";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(383, 257);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 36);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(383, 214);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(134, 37);
            btnCheckout.TabIndex = 12;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(383, 167);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 41);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add to Order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(160, 19);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 10;
            label6.Text = "Description";
            // 
            // txtbxDesc
            // 
            txtbxDesc.Enabled = false;
            txtbxDesc.Location = new Point(160, 37);
            txtbxDesc.Multiline = true;
            txtbxDesc.Name = "txtbxDesc";
            txtbxDesc.Size = new Size(217, 256);
            txtbxDesc.TabIndex = 9;
            // 
            // pbxPoster
            // 
            pbxPoster.Location = new Point(383, 37);
            pbxPoster.Name = "pbxPoster";
            pbxPoster.Size = new Size(134, 115);
            pbxPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPoster.TabIndex = 8;
            pbxPoster.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 243);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 7;
            label5.Text = "Price";
            // 
            // txtbxPrice
            // 
            txtbxPrice.Enabled = false;
            txtbxPrice.Location = new Point(6, 261);
            txtbxPrice.Name = "txtbxPrice";
            txtbxPrice.Size = new Size(57, 23);
            txtbxPrice.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 96);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "Genre";
            // 
            // txtbxGenre
            // 
            txtbxGenre.Enabled = false;
            txtbxGenre.Location = new Point(6, 114);
            txtbxGenre.Name = "txtbxGenre";
            txtbxGenre.Size = new Size(131, 23);
            txtbxGenre.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 167);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "Rating";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // txtbxRating
            // 
            txtbxRating.Enabled = false;
            txtbxRating.Location = new Point(6, 185);
            txtbxRating.Name = "txtbxRating";
            txtbxRating.Size = new Size(57, 23);
            txtbxRating.TabIndex = 1;
            // 
            // txtbxTitle
            // 
            txtbxTitle.Enabled = false;
            txtbxTitle.Location = new Point(6, 37);
            txtbxTitle.Name = "txtbxTitle";
            txtbxTitle.Size = new Size(131, 23);
            txtbxTitle.TabIndex = 0;
            // 
            // lstViewOrder
            // 
            lstViewOrder.Location = new Point(298, 15);
            lstViewOrder.Name = "lstViewOrder";
            lstViewOrder.Size = new Size(237, 110);
            lstViewOrder.TabIndex = 3;
            lstViewOrder.UseCompatibleStateImageBehavior = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(391, 135);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 4;
            label8.Text = "Total";
            // 
            // txtbxTotal
            // 
            txtbxTotal.Enabled = false;
            txtbxTotal.Location = new Point(429, 131);
            txtbxTotal.Name = "txtbxTotal";
            txtbxTotal.Size = new Size(100, 23);
            txtbxTotal.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(298, 131);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear Order";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // FormRentalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 467);
            Controls.Add(btnClear);
            Controls.Add(txtbxTotal);
            Controls.Add(label8);
            Controls.Add(lstViewOrder);
            Controls.Add(gbxMovie);
            Controls.Add(label1);
            Controls.Add(cbxMovie);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormRentalForm";
            Text = "RentalForm";
            Load += FormRentalForm_Load;
            gbxMovie.ResumeLayout(false);
            gbxMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private ListView lstViewOrder;
        private Label label8;
        private TextBox txtbxTotal;
        private Button btnClear;
    }
}