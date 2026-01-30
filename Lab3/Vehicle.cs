using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8
{
    public abstract class Vehicle
    {
        public int Id { get; protected set; }
        public double EngineCapacity { get; protected set; }

        public string Model { get; protected set; }

        public int Year {  get; protected set; }

        public Vehicle(double engineCapacity, string model, int year)
        {
            EngineCapacity = engineCapacity;
            Model = model;
            Year = year;
        }
        public virtual void Start()
        {
            Console.WriteLine("Vehicle stared");
        }
        public void Stop()
        {
            Console.WriteLine("Vehicle stopped");
        }
        public abstract void Test();
    }
}
