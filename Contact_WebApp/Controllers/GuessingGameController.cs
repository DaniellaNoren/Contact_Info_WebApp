using Contact_WebApp.Models;
using Microsoft.AspNetCore.Http;
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
            
            HttpContext.Session.SetInt32("number", NumberGeneratorUtil.GetNumber(0, 1001));
            HttpContext.Session.SetInt32("numberOfGuesses", 0);
            if (!Request.Cookies.TryGetValue("High-score", out _)) {
                Response.Cookies.Append("High-score", ",,,,,,,,,");
            } 

            return View();
        }

        [HttpPost("/GuessingGame", Name = "guessnumber"), ActionName("NumberGuess")]
        public IActionResult GuessNumber(int guess)
        {
            var result = NumberGuess.Guess((int)HttpContext.Session.GetInt32("number"), guess);
            int? nrOfGuesses = HttpContext.Session.GetInt32("numberOfGuesses");
            
            if (nrOfGuesses == null)
            {
                HttpContext.Session.SetInt32("numberOfGuesses", 1);
            }
            else
            {
                HttpContext.Session.SetInt32("numberOfGuesses", (int) ++nrOfGuesses);
            }

            if (result.WonGame)
            {
                Request.Cookies.TryGetValue("High-score", out string value);
                string[] cookieValues = value.Split(",");

                for (int i = 0; i < cookieValues.Length; i++)
                {
                    if (string.IsNullOrEmpty(cookieValues[i]) || nrOfGuesses <= Int32.Parse(cookieValues[i]))
                    {
                        string[] newHighScore = new string[10];
                        Array.ConstrainedCopy(cookieValues, 0, newHighScore, 0, i);
                        Array.ConstrainedCopy(cookieValues, i, newHighScore, i + 1, 10 - i - 1);
                        newHighScore[i] = nrOfGuesses.ToString();

                        Response.Cookies.Append("High-score", String.Join(',', newHighScore));

                        break;
                    }
                }
               
            }

            return View(result);
        }

    }
}
