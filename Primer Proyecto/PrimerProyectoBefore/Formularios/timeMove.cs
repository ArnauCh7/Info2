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
    public partial class timeMove : Form
    {
        int tiempo;
        public timeMove()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tiempo = Convert.ToInt32(timeInterval.Text);
                Close();
            }
            catch (FormatException)
            {
                ErrorFormato error = new ErrorFormato();
                error.ShowDialog();
            }
        }
        public int GetTime()
        {
            return this.tiempo;
        }
    }
}
