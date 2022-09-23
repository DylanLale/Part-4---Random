using System.Text;

namespace Part_4___Random
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Random generator = new Random();

            //Random ints
            Console.WriteLine("2 seperate numbers between 1 and 10");
            Console.WriteLine("Hit enter");
            Console.ReadLine();
            Console.Write(generator.Next(1, 11)); Console.Write(generator.Next(1, 11)); Console.Write(generator.Next(1, 11)); Console.Write(generator.Next(1, 11)); Console.Write(generator.Next(1, 11));

            Console.WriteLine();    

            //DICE
            Console.WriteLine("Rolling dice....");
            Console.WriteLine();
            Console.WriteLine("Hit enter to continue");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine(generator.Next(1, 7));
            Console.WriteLine(generator.Next(1, 7));
            Console.WriteLine();


            //Random Decimals
            Console.WriteLine("Random decimal above 0");
            Console.WriteLine();
            Console.Write(generator.NextDouble()* 10 ); Console.Write(generator.NextDouble() * 10); Console.Write(generator.NextDouble() * 10);
            Console.ReadLine();
        }
    }
}