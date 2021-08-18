using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact_WebApp.Models
{
    public class NumberGeneratorUtil 
    {
        private static readonly Random random = new Random();

        public static int GetNumber(int from, int to)
        {
            return random.Next(from, to);
        }
    }
}
