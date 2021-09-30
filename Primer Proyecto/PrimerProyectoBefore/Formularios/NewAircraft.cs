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
    public partial class NewAircraft : Form
    {
        FlightPlan p;
        public NewAircraft()
        {
            InitializeComponent();
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            string name = id.Text;
        }

        private void currentX_TextChanged(object sender, EventArgs e)
        {
            double cX = Convert.ToDouble(currentX.Text);
        }

        private void currentY_TextChanged(object sender, EventArgs e)
        {
            double cY = Convert.ToDouble(currentY.Text);
        }

        private void finalX_TextChanged(object sender, EventArgs e)
        {
            double fX = Convert.ToDouble(finalX.Text);
        }

        private void finalY_TextChanged(object sender, EventArgs e)
        {
            double fY = Convert.ToDouble(finalY.Text);
        }

        private void velocity_TextChanged(object sender, EventArgs e)
        {
            double speed = Convert.ToDouble(velocity.Text);
        }
    }
}
