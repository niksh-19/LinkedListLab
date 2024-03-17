using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace LinkedListLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("Joe Blow");
            list.AddLast("Joe Schmoe");
            list.AddLast("John Smith");
            list.AddLast("Jane Doe");
            list.AddLast("Bob Bobberson");
            list.AddLast("Sam Sammerson");
            list.AddLast("Dave Daverson");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
