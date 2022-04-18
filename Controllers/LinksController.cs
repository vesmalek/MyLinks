using Microsoft.AspNetCore.Mvc;
using MyLinks.Models;

namespace MyLinks.Controllers
{
    public class LinksController : Controller
    {
        private static List<LinksViewModel> links = new List<LinksViewModel>();
        public IActionResult Index()
        {
            return View(links);
        }

        public IActionResult Create() 
        { 
            LinksViewModel linksViewModel = new LinksViewModel();
            return View(linksViewModel); 
        }

        public IActionResult CreateLink(LinksViewModel linksViewModel) 
        {
            links.Add(linksViewModel);
            return RedirectToAction(nameof(Index));
        }
    }
}

