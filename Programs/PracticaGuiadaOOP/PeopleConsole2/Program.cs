using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleLib;

namespace PeopleConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myAge;
            string myName;

            CPerson myPerson = new CPerson(19, 180, "Juan");

            myAge = myPerson.GetAge();
            myName = myPerson.GetName();
            Console.WriteLine(myName + " is " + myAge + " years old.");
        }
    }
}
