using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleLib;

namespace PeopleConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            CPerson p1 = new CPerson(22, 165, "Ana");
            CPerson p2 = new CPerson(19, 180, "Juan");


            if (p1.IsOlderThan(p2))
            {
                Console.WriteLine(p1.GetName() + " is older than " +
                p2.GetName());
            }
            else
            {
                Console.WriteLine(p2.GetName() + " is older than " +
                p1.GetName());
            }
        }
    }
}
