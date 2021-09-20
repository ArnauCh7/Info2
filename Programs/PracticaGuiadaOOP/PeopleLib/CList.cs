using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PeopleLib
{
    public class CList
    {
        const int MAXP = 10; // maximum number of people
        int number; // number of people in the list
        CPerson[] people; // vector of people
        /// Constructor. Initializes the attributes of the list
        public CList()
        {
            number = 0;
            people = new CPerson[MAXP];
        }
        /// Adds a person at the end of the list
        /// param p: The person to be added
        /// returns: 0 everything Ok, -1 the vector was full
        public int AddPerson(CPerson p)
        {
            if (number == MAXP)
            {
                return -1;
            }
            else
            {
                people[number] = p;
                number++;
                return 0;
            }
        }

        /// Returns the person in a particular position of the list
        /// param i: Position in the list
        /// returns: Person at "i", null if index not valid
        public CPerson GetPerson(int i)
        {
            if (i < 0 || i >= number)
            {
                return null;
            }
            else
            {
                return people[i];
            }
        }

        public int GetNumber()
        {
            return number;
        }
        public CPerson GetYoungestPerson()
        {
            if (number == 0)
            {
                return null;
            }
            else
            {
                CPerson youngest = people[0];
                for (int i = 1; i < number; i++)
                {
                    if (youngest.IsOlderThan(people[i]))
                    {
                        youngest = people[i];
                    }
                }
                return youngest;
            }
        }
        public int LoadFromFile(string filename)
        {
            StreamReader r = null;
            try
            {
                r = new StreamReader(filename);
                number = 0;
                string line = r.ReadLine();
                while (line != null && number < MAXP)
                {
                    string[] words = line.Split(':');
                    if (words.Length != 3)
                    {
                        r.Close();
                        return -2;
                    }
                    string name = words[2];
                    int age = Convert.ToInt32(words[0]);
                    float height = float.Parse(words[1]);
                    CPerson p = new CPerson(age, height, name);
                    people[number] = p;
                    number++;
                    line = r.ReadLine();

                }
                return 0;

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File Not Found");
                return -1;
            }
            catch (FormatException)
            {
                r.Close();
                return -2;
            }
        }

    }
}
