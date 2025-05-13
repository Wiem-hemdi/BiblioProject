using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionLivre;
using GestionLivre.Data.Context;
using GestionLivre.Data.Repositories;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;

namespace GestionEtudiant
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository _userRepo;
        private readonly IServiceProvider _serviceProvider;

        public LoginForm(UserRepository userRepo, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _userRepo = userRepo;
            _serviceProvider = serviceProvider;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (_userRepo.ValidateLogin(username, password))
            {
                var mainForm = _serviceProvider.GetRequiredService<MainForm>();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
            }
        }
    }
}

