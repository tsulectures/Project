using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public class PersonDbContext : DbContext
    {
        public PersonDbContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Person> People { get; set; }

        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        public DbSet<Dictionary> Dictionaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>()
                .Property(e => e.Firstname)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Person>()
                .Property(e => e.Lastname)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Person>()
                .Property(e => e.Lastname)
                .HasMaxLength(150)
                .IsRequired();


            modelBuilder.Entity<Person>()
             .HasOne(e=> e.Gender)
             .WithMany(e=>e.PersonGenders)
             .HasForeignKey(e=>e.GenderId)
             .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Person>()
             .HasOne(e => e.Position)
             .WithMany(e => e.PersonPositions)
             .HasForeignKey(e => e.PositionId)
             .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<PhoneNumber>()
               .HasOne(e => e.Person)
               .WithMany(e => e.PhoneNumbers)
               .HasForeignKey(e => e.PersonId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PhoneNumber>()
               .HasOne(e => e.PhoneType)
               .WithMany(e => e.PhoneTypes)
               .HasForeignKey(e => e.PhoneTypeId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PhoneNumber>()
                .Property(e => e.Number)
                .HasMaxLength(20)
                .IsRequired();

            modelBuilder.Seed();
        }
    }
}
