using ECommerce_2022.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_2022.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().ToTable("Course");
        modelBuilder.Entity<Product>().ToTable("Enrollment");
    }
}

//Will have more models and data sets but trying to set up base functionalities first 