using LibraryManagmentProject.Models;
using LibraryManagmentProject.Repositories;
using LibraryManagmentProject.Services;
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
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            UserRegisterForm UserRegisterForm = new UserRegisterForm();
            UserRegisterForm.ShowDialog();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService(new PasswordHasher(), new UserRepository());
            string username = registerNameInput.Text;
            string password = registerPasswordInput.Text;
            if (userService.LoginUser(username, password))
            {
                UserRepository userRepository = new UserRepository();
                User loggedUser = userRepository.GetUserByUsername(username);
                LibraryMainForm libraryMainForm = new LibraryMainForm(loggedUser);
                libraryMainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
