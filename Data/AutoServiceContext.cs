using AutoService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AutoService.Data
{
    public class AutoServiceContext : DbContext
    {
        public AutoServiceContext(DbContextOptions<AutoServiceContext> options) : base(options)
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Groupprod> Groupprod { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersPosition> OrdersPosition { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<Automobile> Automobile { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>(entity =>
            {
                entity.ToTable("clients");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateBirdth)
                    .IsRequired()
                    .HasColumnName("datebirdth")
                    .HasMaxLength(50);

                entity.Property(e => e.DateReg)
                    .IsRequired()
                    .HasColumnName("datereg")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Fio)
                    .IsRequired()
                    .HasColumnName("fio")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(50);

                entity.Property(e => e.Pol)
                    .IsRequired()
                    .HasColumnName("pol")
                    .HasMaxLength(50);
            });



            modelBuilder.Entity<Automobile>(entity =>
            {
                entity.ToTable("automobile");

                entity.HasKey(e => e.Gosn).HasName("gosn"); 

                entity.Property(e => e.Id_client)
                    .IsRequired()
                    .HasColumnName("id_client")
                    .HasMaxLength(50);

                entity.Property(e => e.Trade_mark)
                    .IsRequired()
                    .HasColumnName("trade_mark")
                    .HasMaxLength(50);

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasColumnName("year")
                    .HasMaxLength(50);

                entity.Property(e => e.Gosn)
                    .IsRequired()
                    .HasColumnName("gosn")
                    .HasMaxLength(50);

                entity.Property(e => e.Odometr)
                    .IsRequired()
                    .HasColumnName("odometr")
                    .HasMaxLength(50);

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("vin")
                    .HasMaxLength(50);

                entity.Property(e => e.Fuel)
                    .IsRequired()
                    .HasColumnName("fuel")
                    .HasMaxLength(50);
            });


            modelBuilder.Entity<Groupprod>((pc =>
            {
                pc.HasNoKey();
            }));
            modelBuilder.Entity<Product>((pc =>
            {
                pc.HasNoKey();
            }));

            modelBuilder.Entity<Service>((pc =>
            {
                pc.HasNoKey();
            }));

          

        }

    }

   
}
