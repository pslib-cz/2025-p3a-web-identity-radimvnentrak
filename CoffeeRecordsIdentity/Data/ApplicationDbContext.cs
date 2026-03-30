using CoffeeRecordsIdentity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CoffeeRecordsIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<CoffeeCup> Cups { get; set; }

        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {


        
        }

        
    }
}
