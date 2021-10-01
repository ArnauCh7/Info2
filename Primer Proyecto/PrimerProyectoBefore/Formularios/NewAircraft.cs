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
        double safetyDistance;
        public NewAircraft()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            try
            {
                p = new FlightPlan(id.Text, Convert.ToDouble(currentX.Text), Convert.ToDouble(currentY.Text), Convert.ToDouble(finalX.Text), Convert.ToDouble(finalY.Text), Convert.ToDouble(velocity.Text));
                safetyDistance = Convert.ToDouble(safe.Text);
                Close();
            }
            catch(FormatException)
            {
                ErrorFormato error = new ErrorFormato();
                error.ShowDialog();
            }
        }
        public FlightPlan GetFlight()
        {
            return this.p;
        }

        public double GetSafetyDistance()
        {
            return safetyDistance;
        }
    }
}
