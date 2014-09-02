namespace RestaurangGuide.DB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RestGuideDB : DbContext
    {
        public RestGuideDB()
            : base("name=RestGuideDB")
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rating>()
                .Property(e => e.Rating1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Restaurant)
                .HasForeignKey(e => e.RestaurangId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Restaurant>()
                .HasMany(e => e.Ratings)
                .WithRequired(e => e.Restaurant)
                .HasForeignKey(e => e.RestaurangId)
                .WillCascadeOnDelete(false);
        }
    }
}
