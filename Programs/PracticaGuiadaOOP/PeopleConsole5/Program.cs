using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleLib;

namespace PeopleConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            CPerson p1 = new CPerson();
            CPerson p2 = new CPerson(19, 180, "Juan");


            p2.CopyAgeTo(p1);

            Console.WriteLine("p1 is " + p1.GetAge());
        }
    }
}
