using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Formularios
{
    public partial class NewPoint : Form
    {
        Punto p;
        public NewPoint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                p = new Punto(Convert.ToInt32(Xbox.Text), Convert.ToInt32(Ybox.Text));
                Close();
            }
            catch (FormatException)
            {
                ErrorFormato error = new ErrorFormato();
                error.ShowDialog();
            }
        }

        public Punto GetPoint()
        {
            return this.p;
        }
    }
}
