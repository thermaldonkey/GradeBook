using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            const string V = "foo";
            string name;
            if(args.Length > 0) {
                name = args[0];
            } else {
                name = V;
            }
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
