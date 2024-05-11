using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

using TeamHost.Application.Interfaces.Repositories;
using TeamHost.Persistence.Contexts;
using TeamHost.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace TeamHost.Persistence.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void AddPersistenceLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext(configuration);
            services.AddRepositories();
            services.AddIdentity(configuration);
        }

        public static void AddIdentity(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
        }

        public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseNpgsql(connectionString,
                   builder => builder.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
        }

        private static void AddRepositories(this IServiceCollection services)
        {
            services
                .AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork))
                .AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>))
                .AddTransient<IGameRepository, GameRepository>();
        }
    }
}
