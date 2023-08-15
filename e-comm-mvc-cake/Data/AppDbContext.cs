using e_comm_mvc_cake.Models;
using Microsoft.EntityFrameworkCore;

namespace e_comm_mvc_cake.Data
{
	public class AppDbContext :DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cake>().HasKey(c => c.Id);

            modelBuilder.Entity<Cake>().Property(c => c.CakeName).HasMaxLength(50).IsRequired();
            //modelBuilder.Entity<Cake>().Property(c => c.CakeFlavour).HasConversion<string>();
        }
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Cookie> Cookies { get; set; }
    }
}
