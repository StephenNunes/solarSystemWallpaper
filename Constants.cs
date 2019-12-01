using System;
using System.Collections.Generic;

namespace SolarSystemWallpaper
{
    public static class Constants 
    {
        // Astre name
        public const string Soleil = "Soleil";  
        public const string Mercure = "Mercure";
        public const string Venus = "Venus";
        public const string Terre = "Terre";
        public const string Mars = "Mars";
        public const string Jupiter = "Jupiter";
        public const string Saturne = "Saturne";
        public const string Uranus = "Uranus";
        public const string Neptune = "Neptune";

        // Radius in km
        public const float SoleilRadius = 696342.0f;
        public const float MercureRadius = 2439.0f;
        public const float VenusRadius = 6052.0f;
        public const float TerreRadius = 6378.0f;
        public const float MarsRadius = 3402.0f;
        public const float JupiterRadius = 71492.0f;
        public const float SaturneRadius = 60268.0f;
        public const float UranusRadius = 25559.0f;
        public const float NeptuneRadius = 24764.0f;

        // Color in hexadecimal
        public const string SoleilColor = "#ffff99";
        public const string MercureColor = "#b3b3b3";
        public const string VenusColor = "#ffcc00";
        public const string TerreColor = "#0033cc";
        public const string MarsColor = "#990000";
        public const string JupiterColor = "#ff9933";
        public const string SaturneColor = "#ffcc99";
        public const string UranusColor = "#00cc99";
        public const string NeptuneColor = "#0052cc";

        // One astronomic unit (UA) in km
        public const int UA = 149597871;

        // Average distance in km from Sun (Périhélie+Aphélie)/2
        public const float SoleilDistance = 0.0f;

        // 0,72 ua * 1 ua
        public const double MercureDistance = 0.39 * UA;
        public const double VenusDistance = 0.72 * UA;
        public const double TerreDistance = 1.0 * UA;
        public const double MarsDistance = 1.52 * UA;
        public const double JupiterDistance = 5.2 * UA;
        public const double SaturneDistance = 9.54 * UA;
        public const double UranusDistance = 19.19 * UA;
        public const double NeptuneDistance = 30.07 * UA;


        //public const int SoleilXPosition = TotalWidth / 2;
        //public const int SoleilYPosition = TotalHeight / 2;        

        public static readonly IList<string> AllowedWidth = new List<string> {"1920", "1366"};
        public static readonly IList<string> AllowedHeight = new List<string> {"1080", "768"};
            
    }
}
