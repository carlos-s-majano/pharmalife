using Pharmalife.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmalife
{
    public partial class LoginForm : Form
    {
        UserController userController = new UserController();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if(this.userController.loginVerify(txtUsername.Text, txtPassword.Text))
            {
                HomeForm homeForm = new HomeForm();
                this.Hide();
                homeForm.Show();
            }
            else
            {
                MessageBox.Show("Los credenciales ingresados no corresponden a un usuario registrado", "USUARIO NO ENCONTRADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
