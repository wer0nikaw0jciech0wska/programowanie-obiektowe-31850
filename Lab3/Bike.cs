using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8
{
    public class Bike : Vehicle
    {
        public Bike(double engineCapacity, string model, int year) : base(engineCapacity, model, year)
        {
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine("Bike staretd");
        }
        public override void Test()
        {
            Console.WriteLine("Bike test");
        }
    }
}
