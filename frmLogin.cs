/**
 * Ahthesham Ali Syed 
 * CSC 224 
 * 02/25/2023
 * PA-3 Program to Experiment a Model Form and File I/O
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
              if(txtUsername.Text == "Zelda" && txtPassword.Text == "password")
            {
                DialogResult = DialogResult.OK;
            }
            else 
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
