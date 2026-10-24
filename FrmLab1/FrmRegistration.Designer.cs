namespace FrmLab1
{
    partial class FrmRegistration
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtFirstName = new TextBox();
            txtMI = new TextBox();
            txtContactNo = new TextBox();
            cboProgram = new ComboBox();
            cboGender = new ComboBox();
            dtpBirthday = new DateTimePicker();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(30, 18);
            label1.Name = "label1";
            label1.Size = new Size(199, 46);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Student No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 179);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 227);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 85);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 5;
            label6.Text = "Program";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(325, 133);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 6;
            label7.Text = "FirstName";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(325, 179);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 7;
            label8.Text = "Gender:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(565, 133);
            label9.Name = "label9";
            label9.Size = new Size(27, 15);
            label9.TabIndex = 8;
            label9.Text = "M.I.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(365, 227);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 9;
            label10.Text = "Contact No.";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(98, 77);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(150, 23);
            txtStudentNo.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(98, 125);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 23);
            txtLastName.TabIndex = 11;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(98, 179);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 12;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(392, 130);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(138, 23);
            txtFirstName.TabIndex = 13;
            // 
            // txtMI
            // 
            txtMI.Location = new Point(598, 130);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(78, 23);
            txtMI.TabIndex = 14;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(442, 224);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(139, 23);
            txtContactNo.TabIndex = 15;
            // 
            // cboProgram
            // 
            cboProgram.FormattingEnabled = true;
            cboProgram.Items.AddRange(new object[] { "BS Information Technology", "BS Biology", "BS Computer Engineering", "BS Nursing" });
            cboProgram.Location = new Point(387, 82);
            cboProgram.Name = "cboProgram";
            cboProgram.Size = new Size(194, 23);
            cboProgram.TabIndex = 16;
            // 
            // cboGender
            // 
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "MALE", "FEMALE" });
            cboGender.Location = new Point(392, 176);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(99, 23);
            cboGender.TabIndex = 17;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(88, 224);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 18;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(264, 276);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(122, 44);
            btnRegister.TabIndex = 19;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 347);
            Controls.Add(btnRegister);
            Controls.Add(dtpBirthday);
            Controls.Add(cboGender);
            Controls.Add(cboProgram);
            Controls.Add(txtContactNo);
            Controls.Add(txtMI);
            Controls.Add(txtFirstName);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private TextBox txtMI;
        private TextBox txtContactNo;
        private ComboBox cboProgram;
        private ComboBox cboGender;
        private DateTimePicker dtpBirthday;
        private Button btnRegister;
    }
}