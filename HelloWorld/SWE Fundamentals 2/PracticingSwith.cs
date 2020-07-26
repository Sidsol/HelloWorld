using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    enum Seasons
    {
        Summer, Winter, Autumn, Spring
    }
    public static class PracticingSwith
    {
        public static void choosingThroughSwitch(string season)
        {
            Seasons convertedSeason;
            Enum.TryParse(season, out convertedSeason);

            switch (convertedSeason)
            {
                case Seasons.Summer:
                    Console.WriteLine("is the best!");
                    break;
                case Seasons.Spring:
                    Console.WriteLine("is ok... ");
                    break;
                case Seasons.Autumn:
                case Seasons.Winter:
                    Console.WriteLine("is cold");
                    break;
                default:
                    Console.WriteLine("is not a Valid season");
                    break;
            }
        }
    }
}
