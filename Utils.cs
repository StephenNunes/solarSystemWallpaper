
using System;
using System.Collections.Generic;
using System.Linq;

namespace SolarSystemWallpaper
{
    // Utilitary class
    public static class Utils 
    {
        // Display in the console that wallpaper is generating with the dimension of wallpapers
        public static void DisplayGeneration(string args1, string args2)
        {
            Console.WriteLine($"Generate wallpapers for size {args1}x{args2} ...");
        }

        // Return a string that represent the list of string given in parameters separated by ', '
        public static string GetDisplayedEnumerableString(IEnumerable<string> stringEnumerable)
        {
            return stringEnumerable.Aggregate((currentString, nextString) => $"{currentString}, {nextString}");
        }
    }
}
