using CodingContest.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CodingContest.Controllers 
{
    public class HomeController : Controller 
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataService _service;

        public HomeController(ILogger<HomeController> logger, IDataService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index() 
        {
            return View();
        }
    }
}