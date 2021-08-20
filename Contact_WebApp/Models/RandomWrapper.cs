using System;

namespace Contact_WebApp.Models
{
    public class RandomWrapper
    {
        private static readonly Random random = new Random();
        public static int GetNumber(int from, int to)
        {
            return random.Next(from, to);
        }
    }

}
