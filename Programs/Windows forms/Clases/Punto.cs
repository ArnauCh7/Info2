using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Punto
    {
        int X;
        int Y;

        public Punto(int X, int Y)
        {
            try
            {
                this.X = X;
                this.Y = Y;
            }
            catch (FormatException)
            {
                Console.WriteLine("Format ERROR!");
            }
        }

        public int GetX()
        {
            return this.X;
        }

        public int GetY()
        {
            return this.Y;
        }

        public void Move(int incX, int incY)
        {
            this.X = this.X + incX;
            this.Y = this.Y + incY;
        }
    }
}
