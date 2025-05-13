using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using GestionLivre.Data.Context;
using Microsoft.EntityFrameworkCore;
using GestionEtudiant; // Make sure this namespace includes your ServiceCollectionExtensions and your forms
using GestionLivre.Data;

namespace GestionLivre
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Configure DI
            var services = new ServiceCollection();
            services.AddLibraryDataService();       // Registers DbContext + Repos
            services.RegisterForms();               // Registers forms
            services.ApplyLibraryMigrations();      // Apply EF migrations
            var serviceProvider = services.BuildServiceProvider();

            // Optional: Seed database
            var context = serviceProvider.GetRequiredService<LibraryContext>();
            context.Seed(force: true);

            // Launch login form
            var loginForm = serviceProvider.GetRequiredService<LoginForm>();
            Application.Run(loginForm);
        }
    }
}
