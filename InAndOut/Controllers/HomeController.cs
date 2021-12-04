using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using tp.Global;
using tp.Model;
using EBC.Configuration.V2;

namespace InAndOut.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Test()
        {
            TpCredential creds = new TpCredential("testuser-ebc", "n/-Oq/0HzR41e7;!i$OA");
            Connections connections = new Connections(creds);
            connections.Login();
            
            tp.Model.Connection conn = connections.Add(TpServer.i11);

            //Project project = (connections.Add(11).Projects()("BW5"));




            //Documents docs;
            //Document doc;

            //ICollection<Project> projects = connections.GetProjects();

            

            //break


            Debugger.Break();

            //docs = conn.Projects(false)("").FormDefinitions()("").Filters()("").Documents;



            return Ok("tested");
        }



    }
}
