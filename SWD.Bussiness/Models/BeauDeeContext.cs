using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SWD.Bussiness.Models
{
    public partial class BeauDeeContext : DbContext
    {
        public BeauDeeContext()
        {
        }

        public BeauDeeContext(DbContextOptions<BeauDeeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<ArtistService> ArtistService { get; set; }
        public virtual DbSet<ArtistSlot> ArtistSlot { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<BookingDetail> BookingDetail { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<CustomerService> CustomerService { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductArtistService> ProductArtistService { get; set; }
        public virtual DbSet<Service> Service { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-ONTGILH\\SQLEXPRESS;Database=BeauDee;user id=sa;password=THANHDUYEN07121999;Trusted_Connection=false;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>(entity =>
            {
                entity.Property(e => e.ArtistAddress).HasMaxLength(100);

                entity.Property(e => e.ArtistEducation).HasMaxLength(100);

                entity.Property(e => e.ArtistExperience).HasMaxLength(100);

                entity.Property(e => e.ArtistMail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ArtistName).HasMaxLength(50);
            });

            modelBuilder.Entity<ArtistService>(entity =>
            {
                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistService)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("fkArtistService");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ArtistService)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("fkArtistService1");
            });

            modelBuilder.Entity<ArtistSlot>(entity =>
            {
                entity.Property(e => e.AreaId).HasColumnType("text");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.Validate).HasColumnType("date");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.ArtistSlot)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("fkArtistSlotBookingDetail");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.ArtistSlot)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("fkBookingArtistSlot");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Booking)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("fkBookingCustomer");
            });

            modelBuilder.Entity<BookingDetail>(entity =>
            {
                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.BookingDetail)
                    .HasForeignKey(d => d.BookingId)
                    .HasConstraintName("fkBookingDetail");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.BookingDetail)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("fkBookingDetailService");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerAddress).HasMaxLength(100);

                entity.Property(e => e.CustomerBirthDay).HasColumnType("date");

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.CustomerPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerService>(entity =>
            {
                entity.HasKey(e => new { e.ServiceId, e.CustomerId })
                    .HasName("PK__Customer__5F51564784389D60");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerService)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCustomerService");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.CustomerService)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkCustomerService2");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductBrand).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("fkProductService");
            });

            modelBuilder.Entity<ProductArtistService>(entity =>
            {
                entity.HasKey(e => new { e.ArtistServiceId, e.ProductId })
                    .HasName("PK__ProductA__30CF6782F907F6AE");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ArtistService)
                    .WithMany(p => p.ProductArtistService)
                    .HasForeignKey(d => d.ArtistServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkProductArtistService1");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductArtistService)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkProductArtistService");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
