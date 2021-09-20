using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleLib;

namespace PeopleConsole8
{
    class Program
    {
        static void Main(string[] args)
        {
            CList aList = new CList();

            int c = aList.LoadFromFile("people.txt");
            if (c == 0)
            {
                Console.WriteLine("File loeaded correctly");
            }
            else if (c == -1)
            {
                Console.WriteLine("Error 404, Not Found!");
            }
            else if (c == -2)
            {
                Console.WriteLine("Format error, try again");
            }

            Console.WriteLine("There is {0} people in the group.", aList.GetNumber());
            for(int i = 0; i < aList.GetNumber(); i++)
            {
                CPerson p = aList.GetPerson(i);
                Console.WriteLine("Name: {0}, Age: {1}, Height: {2}", p.GetName(), p.GetAge(), p.GetHeight());
            }
            Console.ReadKey();
        }
    }
}
