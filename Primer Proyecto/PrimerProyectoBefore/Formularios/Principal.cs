using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightLib;

namespace Formularios
{
    public partial class Principal : Form
    {
        FlightPlanList milista = new FlightPlanList();
        PictureBox[] misPics = new PictureBox[10];
        PictureBox[] finalPics = new PictureBox[10];
        PictureBox[] initialPics = new PictureBox[10];
        PictureBox[] distanceCircles = new PictureBox[10];
        System.Drawing.Graphics graphics;
        bool romper = false;//bool para que no aparezcan dos ventanas de que hay colision en la comprovación por cada tick del reloj
        int numPics = 0;//numero de imagenes en las listas (son todas iguales porque es una por avion)
        int distance;
        bool x;//bool para saber en que posicion esta el boton stop/resume
        int segundos;//texto que sale en el contador de tiempo
        double distanciaSeguridad;//variable donde se guarda la distancia de seguridad
        public Principal()
        {
            InitializeComponent();
        }

        private void newAircraftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAircraft form = new NewAircraft();
            form.ShowDialog();
            FlightPlan p = form.GetFlight();
            milista.AddFlightPlan(p);
            distanciaSeguridad = form.GetSafetyDistance();
            if(p == null)
            {
            }
            else
            {
                PictureBox pic = new PictureBox();
                pic.Width = 40;
                pic.Height = 40;
                pic.ClientSize = new Size(40, 40);
                pic.Location = new Point(Convert.ToInt32(p.GetCurrentPosition().GetX()-20), Convert.ToInt32(p.GetCurrentPosition().GetY()-20));
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Tag = p;
                pic.Click += new System.EventHandler(this.evento);
                Bitmap fotoAvion = new Bitmap("avion.gif");
                pic.Image = (Image)fotoAvion;

                PictureBox pic1 = new PictureBox();
                pic1.Width = 20;
                pic1.Height = 20;
                pic1.ClientSize = new Size(20, 20);
                pic1.Location = new Point(Convert.ToInt32(p.GetInitialPosition().GetX() - 10), Convert.ToInt32(p.GetInitialPosition().GetY() - 10));
                pic1.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap fotoInicio = new Bitmap("puntoInicial.png");
                pic1.Image = (Image)fotoInicio;

                PictureBox pic2 = new PictureBox();
                pic2.Width = 20;
                pic2.Height = 20;
                pic2.ClientSize = new Size(20, 20);
                pic2.Location = new Point(Convert.ToInt32(p.GetFinalPosition().GetX() - 10), Convert.ToInt32(p.GetFinalPosition().GetY() - 10));
                pic2.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap fotoFinal = new Bitmap("puntoFinal.png");
                pic2.Image = (Image)fotoFinal;
                
                PictureBox pic3 = new PictureBox();
                pic3.Width = Convert.ToInt32(distanciaSeguridad);
                pic3.Height = Convert.ToInt32(distanciaSeguridad);
                pic3.ClientSize = new Size(Convert.ToInt32(distanciaSeguridad), Convert.ToInt32(distanciaSeguridad));
                pic3.Location = new Point(Convert.ToInt32(p.GetCurrentPosition().GetX() - Convert.ToInt32(distanciaSeguridad)/2), Convert.ToInt32(p.GetCurrentPosition().GetY() - Convert.ToInt32(distanciaSeguridad)/2));
                pic3.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap fotoCirculo = new Bitmap("circuloDistancia.png");
                pic3.Image = (Image)fotoCirculo;
                

                Pen myPen = new Pen(Color.Black);
                Point initialPoint = new Point(Convert.ToInt32(p.GetInitialPosition().GetX()), Convert.ToInt32(p.GetInitialPosition().GetY()));
                Point finalPoint = new Point(Convert.ToInt32(p.GetFinalPosition().GetX()), Convert.ToInt32(p.GetFinalPosition().GetY()));
                //this.graphics.DrawEllipse(myPen, Convert.ToInt32(p.GetInitialPosition().GetX()-distanciaSeguridad/2), Convert.ToInt32(p.GetInitialPosition().GetY()-distanciaSeguridad/2), Convert.ToInt32(distanciaSeguridad), Convert.ToInt32(distanciaSeguridad));
                this.graphics.DrawLine(myPen, initialPoint, finalPoint);
                myPen.Dispose();

                panel.Controls.Add(pic);
                panel.Controls.Add(pic1);
                panel.Controls.Add(pic2);
                panel.Controls.Add(pic3);
                misPics[numPics] = pic;
                initialPics[numPics] = pic1;
                finalPics[numPics] = pic2;
                distanceCircles[numPics] = pic3;
                numPics++;
            }
        }
        private void evento(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            FlightPlan info = (FlightPlan)pic.Tag;
            MessageBox.Show(info.GetID() + ": " +
                " Current X: " + Convert.ToString(info.GetCurrentPosition().GetX()) +
                " Current Y: " + Convert.ToString(info.GetCurrentPosition().GetY()) +
                " Final X: " + Convert.ToString(info.GetFinalPosition().GetX()) +
                " Final Y: " + Convert.ToString(info.GetFinalPosition().GetY()) +
                " Velocity: " + info.GetVelocity());
        }

        private void mover_Click(object sender, EventArgs e)
        {
            milista.Mover(10);
            for (int i = 0; i < milista.GetLength(); i++)
            {
                misPics[i].Location = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetX()-20), Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetY()-20));
                Pen myPen = new Pen(Color.Black);
                //this.graphics.DrawEllipse(myPen, Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetX() - distanciaSeguridad / 2), Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetY() - distanciaSeguridad / 2), Convert.ToInt32(distanciaSeguridad), Convert.ToInt32(distanciaSeguridad));
                Point initialPoint = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetInitialPosition().GetX()), Convert.ToInt32(milista.GetFlightPlan(i).GetInitialPosition().GetY()));
                Point finalPoint = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetFinalPosition().GetX()), Convert.ToInt32(milista.GetFlightPlan(i).GetFinalPosition().GetY()));
                this.graphics.DrawLine(myPen, initialPoint, finalPoint);
                myPen.Dispose();
                distanceCircles[i].Location = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetX() - Convert.ToInt32(distanciaSeguridad)/2), Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetY() - Convert.ToInt32(distanciaSeguridad)/2));
            }
        }

        private void auto_Click(object sender, EventArgs e)
        {
            if (milista.GetLength() < 2)
            {
                autoData t = new autoData();
                t.ShowDialog();
                this.distance = t.GetDist();
                if (t.GetTiempo() == 0)
                {
                }
                else
                {
                    reloj.Interval = Convert.ToInt32(t.GetTiempo());
                    reloj.Start();
                }
            }
            else
            {
                if (milista.GetFlightPlan(0).minDistance(milista.GetFlightPlan(1)) <= distanciaSeguridad)
                {
                    conflictAvoid av = new conflictAvoid();
                    av.ShowDialog();
                    if (av.GetAvoid() == true)
                    {
                        while (milista.GetFlightPlan(0).minDistance(milista.GetFlightPlan(1)) <= distanciaSeguridad)
                        {
                            milista.GetFlightPlan(0).SetVelocidad(milista.GetFlightPlan(0).GetVelocity() - 1);
                        }
                        autoData t = new autoData();
                        t.ShowDialog();
                        this.distance = t.GetDist();
                        if (t.GetTiempo() == 0)
                        {
                        }
                        else
                        {
                            reloj.Interval = Convert.ToInt32(t.GetTiempo());
                            reloj.Start();
                        }
                    }
                    else
                    {
                        autoData t = new autoData();
                        t.ShowDialog();
                        this.distance = t.GetDist();
                        if (t.GetTiempo() == 0)
                        {
                        }
                        else
                        {
                            reloj.Interval = Convert.ToInt32(t.GetTiempo());
                            reloj.Start();
                        }
                    }
                    
                }
                else
                {
                    autoData t = new autoData();
                    t.ShowDialog();
                    this.distance = t.GetDist();
                    if (t.GetTiempo() == 0)
                    {
                    }
                    else
                    {
                        reloj.Interval = Convert.ToInt32(t.GetTiempo());
                        reloj.Start();
                    }
                }
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (x == true)
            {
                stop.Text = "RESUME";
                reloj.Stop();
                x = false;
            }
            else
            {
                stop.Text = "STOP";
                reloj.Start();
                x = true;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            milista.RemoveAll();
            segundos = 0;
            label5.Text = Convert.ToString(segundos);
            for (int i = 0; i < numPics; i++)//Bucle que elimina todas las fotos de el panel
            {
                panel.Controls.Remove(misPics[i]);
                panel.Controls.Remove(initialPics[i]);
                panel.Controls.Remove(finalPics[i]);
                panel.Controls.Remove(distanceCircles[i]);
            }
            romper = false;//Setea la variable que rompe el bucle de conflicto a false de nuevo
            panel.Invalidate();//Limpa el panel de los dibujos que tiene
            reloj.Stop();
            stop.Text = "STOP";
        }

        private void aircraftListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlightGrind grind = new FlightGrind();
            grind.GiveList(milista);
            grind.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos = Convert.ToInt32(label5.Text) + 1;
            label5.Text = Convert.ToString(segundos);
            int allArrived = 0;

            
            for (int i=0; i<milista.GetLength(); i++)
            {
                if (milista.GetFlightPlan(i).Destino()== true)
                {
                    allArrived += 1;
                }
            }

            for(int i=0; i< milista.GetLength(); i++)
            {
                if (romper == false)
                {
                    for (int j = 0; j < milista.GetLength(); j++)
                    {
                        if (milista.GetFlightPlan(i) == milista.GetFlightPlan(j))
                        {
                        }
                        else
                        {
                            if (milista.GetFlightPlan(i).Conflicto(milista.GetFlightPlan(j), distanciaSeguridad) == true)
                            {
                                reloj.Stop();
                                conflictError error = new conflictError();
                                error.ShowDialog();
                                milista.GetFlightPlan(0).SetVelocidad(error.GetV1());
                                milista.GetFlightPlan(1).SetVelocidad(error.GetV2());
                                romper = true;
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            if (allArrived == milista.GetLength())
            {
                Console.WriteLine("All aircrafts arrived to it's destination");
                reloj.Stop();
            }
            else
            {
                milista.Mover(this.distance);
                for (int i = 0; i < milista.GetLength(); i++)
                {
                    misPics[i].Location = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetX()-20), Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetY()-20));
                    Pen myPen = new Pen(Color.Black);
                    //this.graphics.DrawEllipse(myPen, Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetX() - distanciaSeguridad / 2), Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetY() - distanciaSeguridad / 2), Convert.ToInt32(distanciaSeguridad), Convert.ToInt32(distanciaSeguridad));
                    Point initialPoint = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetInitialPosition().GetX()), Convert.ToInt32(milista.GetFlightPlan(i).GetInitialPosition().GetY()));
                    Point finalPoint = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetFinalPosition().GetX()), Convert.ToInt32(milista.GetFlightPlan(i).GetFinalPosition().GetY()));
                    this.graphics.DrawLine(myPen, initialPoint, finalPoint);
                    myPen.Dispose();
                    distanceCircles[i].Location = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetX() - Convert.ToInt32(distanciaSeguridad)/2), Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetY() - Convert.ToInt32(distanciaSeguridad)/2));
                }
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<milista.GetLength(); i++)
            {
                milista.GetFlightPlan(i).GoInitialPosition();
                misPics[i].Location = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetX()-20), Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetY()-20));
                Pen myPen = new Pen(Color.Black);
                //this.graphics.DrawEllipse(myPen, Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetX() - distanciaSeguridad / 2), Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetY() - distanciaSeguridad / 2), Convert.ToInt32(distanciaSeguridad), Convert.ToInt32(distanciaSeguridad));
                Point initialPoint = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetInitialPosition().GetX()), Convert.ToInt32(milista.GetFlightPlan(i).GetInitialPosition().GetY()));
                Point finalPoint = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetFinalPosition().GetX()), Convert.ToInt32(milista.GetFlightPlan(i).GetFinalPosition().GetY()));
                this.graphics.DrawLine(myPen, initialPoint, finalPoint);
                myPen.Dispose();
                romper = false;
                distanceCircles[i].Location = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetX() - Convert.ToInt32(distanciaSeguridad)/2), Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetY() - Convert.ToInt32(distanciaSeguridad)/2));
                reloj.Stop();
                stop.Text = "STOP";
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = panel.CreateGraphics();
            this.graphics = graphics;
        }
                
    }
}
