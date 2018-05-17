using System;

namespace ExtensionMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var day in DateTime.Now.TakeDays(3)) {
                Console.WriteLine(day);
            }
        }       
    }
}
