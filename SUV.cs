using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keywords
{
    internal class SUV : Car
    {
        string specialTyre;
        string foldableSeats;
        int extandableLegSpace;

        public SUV(string engine, string gearType, string color, int numberOfTyres, int numberOfDoors, string specialTyre, string foldableSeats, int extandableLegSpace) : base(engine, gearType, color, numberOfTyres, numberOfDoors)
        {
            this.foldableSeats = foldableSeats;
            this.extandableLegSpace = extandableLegSpace;
            this.specialTyre = specialTyre;
        }
    }
}
