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

    public class NumberGuessResult
    {
        private bool wonGame;
        public bool WonGame
        {
            get { return wonGame; }
            set
            {
                wonGame = value; if (value) { TooLow = false; TooHigh = false; }
            }
        }

        private bool tooLow;
        public bool TooLow
        {
            get { return tooLow; }
            set { tooLow = value; if (value) { WonGame = false; TooHigh = false; } }
        }
        private bool tooHigh;
        public bool TooHigh
        {
            get { return tooHigh; }
            set { tooHigh = value; if (value) { TooLow = false; WonGame = false; } }
        }
    }
    public class NumberGuess
    {

        public static NumberGuessResult Guess(int nrToGuess, int guess)
        {
            NumberGuessResult result = new NumberGuessResult();

            if (guess > nrToGuess)
            {
                result.TooHigh = true;
            }
            else if (guess < nrToGuess)
                result.TooLow = true;
            else
            {
                result.WonGame = true;
            }

            return result;
        }
       
        
    }

}
