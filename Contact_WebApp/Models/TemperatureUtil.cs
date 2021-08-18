using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact_WebApp.Models
{
    public class TemperatureUtil
    {
        private static readonly double FeverStart = 38.0;
        private static readonly double HypothermiaEnd = 34.9;

        public static bool HasFever(int temp)
        {
            return temp >= FeverStart;
        }

        public static bool HasHypothermia(int temp)
        {
            return temp <= HypothermiaEnd;
        }

        public static int CelsiusToFahrenheit(int temp)
        {
            return (int)(temp * 1.8 + 32);
        }

        public static int FahrenheitToCelsius(int temp)
        {
            return (int)((temp - 32) * 0.5556);
        }

    }

    public class IllnessResult
    {
        public bool HasFever { get; set; }
        public bool HasHypothermia { get; set; }

        public IllnessResult(int temp)
        {
            this.HasFever = TemperatureUtil.HasFever(temp);
            this.HasHypothermia = TemperatureUtil.HasHypothermia(temp);
        }
    }
}
