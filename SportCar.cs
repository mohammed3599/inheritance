using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keywords
{
    internal class SportCar : Car
    {
        string nitros;
        string specialSeatbelt;

        public SportCar(string engine, string gearType, string color, int numberOfTyres, int numberOfDoors, string nitros, string specialSeatbelt) : base(engine, gearType, color, numberOfTyres, numberOfDoors)
        {
            this.nitros = nitros;
            this.specialSeatbelt = specialSeatbelt;
        }
    }
}
