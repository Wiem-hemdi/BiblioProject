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

namespace GestionEtudiant
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository _userRepo;
        private readonly LibraryContext _context;

        public LoginForm(LibraryContext context)
        {
            InitializeComponent();
            _context = context;
            _userRepo = new UserRepository(_context);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (_userRepo.ValidateLogin(username, password))
            {
                // Authentification réussie : ouvrir GestionLivresForm
                var gestionForm = new GestionLivresForm(_context);
                gestionForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
            }
        }
    }
}

