using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCalendar.Helpers
{
    public class RandomColorHelper
    {
        private static Random random = new Random();

        private static string[] colorClasses = new[] { "magenta", "yellow", "yellow-green", "pink-red", "red-orange" };

        public static string GetRandomColorClass()
        {
            return colorClasses[random.Next(0, colorClasses.Length)];
        }
    }
}
