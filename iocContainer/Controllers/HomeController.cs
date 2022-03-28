using iocContainer.Models;
using iocContainer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace iocContainer.Controllers
{
    public class HomeController : Controller
    {
        private ISingletonService _singleton;
        private IScopedService _scoped;
        private ITransientService _transient;

        public HomeController(
            ISingletonService singleton,
            IScopedService scoped,
            ITransientService transient)
        {
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
        }

        public IActionResult Index()
        {
            return View("Index", _singleton.getGuid());
        }

        public IActionResult Scoped()
        {
            return View("Scoped", _scoped.getGuid());
        }

        public IActionResult Transient()
        {
            return View("Transient", _transient.getGuid());
        }
    }
}
