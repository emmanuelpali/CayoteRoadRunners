using CayoteRoadRunners.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CayoteRoadRunners.Data
{
    public class ApplicationUser : IdentityUser
    {
        [ForeignKey("UserId")]
        public virtual ICollection<UserCategory>? UserCategory { get; set; }
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryItem> CategoryItem { get; set; }
        public DbSet<MediaType> MediaType { get; set; }
        public DbSet<UserCategory> USerCategory { get; set; }
        public DbSet<Content> Content { get; set; }

    }
}