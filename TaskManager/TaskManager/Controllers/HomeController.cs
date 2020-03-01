using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class HomeController : Controller
    {


        //public HomeController(ILogger<HomeController> logger) // to hide for using another constructor
        //{
        //    _logger = logger;
        //}

        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration iconfiguration;
        public HomeController(IConfiguration config)
        {
            this.iconfiguration = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        // To get data from SQLSERVER

        /*  string connectionString = iconfiguration.GetConnectionString("DefaultConStr");
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
            string cmd = "SELECT Count(*) FROM Movie";
        SqlCommand sqlCmd = new SqlCommand(cmd, connection);
        var count = (int)sqlCmd.ExecuteScalar();
        ViewData["TotalData"] = count;
        connection.Close(); */
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult TestPage()
        {
            return View();
        }
    }
}
