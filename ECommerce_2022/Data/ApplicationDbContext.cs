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

//using preview version of Visual Studio 2022, if asked for bugs mention false errors being thrown here with nothing popping up when trying to refactor


//Will have more models but trying to set up base functionalities first 