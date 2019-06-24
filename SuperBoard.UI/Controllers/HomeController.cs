
namespace SuperBoard.UI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using SuperBoard.DomainModels;
    using SuperBoard.UI.Models;
    using System.Diagnostics;
    using System.Linq;

    public class HomeController : Controller
    {
        private readonly SuperBoardContext _context;

        public HomeController(SuperBoardContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Board()
        {
            var boards = _context.Boards.ToArray();
            var viewModel = new BoardViewModel(boards);
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
