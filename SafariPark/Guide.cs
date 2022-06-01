using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark
{
    public class Guide
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
            Console.WriteLine("--Criteria: 'region', 'type', 'specifics'");
            Console.WriteLine("--Write 'start over' to any imput to relauch the application--");
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

                void WeHaveAnimalsFrom(string? region)
                {
                    string sectionname = "Section" + region;
                    System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@$"D:\Проекти\Навчання С+\Код\SafariPark\SafariPark\Park\{sectionname}");
                    int count = dir.GetFiles().Length;
                    Console.WriteLine($"We have {count} animals from {region}. These are:");
                }

                foreach (string section in _sections)
                {
                    if (region == section)
                    {
                        WeHaveAnimalsFrom(region);
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
                    // Here should be search method for animals by field _type
                // }
            }
        }
    }
}
