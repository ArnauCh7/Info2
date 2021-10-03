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
    public partial class conflictError : Form
    {
        double velocity1;
        double velocity2;
        public conflictError()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                velocity1 = Convert.ToDouble(v1.Text);
                velocity2 = Convert.ToDouble(v2.Text);
                Close();
                ErrorFormato error = new ErrorFormato();
                error.ShowDialog();
            }
            catch(FormatException)
            {
                ErrorFormato error = new ErrorFormato();
                error.ShowDialog();
            }
            
        }

        public double GetV1()
        {
            return velocity1;
        }
        
        public double GetV2()
        {
            return velocity2;
        }
    }
}
