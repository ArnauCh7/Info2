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
    public partial class Principal : Form
    {
        PList milista = new PList();
        PictureBox[] misPics = new PictureBox[100];
        int numPics = 0;
        public Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timeMove t = new timeMove();
            t.ShowDialog();
            reloj.Interval = Convert.ToInt32(t.GetTime());
            reloj.Start();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            positiontracker.BackColor = Color.White;
            positiontracker.Text = "X = " + e.X + "    Y = " + e.Y;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            positiontracker.BackColor = Color.Red;
            positiontracker.Text = "Estas fuera de la zona de reconocimiento";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            milista.MoveAll(2, 1);
            for(int i = 0; i<milista.GetNum(); i++)
            {
                misPics[i].Location = new Point(milista.GetPunto(i).GetX(), milista.GetPunto(i).GetY());
            }

        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            milista.MoveAll(2, 1);
            for (int i = 0; i < milista.GetNum(); i++)
            {
                misPics[i].Location = new Point(milista.GetPunto(i).GetX(), milista.GetPunto(i).GetY());
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            reloj.Stop();
        }

        private void nuevoPuntoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                NewPoint form = new NewPoint();
                form.ShowDialog();
                Punto p = form.GetPoint();
                milista.AddPunto(p);
                PictureBox pic = new PictureBox();
                pic.Size = new Size(5, 5);
                pic.BackColor = Color.Red;
            if (p == null)
            {
                
            }
            else
            {
                pic.Location = new Point(p.GetX(), p.GetY());
                panel.Controls.Add(pic);
                misPics[numPics] = pic;
                numPics++;
            }
        }

        private void listarPuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarPuntos m = new MostrarPuntos();
            Console.WriteLine(milista.GetPunto(0));
            m.GiveList(milista);
            m.ShowDialog();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            milista.RemoveAll();
            for(int i = 0; i<numPics; i++)
            {
                panel.Controls.Remove(misPics[i]);
            }
        }
    }
}
