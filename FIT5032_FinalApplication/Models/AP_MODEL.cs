using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_FinalApplication.Models
{
    public partial class AP_MODEL : DbContext
    {
        public AP_MODEL()
            : base("name=AP_MODEL")
        {
        }

        public virtual DbSet<AP_DATA> AP_DATA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AP_DATA>()
                .Property(e => e.first_name)
                .IsUnicode(false);

            modelBuilder.Entity<AP_DATA>()
                .Property(e => e.last_name)
                .IsUnicode(false);

            modelBuilder.Entity<AP_DATA>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<AP_DATA>()
                .Property(e => e.gender)
                .IsUnicode(false);

            modelBuilder.Entity<AP_DATA>()
                .Property(e => e.phone_number)
                .IsUnicode(false);
        }
    }
}
