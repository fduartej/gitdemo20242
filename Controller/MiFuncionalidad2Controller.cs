using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controller
{
    [Route("[controller]")]
    public class MiFuncionalidad2Controller : Controller
    {
        private readonly ILogger<MiFuncionalidad2Controller> _logger;

        public MiFuncionalidad2Controller(ILogger<MiFuncionalidad2Controller> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Esto tambien debe ir");
            _logger.LogInformation("Index1");
            _logger.LogInformation("Index2");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}