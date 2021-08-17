using Contact_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact_WebApp.Controllers
{
    
    public class DoctorController : Controller
    {
        [HttpGet("FeverCheck", Name = "fevercheck")]
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost("FeverCheck", Name = "fevercheck")]
        public IActionResult FeverCheck(long temp)
        {
            return View(new IllnessResult(temp));
        }
    }
}
