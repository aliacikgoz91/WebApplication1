using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication1.Models
{
    public partial class FormDB : DbContext
    {
        public FormDB()
            : base("name=FormDB")
        {
        }

        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.Adi)
                .IsFixedLength();

            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.Soyadi)
                .IsFixedLength();

            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.Sehir)
                .IsFixedLength();
        }
    }
}
