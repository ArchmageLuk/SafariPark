using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Park
{
    internal class Utilities
    {
        public void StartOver()
        {
            Program.Main();
        }

        public void CheckLine(string? line)
        {
            if (line == null)
            {
                Console.WriteLine("Error");
            }

            if (line == "start over")
            {
                StartOver();
            }
        }
    }
}
