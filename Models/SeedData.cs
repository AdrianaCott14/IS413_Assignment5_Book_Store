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
                        Classificaton = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        Pages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris",
                        AuthorMiddleName = "Kearns",
                        AuthorLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classificaton = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        Pages = 944
                    },

                     new Book
                     {
                         Title = "The Snowball",
                         AuthorFirstName = "Alice",
                         AuthorMiddleName = "",
                         AuthorLastName = "Schroeder",
                         Publisher = "Bantam",
                         ISBN = "978-0553384611",
                         Classificaton = "Non-Fiction, ",
                         Category = "Biography",
                         Price = 21.54,
                         Pages = 832
                     },

                     new Book
                     {
                         Title = "American Ulysses",
                         AuthorFirstName = "Ronald",
                         AuthorMiddleName = "C",
                         AuthorLastName = "White",
                         Publisher = "Random House",
                         ISBN = "978-0812981254",
                         Classificaton = "Non-Fiction",
                         Category = "Biography",
                         Price = 11.61,
                         Pages = 864
                     },

                     new Book
                     {
                        Title = "Unroken",
                        AuthorFirstName = "Laura",
                        AuthorMiddleName = "",
                        AuthorLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classificaton = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        Pages = 528
                     },

                     new Book
                     {
                         Title = "The Great Train Robbery",
                         AuthorFirstName = "Michael",
                         AuthorMiddleName = "",
                         AuthorLastName = "Crichton",
                         Publisher = "Vintage",
                         ISBN = "978-0804171281",
                         Classificaton = "Fiction",
                         Category = "Historical Fiction",
                         Price = 15.95,
                         Pages = 288
                     },

                     new Book
                     {
                         Title = "Deep Work",
                         AuthorFirstName = "Cal",
                         AuthorMiddleName = "",
                         AuthorLastName = "Newport",
                         Publisher = "Grand Central Publishing",
                         ISBN = "978-1455586691",
                         Classificaton = "Non-Fiction",
                         Category = "Self-Help",
                         Price = 14.99,
                         Pages = 304
                     },

                     new Book
                     {
                         Title = "It's Your Ship",
                         AuthorFirstName = "Michael",
                         AuthorMiddleName = "",
                         AuthorLastName = "Abrashoff",
                         Publisher = "Grand Central Publishing",
                         ISBN = "978-1455523023",
                         Classificaton = "Non-Fiction",
                         Category = "Self-Help",
                         Price = 21.66,
                         Pages = 240
                     },

                     new Book
                     {
                         Title = "The Virgin Way",
                         AuthorFirstName = "Richard",
                         AuthorMiddleName = "",
                         AuthorLastName = "Brandson",
                         Publisher = "Portfolio",
                         ISBN = "978-1591847984",
                         Classificaton = "Non-Fiction",
                         Category = "Business",
                         Price = 29.16,
                         Pages = 400
                     },

                     new Book
                     {
                         Title = "Sycamore Row",
                         AuthorFirstName = "John",
                         AuthorMiddleName = "",
                         AuthorLastName = "Grisham",
                         Publisher = "Bantam",
                         ISBN = "978-0553393613",
                         Classificaton = "Fiction",
                         Category = "Thrillers",
                         Price = 15.03,
                         Pages = 642
                     },

                     new Book
                     {
                         Title = "Ranger's Apprentice: The Ruins of Gorlon",
                         AuthorFirstName = "John",
                         AuthorMiddleName = "",
                         AuthorLastName = "Flanagan",
                         Publisher = "BMI Educational",
                         ISBN = "9780142417447",
                         Classificaton = "Fiction",
                         Category = "Fantasy",
                         Price = 8.29,
                         Pages = 282
                     },

                     new Book
                     {
                         Title = "Education",
                         AuthorFirstName = "Tara",
                         AuthorMiddleName = "",
                         AuthorLastName = "Westover",
                         Publisher = "Penguin Random House",
                         ISBN = "9780399590504",
                         Classificaton = "Biography",
                         Category = "Memoire",
                         Price = 28,
                         Pages = 352
                     },

                     new Book
                     {
                         Title = "Who Moved My Cheese?",
                         AuthorFirstName = "Spencer",
                         AuthorMiddleName = "",
                         AuthorLastName = "Johnson",
                         Publisher = "G. P. Putnam's Sons",
                         ISBN = "9780091816971",
                         Classificaton = "Non-Fiction",
                         Category = "Self-Help",
                         Price = 9.24,
                         Pages = 92
                     }
                     
                     );

                context.SaveChanges();
            }
        }
    }
}
