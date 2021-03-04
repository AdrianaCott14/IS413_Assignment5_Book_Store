using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorFirstName { get; set; }

        [Required]
        public string AuthorMiddleName { get; set; }

        [Required]
        public string AuthorLastName { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required, RegularExpression(@"[0-9]*[-| ][0 - 9]*[-| ] [0-9]*[-| ][0 - 9]*[-| ] [0-9]*")]
        public string ISBN { get; set; }

        [Required]
        public string Classificaton { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public double Price { get; set; }

        public int Pages { get; set; }
        

    }
}
