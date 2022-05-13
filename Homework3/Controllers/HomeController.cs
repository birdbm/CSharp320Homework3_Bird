using Homework3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Homework3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact
            { 
                ContactId = 1,
                ContactName = "Test",
                ContactEmail = "test@test.com",
                ContactAge = 1,
                ContactPhoneType = "test",
                ContactNotes = "Test",
                CreatedDate = DateTime.Now,
            });
            return View(contacts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}