namespace LoopsBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            for (int counter = 10; counter >= 0; counter--) 
            {
                Console.WriteLine("Counter is " + counter);
            }

            Console.ReadKey();
        }
    }
}
