using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public string Speed { get; set; }

        public void Start()
        {
            Console.WriteLine($"The {Brand} is starting...");
        }

        public void Stop()
        {
            Console.WriteLine($"The {Brand} is stopping...");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h...");
        }
    }
}
