using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleLib;

namespace PeopleConsole6
{
    class Program
    {
        static void Main(string[] args)
        {
            CPerson p1 = new CPerson();
            CPerson p2 = new CPerson(19, 180, "Juan");

            p1 = p2.GetCopy();
            Console.WriteLine(p1.GetName() + " is " + p1.GetAge());
            Console.ReadKey();
        }
    }
}
