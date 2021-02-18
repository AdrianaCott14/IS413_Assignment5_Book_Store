using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class EFBookStoreRepository : IBookStoreRepository
    {

        private BookStoreDBContext _context;

        //constructor
        public EFBookStoreRepository (BookStoreDBContext ctx)
        {
            _context = ctx;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
