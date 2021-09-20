using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleLib;

namespace PeopleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageIn, ageOut;
            string nameIn, nameOut;
            float heightIn, heightOut;


            CPerson myPerson = new CPerson();


            Console.Write("Write the name of the person: ");
            nameIn = Console.ReadLine();
            myPerson.SetName(nameIn);

            nameOut = myPerson.GetName();

            Console.Write("Write the height of the person: ");
            heightIn = float.Parse(Console.ReadLine());
            myPerson.SetHeight(heightIn);
            heightOut = myPerson.GetHeight();



            Console.Write("Write the age of the person: ");
            ageIn = Convert.ToInt32(Console.ReadLine());
            myPerson.SetAge(ageIn);

            ageOut = myPerson.GetAge();
            Console.WriteLine(nameOut + " is " + ageOut + " years old and " + heightOut + " meters tall.");
            Console.ReadKey();
        }
    }
}
