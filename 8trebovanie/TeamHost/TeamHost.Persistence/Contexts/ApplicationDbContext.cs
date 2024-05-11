using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using TeamHost.Domain.Entities;
using TeamHost.Persistence.Configurations;
using IdentityDbContext = Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext;

namespace TeamHost.Persistence.Contexts
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<StaticFile> StaticFiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Game> Games { get; set; }
        
        /// <summary>
        /// Профиль пользователя
        /// </summary>
        public DbSet<User> UserProfiles { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        public ApplicationDbContext()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Apply the seed data on the tables
        }
    }
}
