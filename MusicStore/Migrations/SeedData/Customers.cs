using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MusicStore.Contexts;
using System;
using System.Linq;

namespace MusicStore.Migrations.SeedData
{
    public static class Customers
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            Console.WriteLine("debug: Checking if database already populated..");

            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            Console.WriteLine("debug: Migrating database..");

            context.Database.Migrate();

            if (!context.Customers.Any())
            {
                Console.WriteLine("debug: Seeding database with customer data..");

                context.Customers.AddRange(
                    new Models.DTOs.Customer
                    {
                        Email = "one@mail.net",
                        FirstName = "One",
                        LastName = "Eno",
                        Gender = "male",
                        IPAddress = "11.11.11.11"
                    },
                    new Models.DTOs.Customer
                    {
                        Email = "two@mail.net",
                        FirstName = "Two",
                        LastName = "Owt",
                        Gender = "femaile",
                        IPAddress = "22.22.22.22"
                    },
                    new Models.DTOs.Customer
                    {
                        Email = "three@mail.net",
                        FirstName = "Three",
                        LastName = "Eerht",
                        Gender = "male",
                        IPAddress = "33.33.33.33"
                    },
                    new Models.DTOs.Customer
                    {
                        Email = "four@mail.net",
                        FirstName = "Four",
                        LastName = "Ruof",
                        Gender = "female",
                        IPAddress = "44.44.44.444"
                    },
                    new Models.DTOs.Customer
                    {
                        Email = "five@mail.net",
                        FirstName = "Five",
                        LastName = "Evif",
                        Gender = "male",
                        IPAddress = "55.55.55.55"
                    },
                    new Models.DTOs.Customer
                    {
                        Email = "six@mail.net",
                        FirstName = "Six",
                        LastName = "Xis",
                        Gender = "female",
                        IPAddress = "66.66.66.66"
                    },
                    new Models.DTOs.Customer
                    {
                        Email = "seven@mail.net",
                        FirstName = "Seven",
                        LastName = "Neves",
                        Gender = "male",
                        IPAddress = "77.77.77.77"
                    },
                    new Models.DTOs.Customer
                    {
                        Email = "eight@mail.net",
                        FirstName = "Eight",
                        LastName = "Thgie",
                        Gender = "female",
                        IPAddress = "88.88.88.88"
                    },
                    new Models.DTOs.Customer
                    {
                        Email = "nine@mail.net",
                        FirstName = "Nine",
                        LastName = "Enin",
                        Gender = "male",
                        IPAddress = "99.99.99.99"
                    },
                    new Models.DTOs.Customer
                    {
                        Email = "ten@mail.net",
                        FirstName = "Ten",
                        LastName = "Net",
                        Gender = "female",
                        IPAddress = "10.10.10.10"
                    }
                );
            }

            Console.WriteLine("debug: Saving changes to database..");

            context.SaveChanges();
        }
    }
}
