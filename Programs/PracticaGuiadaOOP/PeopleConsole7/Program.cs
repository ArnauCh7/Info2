using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleLib;

namespace PeopleConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty list and three people
            CList myList = new CList();
            CPerson p1 = new CPerson();
            CPerson p2 = new CPerson();
            CPerson p3;
            try
            {
                //Asks the user to enter the parameters of the two first CPersons
                Console.WriteLine("Write the name of the person: ");
                p1.SetName(Console.ReadLine());

                Console.WriteLine("Enter the person's age: ");
                p1.SetAge(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Enter person's height: ");
                p1.SetHeight(float.Parse(Console.ReadLine()));

                Console.WriteLine("Write the name of the person: ");
                p2.SetName(Console.ReadLine());

                Console.WriteLine("Enter the person's age: ");
                p2.SetAge(Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Enter person's height: ");
                p2.SetHeight(float.Parse(Console.ReadLine()));
            }
            catch (FormatException)
            {
                Console.WriteLine("There is a format error, please try again");
            }
            // Add two people to the list
            myList.AddPerson(p1);
            myList.AddPerson(p2);
            // Get the first person in the list
            p3 = myList.GetPerson(0);
            if (p3 != null)
            {
                Console.WriteLine("The first person is " + p3.GetName());
            }
            else
            {
                Console.WriteLine("There is nobody in the list");
            }

            // Get the number of people in the list
            int n = myList.GetNumber();
            Console.WriteLine("The are {0} people in the list ", n);
            // Get the youngest person in the list
            CPerson p4 = myList.GetYoungestPerson();
            if (p4 != null)
            {
                Console.WriteLine("The youngest person is " + p4.GetName());
            }
            else
            {
                Console.WriteLine("There is nobody in the list");
            }

            Console.ReadKey();
        }
    }
}
