namespace BoxBreakerVideo.Forms {
    partial class AdminForm {
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxDeleteMovie = new System.Windows.Forms.TextBox();
            this.txtbxDeleteMember = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Delete Movie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove Member";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 78);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Movie";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(429, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 78);
            this.button4.TabIndex = 3;
            this.button4.Text = "Edit Movie";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(275, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 78);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Remove Movie By Movie Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Remove Member By Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "              Or\r\n------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Remove Movie or Member\r\n-------------------------------\r\n";
            // 
            // txtbxDeleteMovie
            // 
            this.txtbxDeleteMovie.Location = new System.Drawing.Point(310, 83);
            this.txtbxDeleteMovie.Name = "txtbxDeleteMovie";
            this.txtbxDeleteMovie.Size = new System.Drawing.Size(239, 27);
            this.txtbxDeleteMovie.TabIndex = 9;
            // 
            // txtbxDeleteMember
            // 
            this.txtbxDeleteMember.Location = new System.Drawing.Point(310, 144);
            this.txtbxDeleteMember.Name = "txtbxDeleteMember";
            this.txtbxDeleteMember.Size = new System.Drawing.Size(239, 27);
            this.txtbxDeleteMember.TabIndex = 10;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.txtbxDeleteMember);
            this.Controls.Add(this.txtbxDeleteMovie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AdminForm";
            this.Text = "Administrator Access";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtbxDeleteMovie;
        private TextBox txtbxDeleteMember;
    }
}