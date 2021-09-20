using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleLib;

namespace PeopleConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            CPerson p1 = new CPerson();
            CPerson p2 = new CPerson(19, 180, "Juan");

            Console.WriteLine("The first person is " + p1.GetAge());
            Console.WriteLine(p2.GetName() + " is " + p2.GetAge());
            Console.ReadKey();
        }
    }
}
