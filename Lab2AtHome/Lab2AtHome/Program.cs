using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2AtHome
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Program Greeting
            Console.WriteLine("*****************************");
            Console.WriteLine("\tHello World! \n  This is my first program!");
            Console.WriteLine("*****************************");
            #endregion

            #region SportsCar Object Instantiation
            SportsCar myCar = new SportsCar();
            myCar.PetName = "Corvette";
            Console.WriteLine("My car: {0}\n", myCar.PetName);
            #endregion
        }
    }
}
