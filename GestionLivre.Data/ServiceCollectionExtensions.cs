using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using GestionLivre.Data.Context;
using GestionLivre.Data.Repositories;

namespace GestionLivre.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLibraryDataService(this IServiceCollection services)
        {
            services.AddDbContext<LibraryContext>(options =>
                options.UseSqlite("Data Source=library.db"), ServiceLifetime.Transient);

            services.AddTransient<BookRepository>();
            services.AddTransient<MemberRepository>();
            services.AddTransient<LoanRepository>();
            services.AddTransient<UserRepository>();


            return services;
        }

        public static void ApplyLibraryMigrations(this IServiceCollection services)
        {
            var provider = services.BuildServiceProvider();
            using (var scope = provider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<LibraryContext>();
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}
