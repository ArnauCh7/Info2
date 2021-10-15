using System;
using System.Collections.Generic;
using System.Text;

namespace FlightLib
{
    public class FlightPlan
    {
        // Atributos

        string id; // identificador
        Position initialPosition; // posicion inicial
        Position currentPosition; // posicion actual
        Position finalPosition; // posicion final
        double velocidad;

        // Constructures
        public FlightPlan(string id, double cpx, double cpy, double fpx, double fpy, double velocidad)
        {
            this.id = id;
            this.initialPosition = new Position(cpx, cpy);
            this.currentPosition = new Position(cpx, cpy);
            this.finalPosition = new Position(fpx, fpy);
            this.velocidad = velocidad;
        }

        // Metodos

        public void SetVelocidad(double velocidad)
        // setter del atributo velocidad
        { this.velocidad = velocidad;  }

        public void Mover(double tiempo)
        // Mueve el vuelo a la posición correspondiente a viajar durante el tiempo que se recibe como parámetro
        {
            //Calculamos la distancia recorrida en el tiempo dado
            double distancia = tiempo * this.velocidad / 60;

            //Calculamos las razones trigonométricas
            double hipotenusa = Math.Sqrt((finalPosition.GetX() - currentPosition.GetX()) * (finalPosition.GetX() - currentPosition.GetX()) + (finalPosition.GetY() - currentPosition.GetY()) * (finalPosition.GetY() - currentPosition.GetY()));
            double coseno = (finalPosition.GetX() - currentPosition.GetX()) / hipotenusa;
            double seno = (finalPosition.GetY() - currentPosition.GetY()) / hipotenusa;

            //Caculamos la nueva posición del vuelo
            double x = currentPosition.GetX() + distancia * coseno;
            double y = currentPosition.GetY() + distancia * seno;

            Position nextPosition = new Position(x, y);

            if (currentPosition.Distancia(nextPosition) < hipotenusa)
                currentPosition = nextPosition;
            else
                currentPosition = finalPosition;
        }    

        public bool Destino()
        {
            bool resultado = false;
            // Si la posicion actual es igual a la final, devuelve true
            if (this.currentPosition == this.finalPosition) resultado = true;

            return resultado;
        }

        public bool Conflicto(FlightPlan b, double distanciaSeguridad)
        {
            bool conflicto = false;
            if (this.currentPosition.Distancia(b.currentPosition) < distanciaSeguridad)
                conflicto = true;

            return conflicto;
        }
        public Position GetCurrentPosition()
        {
            return this.currentPosition;
        }
        public string GetID()
        {
            return this.id;
        }
        public double GetVelocity()
        {
            return this.velocidad;
        }

        public void GoInitialPosition()
        {
            currentPosition = initialPosition;
        }

        public Position GetInitialPosition()
        {
            return this.initialPosition;
        }

        public Position GetFinalPosition()
        {
            return this.finalPosition;
        }

        public double minDistance(FlightPlan f)
        {
            double x1 = this.initialPosition.GetX();
            double x2 = f.initialPosition.GetX();
            double y1 = this.initialPosition.GetY();
            double y2 = f.initialPosition.GetY();

            double hipo1 = Math.Sqrt((this.finalPosition.GetX() - this.initialPosition.GetX()) * (this.finalPosition.GetX() - this.initialPosition.GetX()) + (this.finalPosition.GetY() - this.initialPosition.GetY()) * (this.finalPosition.GetY() - this.initialPosition.GetY()));
            double cos1 = (this.finalPosition.GetX() - this.initialPosition.GetX()) / hipo1;
            double sen1 = (this.finalPosition.GetY() - this.initialPosition.GetY()) / hipo1;

            double hipo2 = Math.Sqrt((f.finalPosition.GetX() - f.initialPosition.GetX()) * (f.finalPosition.GetX() - f.initialPosition.GetX()) + (f.finalPosition.GetY() - f.initialPosition.GetY()) * (f.finalPosition.GetY() - f.initialPosition.GetY()));
            double cos2 = (f.finalPosition.GetX() - f.initialPosition.GetX()) / hipo1;
            double sen2 = (f.finalPosition.GetY() - f.initialPosition.GetY()) / hipo1;

            double vx1 = this.velocidad * cos1;
            double vx2 = f.velocidad * cos2;
            double vy1 = this.velocidad * sen1;
            double vy2 = f.velocidad * sen2;

            double t =(x1*(vx2-vx1)+x2*(vx1-vx2)+y1*(vy2-vy1)+y2*(vy1-vy2))/((Math.Pow(vx1,2))+(Math.Pow(vx2,2))-2*vx1*vx2+(Math.Pow(vy1,2))+(Math.Pow(vy2,2))-2*vy2*vy1);

            double x1min = (x1 + vx1 * t);
            double y1min = (y1 + vy1 * t);

            double x2min = (x2 + vx2 * t);
            double y2min = (y2 + vy2 * t);

            Position p1 = new Position(x1min, y1min);
            Position p2 = new Position(x2min, y2min);

            double dist = p1.Distancia(p2);

            return dist;

        }

    }
}
