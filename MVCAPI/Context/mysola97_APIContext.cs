using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVCAPI.Models
{
    public partial class mysola97_APIContext : DbContext
    {
        public mysola97_APIContext()
        {
        }

        public mysola97_APIContext(DbContextOptions<mysola97_APIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chaves> Chaves { get; set; }
        public virtual DbSet<EfmigrationsHistory> EfmigrationsHistory { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Contextodeteste");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chaves>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Numchave).HasColumnName("numchave");

                entity.Property(e => e.Stringchave)
                    .HasColumnName("stringchave")
                    .HasColumnType("longtext");
            });

            modelBuilder.Entity<EfmigrationsHistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId);

                entity.ToTable("__EFMigrationsHistory");

                entity.Property(e => e.MigrationId).HasColumnType("varchar(95)");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("student");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Class)
                    .HasColumnName("class")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(50)");
            });
        }
    }
}
