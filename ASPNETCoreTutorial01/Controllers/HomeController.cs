using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCoreTutorial01.Models;
using ASPNETCoreTutorial01.Interfaces;
using ASPNETCoreTutorial01.Workers;
using Microsoft.Extensions.Options;

namespace ASPNETCoreTutorial01.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDateTime _dateTime;
        private readonly AppSettings _appSettings;

        public HomeController(IDateTime dateTime, IOptions<AppSettings> appSettings)
        {
            _dateTime = dateTime;
            _appSettings = appSettings.Value;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            var serverTime = _dateTime.Now;
            if (serverTime.Hour < 12)
            {
                ViewData["Message"] = "It's morning here - Good Morning!";
            }
            else if (serverTime.Hour < 17)
            {
                ViewData["Message"] = "It's afternoon here - Good Afternoon!";
            }
            else
            {
                ViewData["Message"] = "It's evening here - Good Evening!";
            }
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "App Settings:";

            ViewData["ClientId"] = _appSettings.ClientId;
            ViewData["TenantId"] = _appSettings.TenantId;
            ViewData["Ngrok"] = _appSettings.Ngrok;
            
            return View();
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
