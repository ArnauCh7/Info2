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
                if (Convert.ToDouble(currentX.Text) <= 800 || Convert.ToDouble(currentX.Text) <= 800)
                {
                    p = new FlightPlan(id.Text, Convert.ToDouble(currentX.Text), Convert.ToDouble(currentY.Text), Convert.ToDouble(finalX.Text), Convert.ToDouble(finalY.Text), Convert.ToDouble(velocity.Text));
                    safetyDistance = Convert.ToDouble(safe.Text);
                    Close();
                }
                else
                {
                    ErrorFormato error = new ErrorFormato();
                    error.ShowDialog();
                }
                
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

        private void default1_Click(object sender, EventArgs e)
        {
            id.Text = "Default 1";
            currentX.Text = "20";
            currentY.Text = "30";
            finalX.Text = "750";
            finalY.Text = "500";
            velocity.Text = "10";
            safe.Text = "70";
        }

        private void default2_Click(object sender, EventArgs e)
        {
            id.Text = "Default 2";
            currentX.Text = "700";
            currentY.Text = "100";
            finalX.Text = "30";
            finalY.Text = "500";
            velocity.Text = "10";
            safe.Text = "70";
        }
    }
}
