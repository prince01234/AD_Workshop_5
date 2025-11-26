namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicsStore store = new ElectronicsStore();

            Laptop laptop = new Laptop("Dell", 850);
            Smartphone smartphone = new Smartphone("Samsung", 1200);

            store.AddDevice(laptop);
            store.AddDevice(smartphone);

            store.ShowAllDeviceDetails();
        }
    }
}