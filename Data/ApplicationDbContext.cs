using BulkyWebRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BulkyWebRazor_Temp.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Catagory> Catagories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Catagory>().HasData(
                new Catagory() { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Catagory() { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                new Catagory() { Id = 3, Name = "Comedy", DisplayOrder = 3 }
                );
        }
    }
}
