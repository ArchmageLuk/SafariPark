using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Park
{
    internal class Guide
    {
        public void WeHaveAnimalsFrom(string? region)
        {
            string sectionname = "Section" + region;
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@$"D:\Проекти\Навчання С+\Код\SafariPark\SafariPark\Park\{sectionname}");
            int count = dir.GetFiles().Length;
            Console.WriteLine($"We have {count} animals from {region}. These are:");
        }

        public void IWannaLearnAbout(string? specie)
        {
            AnAnimal animal = new AnAnimal(specie);
            Console.WriteLine(" ");
            Console.WriteLine(animal._info);
        }
    }
}
