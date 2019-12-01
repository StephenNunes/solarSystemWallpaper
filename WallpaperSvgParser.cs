using System;
using System.Xml; 

namespace SolarSystemWallpaper
{
    // Parser of the svg wallpaper
    public class WallpaperSvgParser
    {
        public void CreateWallpaper()
        {

        }

        // Read the current wallpaper example
        public void ReadExample()
        {
            XmlDocument document = new XmlDocument();
            document.Load("wallpaper_1365x768.svg");
            XmlNodeList nodeList = document.GetElementsByTagName("circle");
            foreach (XmlNode node in nodeList)
            {
                Console.WriteLine(node.Attributes["id"].InnerText);   
            }
        }
    }
}
