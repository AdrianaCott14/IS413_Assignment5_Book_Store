using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    //set up the repository 
    public interface IBookStoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
