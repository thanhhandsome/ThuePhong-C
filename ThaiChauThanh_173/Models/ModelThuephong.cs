using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ThaiChauThanh_173.Models
{
    public partial class ModelThuephong : DbContext
    {
        public ModelThuephong()
            : base("name=ModelThuephong")
        {
        }

        public virtual DbSet<chitietphieuthue> chitietphieuthues { get; set; }
        public virtual DbSet<khachthue> khachthues { get; set; }
        public virtual DbSet<loaiphong> loaiphongs { get; set; }
        public virtual DbSet<phieuthue> phieuthues { get; set; }
        public virtual DbSet<phong> phongs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<phieuthue>()
                .HasMany(e => e.chitietphieuthues)
                .WithRequired(e => e.phieuthue)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<phong>()
                .HasMany(e => e.chitietphieuthues)
                .WithRequired(e => e.phong)
                .WillCascadeOnDelete(false);
        }
    }
}
