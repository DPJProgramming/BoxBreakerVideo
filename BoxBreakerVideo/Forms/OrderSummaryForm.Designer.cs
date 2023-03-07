namespace BoxBreakerVideo.Forms
{
    partial class OrderSummaryForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstviewRented = new ListView();
            label4 = new Label();
            txtbxFName = new TextBox();
            txtbxTotal = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dtpDO = new DateTimePicker();
            dtpDR = new DateTimePicker();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 45);
            label1.TabIndex = 0;
            label1.Text = "Order Summary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 2;
            label3.Text = "Movies Rented";
            // 
            // lstviewRented
            // 
            lstviewRented.Location = new Point(12, 126);
            lstviewRented.Name = "lstviewRented";
            lstviewRented.Size = new Size(291, 195);
            lstviewRented.TabIndex = 3;
            lstviewRented.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 403);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 4;
            label4.Text = "Order Total";
            // 
            // txtbxFName
            // 
            txtbxFName.Enabled = false;
            txtbxFName.Location = new Point(79, 74);
            txtbxFName.Name = "txtbxFName";
            txtbxFName.Size = new Size(224, 23);
            txtbxFName.TabIndex = 5;
            // 
            // txtbxTotal
            // 
            txtbxTotal.Enabled = false;
            txtbxTotal.Location = new Point(103, 395);
            txtbxTotal.Name = "txtbxTotal";
            txtbxTotal.Size = new Size(85, 23);
            txtbxTotal.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 339);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 7;
            label5.Text = "Date Ordered";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 372);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 8;
            label6.Text = "Date of Return";
            // 
            // dtpDO
            // 
            dtpDO.Enabled = false;
            dtpDO.Location = new Point(103, 333);
            dtpDO.Name = "dtpDO";
            dtpDO.Size = new Size(200, 23);
            dtpDO.TabIndex = 9;
            // 
            // dtpDR
            // 
            dtpDR.Enabled = false;
            dtpDR.Location = new Point(103, 366);
            dtpDR.Name = "dtpDR";
            dtpDR.Size = new Size(200, 23);
            dtpDR.TabIndex = 10;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(12, 431);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(145, 72);
            btnConfirm.TabIndex = 11;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(181, 431);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 72);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // OrderSummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 515);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(dtpDR);
            Controls.Add(dtpDO);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtbxTotal);
            Controls.Add(txtbxFName);
            Controls.Add(label4);
            Controls.Add(lstviewRented);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderSummaryForm";
            Text = "OrderSummaryForm";
            Load += OrderSummaryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListView lstviewRented;
        private Label label4;
        private TextBox txtbxFName;
        private TextBox txtbxTotal;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpDO;
        private DateTimePicker dtpDR;
        private Button btnConfirm;
        private Button btnCancel;
    }
}