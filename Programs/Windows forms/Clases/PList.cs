using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class PList
    {
        const int Max = 100;
        Punto[] lista;
        int num;

        public PList()
        {
            num = 0;
            lista = new Punto[Max];
        }
        public void AddPunto(Punto p)
        {
            try
            {
                if (num != Max)
                {
                    lista[this.num] = p;
                    this.num++;
                }
                else
                {
                    Console.WriteLine("The list is already full");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Format ERROR!");
            }
        }
        public Punto GetPunto(int i)
        {
            if (num != 0)
            {
                return this.lista[i];
            }
            else
            {
                Console.WriteLine("The list is empty");
                return null;
            }
        }
        public void MoveAll(int incX, int incY)
        {
            for(int i = 0; i<num; i++)
            {
                lista[i].Move(incX, incY);
            }
        }
        public int GetNum()
        {
            return this.num;
        }
        public void RemoveAll()
        {
            while(num > 0)
            {
                lista[num] = null;
                num--;
            }
        }
    }
}
