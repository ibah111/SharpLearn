using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using Basics;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($"item {i}");
                    Basic.ScanUri(args[i]);
                }
            }
            else { Console.WriteLine("Args empty"); }
        }
    }
}