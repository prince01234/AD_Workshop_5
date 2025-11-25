namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //car
            Car ca = new Car();
            ca.Brand = "BYD";
            ca.Speed = "220";
            ca.isEV = true;


            //Motorcycle
            Motorcycle bike = new Motorcycle();
            bike.Brand = "Kawasaki";
            bike.Speed = "280";
            bike.CC = 650;

            Console.WriteLine("Car Info:");
            ca.Start();
            ca.Stop();
            ca.DisplayInfo();

            Console.WriteLine();

            Console.WriteLine("Motorcycle Info:");
            bike.Start();
            bike.Stop();
            bike.DisplayInfo();


        }
    }
}
