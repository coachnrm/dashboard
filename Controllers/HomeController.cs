using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using AdminPanelTutorial.Models;

namespace AdminPanelTutorial
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}