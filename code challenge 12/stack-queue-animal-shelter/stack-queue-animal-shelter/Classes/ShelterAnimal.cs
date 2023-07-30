using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_queue_animal_shelter.Classes
{
    public class ShelterAnimal
    {
        public string animal { get; set; }
        public string species { get; set; }

        public ShelterAnimal()
        {
            animal = "";
        }

        public ShelterAnimal(string animal)
        {
            this.animal = animal;
        }
    }

}
