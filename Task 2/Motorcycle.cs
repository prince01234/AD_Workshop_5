using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Motorcycle : Vehicle
    {
        public int CC { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h, Engine Capacity: {CC} cc");
        }
    }
}
