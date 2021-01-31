using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable CS0234 // The type or namespace name 'WriteLine' does not exist in the namespace 'Console' (are you missing an assembly reference?)
            Console.WriteLine("Hello World!");
#pragma warning restore CS0234 // The type or namespace name 'WriteLine' does not exist in the namespace 'Console' (are you missing an assembly reference?)
        }
    }
}
