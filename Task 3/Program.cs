namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Printer
            Printer printer = new Printer();
            printer.Print("Merry Christmas!");
            printer.Print(25);
            printer.Print("EH...!", 2);

            Console.WriteLine("\n----------------------\n");

            //Nepali 
            NepaliTeacher nep = new NepaliTeacher();
            nep.Name = "Prince";
            Console.WriteLine($"Teacher Name: {nep.Name}");
            nep.Teaching();
            nep.SalaryInfo();

            Console.WriteLine();

            //English
            EnglishTeacher eng = new EnglishTeacher();
            eng.Name = "Rose";
            Console.WriteLine($"Teacher Name: {eng.Name}");
            eng.Teaching();
            eng.SalaryInfo();

        }
    }
}
