using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models.ViewModels;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookStoreRepository _repository;

        //set up how many items should be on the page
        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IBookStoreRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //passing in a variable to know which page to go to, default of 1
        public IActionResult Index(int page = 1)
        {
            return View(new BookListViewModel
            {
                Books = _repository.Books
                    //this gets us to the page that was oassed in
                    .OrderBy(p => p.BookId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
                ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _repository.Books.Count()
                }
            });

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
