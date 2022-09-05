using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyQuanTraSua.DataAccessLayer
{
    public partial class MenuDbContext : DbContext
    {
        public MenuDbContext()
            : base("name=MenuDbContext")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Category)
                .HasForeignKey(e => e.idCategory)
                .WillCascadeOnDelete(false);
        }
    }
}
