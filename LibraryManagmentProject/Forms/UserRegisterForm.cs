using LibraryManagmentProject.Models;
using LibraryManagmentProject.Repositories;
using LibraryManagmentProject.Services;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentProject.Forms
{
    public partial class UserRegisterForm : Form
    {
        public UserRegisterForm()
        {
            InitializeComponent();
        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = registerNameInput.Text;
            string password = registerPasswordInput.Text;
            string confirmPassword = registerConfirmPasswordInput.Text;

            if(!password.Equals(confirmPassword) 
                || password.IsNullOrEmpty() 
                || confirmPassword.IsNullOrEmpty())
            {
                MessageBox.Show("Passwords do not match or it's blank");
                return;
            } else
            {
                var userService = new UserService(new PasswordHasher(), new UserRepository());

                bool isRegistered = userService.RegisterUser(username, password);

                if (isRegistered)
                {
                    MessageBox.Show("User registered successfully");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("User registration failed. Username might already be taken.");
                }

            }

        }
    }
}
