using System;
using System.Collections.Generic;
using System.Text;

namespace FlightLib
{
    public class FlightPlanList
    {
        FlightPlan[] vector = new FlightPlan[2];
        int number = 0;

        public int AddFlightPlan(FlightPlan p)
        {
            if (number < 10)
            {
                vector[number] = p;
                number++;
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public FlightPlan GetFlightPlan(int i)
        {
            if (number == 0)
            {
                return null;
            }
            else if (i < 0 || i >= number)
            {
                return null;
            }
            else
            {
                return vector[i];
            }
        }

        public int GetLength()
        {
            return number;
        }

        public void Mover(double tiempo)
        {
            int i = 0;
            while (i < number)
            {
                if(vector[i].Destino() == true)
                {
                    Console.WriteLine(vector[i].GetID() + " arrived to dstination!");
                }
                else
                {
                    vector[i].Mover(tiempo);
                }
                i++;
            }
        }
    }
}
