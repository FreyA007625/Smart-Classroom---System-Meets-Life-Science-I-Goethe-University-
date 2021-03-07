using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartClassRoom_Panel.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SmartClassRoom_Panel.Controllers
{
    public class SCController : Controller
    {
        private readonly ILogger<SCController> _logger;

        public SCController(ILogger<SCController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Log()
        {
            SC_Context context = HttpContext.RequestServices.GetService(typeof(SmartClassRoom_Panel.Models.SC_Context)) as SC_Context;
            var x = context.GetAllClassrooms();
            return View(x);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
