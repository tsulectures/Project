using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Context
{
    public static class DatabaseInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Dictionary>().HasData(
               new Dictionary()
               {
                   Id = 1,
                   Title = "Manager",
                   HasPosition = true,
               },
                 new Dictionary()
                 {
                     Id = 2,
                     Title = "CEO",
                     HasPosition = true,
                 },
                 new Dictionary()
                 {
                     Id = 3,
                     Title = "CTO",
                     HasPosition = true,
                 },
                 new Dictionary()
                 {
                     Id = 4,
                     Title = "Web Developer",
                     HasPosition = true,
                 },
                 new Dictionary()
                 {
                     Id = 5,
                     Title = "Male",
                     HasGender = true,
                 },
                 new Dictionary()
                 {
                     Id = 6,
                     Title = "Female",
                     HasGender = true,
                 }
                 ,
                 new Dictionary()
                 {
                     Id = 7,
                     Title = "Home",
                     HasPhoneType = true,
                 },
                 new Dictionary()
                 {
                     Id = 8,
                     Title = "Work",
                     HasPhoneType = true,
                 }
                 ,
                 new Dictionary()
                 {
                     Id = 9,
                     Title = "Mobile",
                     HasPhoneType = true,
                 }
               );

                modelBuilder.Entity<Person>().HasData(
                    new Person()
                    {
                        Id = 1,
                        Firstname = "Person1",
                        Lastname = "PersonLastName1",
                        BirthDate = new DateTime(1996, 05, 23),
                        Email = "test@tes.com",
                        GenderId = 5,
                        PositionId = 2
                    }
                );
        }
    }
}
