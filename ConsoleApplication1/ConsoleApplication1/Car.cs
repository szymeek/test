using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;

        public Car()
        {
            this.marka = "Ford";
            this.pojemnoscSilnika = 2.2;
        }

        public Car(double pojemnoscSilnika, string marka)
        {
            this.marka = marka;
            this.pojemnoscSilnika = pojemnoscSilnika;
        }

        public static Car CreateCar()
        {
            return new Car();
        }

        public void PokazMarke()
        {
            Console.WriteLine(marka);
        }
     
        static int iloscKol;
        static Car()
        {
            iloscKol = 4;
        }
        ~Car()
        {
            Console.WriteLine("Zwalnienie pamięci");
            Console.ReadKey();
        }

    }
}
