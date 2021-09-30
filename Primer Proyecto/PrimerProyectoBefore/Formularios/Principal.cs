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
            PictureBox pic = new PictureBox();
            pic.Size = new Size(5, 5);
            pic.BackColor = Color.Red;
            pic.Location = new Point(Convert.ToInt32(p.GetCurrentPosition().GetX()), Convert.ToInt32(p.GetCurrentPosition().GetY()));
            panel.Controls.Add(pic);
            misPics[numPics] = pic;
            numPics++;
        }

        private void mover_Click(object sender, EventArgs e)
        {
            
        }

        private void auto_Click(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {

        }

        private void reset_Click(object sender, EventArgs e)
        {

        }
    }
}
