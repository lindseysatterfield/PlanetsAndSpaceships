using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            planetList.Add("Juipter");
            planetList.Add("Saturn");

            List<string> otherPlanets = new List<string>() { "Uranus", "Neptune" };
            planetList.AddRange(otherPlanets);
            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine("These are rocky planets!");
            foreach (var planet in rockyPlanets)
            {
                Console.WriteLine(planet);
            }
            Console.WriteLine();

            planetList.Remove("Pluto");
            Console.WriteLine("This is a list of planets minus Pluto since it is now a dwarf planet.");
            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }
            Console.WriteLine();

            var probes = new Dictionary<string, List<string>>();

            probes.Add("Jupiter", new List<string> { "Voyager 1", "Voygager 2", "Juno", "Pioneer 10"});
            probes.Add("Neputune", new List<string> { "Voyager 2", "IHP-2"});
            probes.Add("Uranus", new List<string> { "Cassini", "Pioneer 11"});

            foreach (var (probe, planets) in probes)
            {
                Console.WriteLine(probe);
                foreach (var pla in planets)
                {
                    Console.WriteLine($"\t{pla}");
                }
            }
        }
    }
}
