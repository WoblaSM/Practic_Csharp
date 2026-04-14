using System.Diagnostics;

namespace Lab9.Green
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1 t1 = new Task1("Hello World");
            Console.WriteLine(t1.Output);
            Console.WriteLine(t1.Input);
            t1.Review();
            Console.WriteLine(t1.Output);
            Console.WriteLine(t1.Input);

            string textOutput = t1.ToString();
            Console.WriteLine(textOutput);
            Console.WriteLine(t1.ToString());
            Console.WriteLine(t1);
        }

    }
}
