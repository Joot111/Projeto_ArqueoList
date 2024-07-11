using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_ArqueoList.Models;

namespace Projeto_ArqueoList.Controllers
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
            _logger.LogInformation("Home/Index accessed");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Home/Privacy accessed");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var requestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            _logger.LogError($"Error occurred. Request ID: {requestId}");
            return View(new ErrorViewModel { RequestId = requestId });
        }
    }
}
