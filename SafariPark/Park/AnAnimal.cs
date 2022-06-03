using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Park
{
    public class AnAnimal
    {
        public string _division = "mammal";
        public string _type = "bear";
        public string? _specie;
        public string? _info;

        public AnAnimal(string? animal)
        {
            if (animal == "African Elephant")
            {
                SectionAfrica.AfricanElephant anim = new SectionAfrica.AfricanElephant();
                _division = anim._division;
                _type = anim._type;
                _specie = anim._specie;
                _info = anim._info;
            }

            if (animal == "Hyena")
            {
                SectionAfrica.Hyena anim = new SectionAfrica.Hyena();
                _division = anim._division;
                _type = anim._type;
                _specie = anim._specie;
                _info = anim._info;
            }

            if (animal == "Lion")
            {
                SectionAfrica.Lion anim = new SectionAfrica.Lion();
                _division = anim._division;
                _type = anim._type;
                _specie = anim._specie;
                _info = anim._info;
            }

            if (animal == "Vulture")
            {
                SectionAfrica.Vulture anim = new SectionAfrica.Vulture();
                _division = anim._division;
                _type = anim._type;
                _specie = anim._specie;
                _info = anim._info;
            }

            if (animal == "Bobcat")
            {
                SectionAmerica.Bobcat anim = new SectionAmerica.Bobcat();
                _division = anim._division;
                _type = anim._type;
                _specie = anim._specie;
                _info = anim._info;
            }
        }
    }
}
