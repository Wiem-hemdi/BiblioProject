using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionLivre;
using GestionLivre.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace GestionEtudiant
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterForms(this IServiceCollection services)
        {
            services.AddDbContext<LibraryContext>(options =>options.UseSqlite("Data Source=library.db"), ServiceLifetime.Scoped);
            services.AddTransient<LoginForm>();
            services.AddTransient<MainForm>();
            services.AddTransient<GestionLivresForm>();
            services.AddTransient<GestionMembre>();
            services.AddTransient<LoanForm>();
            services.AddTransient<ImportExportForm>();
            return services;

        }
    }
}