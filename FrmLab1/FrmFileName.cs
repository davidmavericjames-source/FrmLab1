using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrmLab1
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName = ""; 
        public FrmFileName()
        {
            InitializeComponent();
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmFileName_Load(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName.Text + ".txt"; 
            
            
            this.Close(); 
        }
    }
}
