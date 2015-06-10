using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.NightLife
{
    class NightLife
    {
        static void Main()
        {
            Dictionary<string,SortedDictionary<string, SortedSet<string>>> cities = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
            string inputLine = Console.ReadLine();
            while (inputLine != "END")
            {
                string[] inputLineAsArray = inputLine.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                string city = inputLineAsArray[0];
                string venue = inputLineAsArray[1];
                string performer = inputLineAsArray[2];
                if (!cities.ContainsKey(city))
                {
                    cities[city] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!cities[city].ContainsKey(venue))
                {
                    cities[city][venue] = new SortedSet<string>();
                }
                cities[city][venue].Add(performer);
                inputLine = Console.ReadLine();
            }
            foreach (var city in cities)
            {
                Console.WriteLine(city.Key);
                foreach (var venue in city.Value)
                {
                    Console.WriteLine("->{0}: {1}", venue.Key, String.Join(", ", venue.Value));
                    //foreach (var performer in venue.Value)
                    //{
                    //    Console.WriteLine(string.Join(", ",performer));
                    //}
                }
            }
        }
    }
}
