using Microsoft.AspNetCore.Mvc;
using Mission_11_jefferson_lambert.Models;
using Mission_11_jefferson_lambert.Models.ViewModels;


namespace Mission_11_jefferson_lambert.Controllers
{
    //home controller below with all defaults needed for our apps.
    public class HomeController : Controller
    {
        private IBookRepo _repo;
        public HomeController(IBookRepo temp) 
        {
            _repo = temp;
        }
        // the iactionresult is set and the page size and calling in the projectlistviewmodel woo
        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;
            var Plm = new ProjectListViewModel
            {
                // setting up the pulling in info from the books data woo
                Books = _repo.Books
                .OrderBy(x => x.BookID)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),
                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };
            return View(Plm);
        }
    }
}
