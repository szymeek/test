using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Car samochod1 = new Car();
            //samochod1.marka = "Ford";
            Car samochod2 = new Car(1.9, "Seat");


            Console.WriteLine(samochod2);
            Console.ReadKey();
             */

            Car car1 = new Car();
            // car1.PokazMarke();
            Car car2 = new Car(4.8, "Ford");

            Car car3 = Car.CreateCar();
            Console.WriteLine(car2.PokazMarke);
            Console.ReadKey();


        }
    }
}
