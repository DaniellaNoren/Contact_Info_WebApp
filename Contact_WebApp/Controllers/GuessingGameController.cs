using Contact_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact_WebApp.Controllers
{
    public class GuessingGameController : Controller
    {
        [HttpGet("/GuessingGame", Name = "guessinggame"), ActionName("NumberGuess")]
        public IActionResult GuessNumber()
        {
            return View();
        }

        [HttpPost("/GuessingGame", Name = "guessnumber"), ActionName("NumberGuess")]
        public IActionResult GuessNumber(int guess)
        {
            return View();
        }

    }
}
