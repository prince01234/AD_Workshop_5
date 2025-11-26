using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class ElectronicsStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"{device.Brand} added to store.");
        }

        public void RemoveDevice(ElectronicDevice device)
        {
            devices.Remove(device);
            Console.WriteLine($"{device.Brand} removed from store.");
        }

        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n Store Device Details \n");

            foreach (var device in devices)
            {
                device.ShowInfo(); // Polymorphism

                // Downcasting to call child-specific methods
                if (device is Laptop)
                {
                    ((Laptop)device).TurnOnBattery();
                }
                else if (device is Smartphone)
                {
                    ((Smartphone)device).EnableCamera();
                }

                Console.WriteLine();
            }
        }
    }
}