namespace BoxBreakerVideo.Forms {
    partial class MemberAccount {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lstbxMovieTitles = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstbxCheckoutDate = new System.Windows.Forms.ListBox();
            this.lstbxDueDate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(255, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(191, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movies Currently Checked Out";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(403, 23);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 41);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "User";
            // 
            // lstbxMovieTitles
            // 
            this.lstbxMovieTitles.FormattingEnabled = true;
            this.lstbxMovieTitles.ItemHeight = 20;
            this.lstbxMovieTitles.Location = new System.Drawing.Point(28, 173);
            this.lstbxMovieTitles.Name = "lstbxMovieTitles";
            this.lstbxMovieTitles.Size = new System.Drawing.Size(217, 244);
            this.lstbxMovieTitles.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Check Out Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Due Date";
            // 
            // lstbxCheckoutDate
            // 
            this.lstbxCheckoutDate.FormattingEnabled = true;
            this.lstbxCheckoutDate.ItemHeight = 20;
            this.lstbxCheckoutDate.Location = new System.Drawing.Point(282, 173);
            this.lstbxCheckoutDate.Name = "lstbxCheckoutDate";
            this.lstbxCheckoutDate.Size = new System.Drawing.Size(219, 244);
            this.lstbxCheckoutDate.TabIndex = 7;
            // 
            // lstbxDueDate
            // 
            this.lstbxDueDate.FormattingEnabled = true;
            this.lstbxDueDate.ItemHeight = 20;
            this.lstbxDueDate.Location = new System.Drawing.Point(555, 173);
            this.lstbxDueDate.Name = "lstbxDueDate";
            this.lstbxDueDate.Size = new System.Drawing.Size(219, 244);
            this.lstbxDueDate.TabIndex = 8;
            // 
            // MemberAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbxDueDate);
            this.Controls.Add(this.lstbxCheckoutDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstbxMovieTitles);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MemberAccount";
            this.Text = "MemberAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblFirstName;
        private ListBox lstbxMovieTitles;
        private Label label3;
        private Label label4;
        private Label label5;
        private ListBox lstbxCheckoutDate;
        private ListBox lstbxDueDate;
    }
}