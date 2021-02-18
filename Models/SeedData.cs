using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookStoreDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookStoreDBContext>();

            //are there any migrations that need to happen
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Mierables",
                        AuthorFirstName = "Victor",
                        AuthorMiddleName = "",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        ClassificatonCategory = "Fiction, Classic",
                        Price = 9.95
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris",
                        AuthorMiddleName = "Kearns",
                        AuthorLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        ClassificatonCategory = "Non-Fiction, Biography",
                        Price = 14.58
                    },

                     new Book
                     {
                         Title = "The Snowball",
                         AuthorFirstName = "Alice",
                         AuthorMiddleName = "",
                         AuthorLastName = "Schroeder",
                         Publisher = "Bantam",
                         ISBN = "978-0553384611",
                         ClassificatonCategory = "Non-Fiction, Biography",
                         Price = 21.54
                     },

                     new Book
                     {
                         Title = "American Ulysses",
                         AuthorFirstName = "Ronald",
                         AuthorMiddleName = "C",
                         AuthorLastName = "White",
                         Publisher = "Random House",
                         ISBN = "978-0812981254",
                         ClassificatonCategory = "Non-Fiction, Biography",
                         Price = 11.61
                     },

                     new Book
                     {
                        Title = "Unroken",
                        AuthorFirstName = "Laura",
                        AuthorMiddleName = "",
                        AuthorLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        ClassificatonCategory = "Non-Fiction, Historical",
                        Price = 13.33
                     },

                     new Book
                     {
                         Title = "The Great Train Robbery",
                         AuthorFirstName = "Michael",
                         AuthorMiddleName = "",
                         AuthorLastName = "Crichton",
                         Publisher = "Vintage",
                         ISBN = "978-0804171281",
                         ClassificatonCategory = "Fiction, Historical Fiction",
                         Price = 15.95
                     },

                     new Book
                     {
                         Title = "Deep Work",
                         AuthorFirstName = "Cal",
                         AuthorMiddleName = "",
                         AuthorLastName = "Newport",
                         Publisher = "Grand Central Publishing",
                         ISBN = "978-1455586691",
                         ClassificatonCategory = "Non-Fiction, Self-Help",
                         Price = 14.99
                     },

                     new Book
                     {
                         Title = "It's Your Ship",
                         AuthorFirstName = "Michael",
                         AuthorMiddleName = "",
                         AuthorLastName = "Abrashoff",
                         Publisher = "Grand Central Publishing",
                         ISBN = "978-1455523023",
                         ClassificatonCategory = "Non-Fiction, Self-Help",
                         Price = 21.66
                     },

                     new Book
                     {
                         Title = "The Virgin Way",
                         AuthorFirstName = "Richard",
                         AuthorMiddleName = "",
                         AuthorLastName = "Brandson",
                         Publisher = "Portfolio",
                         ISBN = "978-1591847984",
                         ClassificatonCategory = "Non-Fiction, Business",
                         Price = 29.16
                     },

                     new Book
                     {
                         Title = "Sycamore Row",
                         AuthorFirstName = "John",
                         AuthorMiddleName = "",
                         AuthorLastName = "Grisham",
                         Publisher = "Bantam",
                         ISBN = "978-0553393613",
                         ClassificatonCategory = "Fiction, Thrillers",
                         Price = 15.03
                     });

                context.SaveChanges();
            }
        }
    }
}
