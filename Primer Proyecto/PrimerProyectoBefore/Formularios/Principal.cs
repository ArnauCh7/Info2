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
            PictureBox pic = new PictureBox();
            pic.Size = new Size(5, 5);
            pic.BackColor = Color.Red;
            if(p == null)
            {
            }
            else
            {
                pic.Location = new Point(Convert.ToInt32(p.GetCurrentPosition().GetX()), Convert.ToInt32(p.GetCurrentPosition().GetY()));
                panel.Controls.Add(pic);
                misPics[numPics] = pic;
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
                misPics[i].Location = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetX()), Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetY()));
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
                    misPics[i].Location = new Point(Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetX()), Convert.ToInt32(milista.GetFlightPlan(i).GetCurrentPosition().GetY()));
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
