using System;

namespace SolarSystemWallpaper
{
    class Program
    {
        ///<summary>
        /// Main method
        ///</summary>
        static void Main(string[] args)
        {
            if (!AreParametersValid(args))
            {
                return;
            }

            var parser = new WallpaperSvgParser();
            // Resolution 1920 x 1080
            if (Constants.AllowedWidth[0] == args[0] && Constants.AllowedHeight[0] == args[1])
            {
                Utils.DisplayGeneration(args[0], args[1]);
                return; 
            }
            // Resolution 1366 x 768
            if (Constants.AllowedWidth[1] == args[0] && Constants.AllowedHeight[1] == args[1])
            {
                Utils.DisplayGeneration(args[0], args[1]);
                parser.ReadExample();
                return;
            }

            Console.WriteLine($"Couple of values {args[0]} and {args[1]} are not allowed");
        }

        // Test if parameters given to the application are valid and display in the console why they are not valid if it is the case
        private static bool AreParametersValid(string[] args)
        {
            if (args.Length < 1 || String.IsNullOrEmpty(args[0]))
            {
                Console.WriteLine("The first parameter of the application have to be filled by the width of the wallpaper");
                Console.WriteLine($"Allowed values : {Utils.GetDisplayedEnumerableString(Constants.AllowedWidth)}");
                return false;
            }
            
            if (args.Length < 2 || String.IsNullOrEmpty(args[1]))
            {
                Console.WriteLine("The second parameter of the application have to be filled by the height of the wallpaper");
                Console.WriteLine($"Allowed values : {Utils.GetDisplayedEnumerableString(Constants.AllowedHeight)}");
                return false;
            }

            if (!Constants.AllowedWidth.Contains(args[0]) || !Constants.AllowedHeight.Contains(args[1]))
            {
                Console.WriteLine($"Allowed values for width : {Utils.GetDisplayedEnumerableString(Constants.AllowedWidth)}");
                Console.WriteLine($"Allowed values for height : {Utils.GetDisplayedEnumerableString(Constants.AllowedHeight)}");
                return false;
            }
            return true;
        }
    }
}
