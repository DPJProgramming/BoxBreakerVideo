namespace BoxBreakerVideo.Forms
{
    partial class AdminForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtbxDeleteMovie = new TextBox();
            txtbxDeleteMember = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(506, 50);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(123, 38);
            button1.TabIndex = 0;
            button1.Text = "Delete Movie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(506, 99);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(123, 38);
            button2.TabIndex = 1;
            button2.Text = "Remove Member";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(108, 206);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(158, 58);
            button3.TabIndex = 2;
            button3.Text = "Add Movie";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(375, 206);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(158, 58);
            button4.TabIndex = 3;
            button4.Text = "Edit Movie";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(241, 287);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(158, 58);
            button5.TabIndex = 4;
            button5.Text = "Cancel";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 64);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 5;
            label1.Text = "Remove Movie By Movie Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 110);
            label2.Name = "label2";
            label2.Size = new Size(191, 15);
            label2.TabIndex = 6;
            label2.Text = "Remove Member By Email Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 174);
            label3.Name = "label3";
            label3.Size = new Size(127, 30);
            label3.TabIndex = 7;
            label3.Text = "              Or\r\n------------------------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(241, 15);
            label4.Name = "label4";
            label4.Size = new Size(162, 30);
            label4.TabIndex = 8;
            label4.Text = "Remove Movie or Member\r\n-------------------------------\r\n";
            // 
            // txtbxDeleteMovie
            // 
            txtbxDeleteMovie.Location = new Point(271, 62);
            txtbxDeleteMovie.Margin = new Padding(3, 2, 3, 2);
            txtbxDeleteMovie.Name = "txtbxDeleteMovie";
            txtbxDeleteMovie.Size = new Size(210, 23);
            txtbxDeleteMovie.TabIndex = 9;
            // 
            // txtbxDeleteMember
            // 
            txtbxDeleteMember.Location = new Point(271, 108);
            txtbxDeleteMember.Margin = new Padding(3, 2, 3, 2);
            txtbxDeleteMember.Name = "txtbxDeleteMember";
            txtbxDeleteMember.Size = new Size(210, 23);
            txtbxDeleteMember.TabIndex = 10;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 367);
            Controls.Add(txtbxDeleteMember);
            Controls.Add(txtbxDeleteMovie);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            Text = "Administrator Access";
            Load += AdminForm_Load;
            ResumeLayout(false);
            PerformLayout();
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