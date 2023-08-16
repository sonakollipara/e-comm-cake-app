using e_comm_mvc_cake.Models;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;

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

            modelBuilder.Entity<Cookie>().HasKey(c => c.Id);

            modelBuilder.Entity<Cookie>().Property(c => c.CookieName).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<CupCake>().HasKey(c => c.Id);

            modelBuilder.Entity<CupCake>().Property(c => c.CupCakeName).HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Pastry>().HasKey(c => c.Id);

            modelBuilder.Entity<Pastry>().Property(c => c.PastryName).HasMaxLength(50).IsRequired();
        }
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Cookie> Cookies { get; set; }
        public DbSet<CupCake> CupCakes { get; set; }
        public DbSet<Pastry> Pastries { get; set; }
    }
}
