using SubRedditLogic;

namespace SubReddit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Interval I = new Interval();
            I.Setup();
            I.Run();
        }
    }
}