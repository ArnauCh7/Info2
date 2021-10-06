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
        PictureBox[] misPics = new PictureBox[100];
        PictureBox[] finalPics = new PictureBox[100];
        PictureBox[] initialPics = new PictureBox[100];
        PictureBox[] distanceCircles = new PictureBox[100];
        int numPics = 0;
        int distance;
        bool x;
        int segundos;
        double distanciaSeguridad;
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


                panel.Controls.Add(pic);
                panel.Controls.Add(pic1);
                panel.Controls.Add(pic2);
                misPics[numPics] = pic;
                initialPics[numPics] = pic1;
                finalPics[numPics] = pic2;
                numPics++;
            }
        }

        private void mover_Click(object sender, EventArgs e)
        {
            timeMove t = new timeMove();
            t.ShowDialog();
            milista.Mover(t.GetTime());
            for (int i = 0; i < milista.GetLength(); i++)
            {
                misPics[i].Location = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetX()-10), Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetY()-10));
            }
        }

        private void auto_Click(object sender, EventArgs e)
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
            for (int i = 0; i < numPics; i++)
            {
                panel.Controls.Remove(misPics[i]);
            }
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
                for(int j=0; j<milista.GetLength(); j++)
                {
                    if (milista.GetFlightPlan(i) == milista.GetFlightPlan(j))
                    {
                    }
                    else
                    
                        if (milista.GetFlightPlan(0).Conflicto(milista.GetFlightPlan(1), distanciaSeguridad) == true)
                        {
                            reloj.Stop();
                            conflictError error = new conflictError();
                            error.ShowDialog();
                            milista.GetFlightPlan(0).SetVelocidad(error.GetV1());
                            milista.GetFlightPlan(1).SetVelocidad(error.GetV2());
                            
                        }
                    
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
                    misPics[i].Location = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetX()-10), Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetY()-10));
                }
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<milista.GetLength(); i++)
            {
                milista.GetFlightPlan(i).GoInitialPosition();
                misPics[i].Location = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetX()), Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetY()));
            }
        }
    }
}
