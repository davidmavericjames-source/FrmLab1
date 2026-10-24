using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmLab1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string[] lines =
            {
                "Student No.:" + txtStudentNo.Text,
                "Full Name:" + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMI.Text,
                "Program: " + cboProgram.Text,
                "Gender: " + cboGender.Text,
                "Age: " + txtAge.Text,
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
                "Contact No." + txtContactNo.Text.TrimStart('0')
            };

            using (StreamWriter outputFile =
                   new StreamWriter(Path.Combine(docPath, txtStudentNo.Text + ".txt")))
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
            }

            MessageBox.Show("Registration saved!");
        }
    }
}
