using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keywords
{
    internal class A
    {
        int numberOfWheels;
        public static int someNumber = 2;
        public A(int parameter) 
        {
            numberOfWheels = parameter;   
        }
        public int getDoubleNumberOfWheels()
        {
            someNumber = someNumber * 10;

            return numberOfWheels * 2;
        }
        public static void getFloatNumberOfWheels()
        {
            Console.WriteLine("TEST");
        }

    }
}
