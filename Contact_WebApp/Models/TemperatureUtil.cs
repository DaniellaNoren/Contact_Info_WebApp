using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact_WebApp.Models
{
    public class TemperatureUtil
    {
        private static readonly long FeverStart = 38;
        private static readonly long HypothermiaEnd = 35;

        public static bool HasFever(long temp)
        {
            return temp >= FeverStart;
        }

        public static bool HasHypothermia(long temp)
        {
            return temp < HypothermiaEnd;
        }

    }

    public class IllnessResult
    {
        public bool HasFever { get; set; }
        public bool HasHypothermia { get; set; }

        public IllnessResult(long temp)
        {
            this.HasFever = TemperatureUtil.HasFever(temp);
            this.HasHypothermia = TemperatureUtil.HasHypothermia(temp);
        }
    }
}
