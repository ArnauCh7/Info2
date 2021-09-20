using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleLib
{
    public class CPerson
    {
        // ATTRIBUTES
        int age;
        float height;
        string name;
        // METHODS
        public void SetName(string n)
        {
            this.name = n;
        }
        public string GetName()
        {
            return (this.name);
        }
        public void SetHeight(float b)
        {
            this.height = b;
        }
        public float GetHeight()
        {
            return (this.height);
        }
        public void SetAge(int a)
        {
            this.age = a;
        }
        public int GetAge()
        {
            return (this.age);
        }
        public CPerson()
        {
            this.age = 7;
        }
        public CPerson(int a, float h, string n)
        {
            this.age = a;
            this.name = n;
            this.height = h;
        }
        public bool IsOlderThan(CPerson p)
        {
            if (this.age > p.GetAge())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void CopyAgeTo(CPerson p)
        {
            p.SetAge(this.age);
        }
        public CPerson GetCopy()
        {
            CPerson p = new CPerson();
            p.SetAge(this.age);
            p.SetHeight(this.height);
            p.SetName(this.name);

            return p;
        }
    }
}