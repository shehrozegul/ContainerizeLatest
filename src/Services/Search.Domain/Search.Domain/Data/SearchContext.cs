using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Search.Domain.Models;

namespace Search.Api.Identity
{
    public class SearchDbContext : IdentityDbContext<IdentityUser>
    {
        public SearchDbContext(DbContextOptions<SearchDbContext> options) : base(options)
        {
        }

        // Add other DbSet properties for your custom entities if needed
        public DbSet<Item>? Items { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            // Customize the ASP.NET Identity model and override the defaults if needed
            // For example, you can change the table names, primary key, etc.
        }
    }
}

