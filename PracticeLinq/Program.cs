using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gameNames = new List<string>() { "Super Mario Bros", "Dead By Daylight", "Pac-Man", "Roblox", "Minecraft", "Call of Duty", "Revenge of the Sunfish, Ultimate Extraordinary Edition" };
            var sortedNames = gameNames.OrderBy(x => x.Length);
            foreach(var name in sortedNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
