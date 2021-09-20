using System;

namespace Windows_Docker_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple App that tells time

            DateTime curDay = DateTime.Now;

            Console.WriteLine("The Current day is..");
            Console.WriteLine(curDay);
            Console.WriteLine("");
            Console.WriteLine("Press Any Key to exit");

            Console.ReadLine();
        }
    }
}
