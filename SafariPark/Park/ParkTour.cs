using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Park
{
    public class ParkTour
    {
        private readonly string[] _sections = new string[4] { "Africa", "America", "Asia", "Europe" };
        private readonly string[] _type = new string[5] { "bears", "cats", "dogs", "birds", "elephants" };

        public void GuideHello()
        {
            Console.WriteLine(" ");
            Console.WriteLine("Hello, dear visitor.");
            Console.WriteLine("Welcome to our Safari Park!");
            Console.WriteLine(" ");
            Console.WriteLine("--Write first criteria for animals you want to see--");
            Console.WriteLine("--Criteria: 'region', 'type', 'info on the animal'");
            Console.WriteLine("--Type 'start over' to any imput to relauch the application--");
            Console.WriteLine(" ");
            Console.WriteLine("Animals by what criterion you want to see?");

            string? criterion = Console.ReadLine();

            new Utilities().CheckLine(criterion);
            if (criterion == "region")
            {
                Console.WriteLine("We have animals from Africa, America, Asia, and Europe");
                Console.WriteLine("What region you want to see? (only one)");

                string? region = Console.ReadLine();
                new Utilities().CheckLine(region);

                foreach (string section in _sections)
                {
                    if (region == section)
                    {
                        new Guide().WeHaveAnimalsFrom(region);
                    }
                }
            }

            if (criterion == "type")
            {
                Console.WriteLine("We have bears, cats, dogs, birds, elephants");
                Console.WriteLine("What animals you want to see? (only one)");

                string? animaltype = Console.ReadLine();
                new Utilities().CheckLine(animaltype);

                // void WeHaveTheseSpecies(string? animaltype)
                // {
                    // Console.WriteLine($"We have these species of {animaltype}:");
                    // string[] animalsoftype = new string[10];
                // }
            }

            if (criterion == "info on the animal")
            {
                Console.WriteLine("What animal you want to learn about?");
                var infoanimal = Console.ReadLine();
                new Guide().IWannaLearnAbout(infoanimal);
            }
        }
    }
}
