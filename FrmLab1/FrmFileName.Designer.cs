namespace FrmLab1
{
    partial class FrmFileName
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
            txtFileName = new TextBox();
            btnOkay = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Segoe UI", 25F);
            txtFileName.Location = new Point(92, 102);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(276, 52);
            txtFileName.TabIndex = 0;
            txtFileName.TextChanged += txtFileName_TextChanged;
            // 
            // btnOkay
            // 
            btnOkay.Font = new Font("Segoe UI", 15F);
            btnOkay.Location = new Point(145, 185);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(118, 52);
            btnOkay.TabIndex = 1;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnOkay_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(92, 25);
            label1.Name = "label1";
            label1.Size = new Size(256, 46);
            label1.TabIndex = 2;
            label1.Text = "Enter File Name";
            // 
            // FrmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 303);
            Controls.Add(label1);
            Controls.Add(btnOkay);
            Controls.Add(txtFileName);
            Name = "FrmFileName";
            Text = "FrmFileName";
            Load += FrmFileName_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFileName;
        private Button btnOkay;
        private Label label1;
    }
}