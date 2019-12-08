using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AppLog.Controllers
{
    public class ApplicationController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}