using System;
using System.Windows.Forms;
using GestionEtudiant;
using GestionLivre.Data.Context; // Make sure this is the correct namespace
using Microsoft.EntityFrameworkCore;

namespace GestionLivre
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using var context = new LibraryContext();
            context.Database.Migrate();
            context.Seed(force: true);

            Application.Run(new LoginForm(context)); // <- démarre avec le formulaire de connexion
        }
    }
}
