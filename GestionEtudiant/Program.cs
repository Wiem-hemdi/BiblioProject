using System;
using System.Windows.Forms;
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
            context.Database.EnsureCreated(); // Ensures DB file and tables exist

            context.Seed(force: true);


            // Launch form with context
            Application.Run(new GestionLivresForm(context));
        }
    }
}
