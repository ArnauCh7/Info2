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
    public partial class MostrarPuntos : Form
    {
        PList lista;
        public MostrarPuntos()
        {
            InitializeComponent();
        }

        public void GiveList(PList l)
        {
            this.lista = l; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public PList GetList()
        {
            return this.lista;
        }

        private void MostrarPuntos_Load(object sender, EventArgs e)
        {
            puntosView.RowCount = lista.GetNum();
            puntosView.ColumnCount = 2;
            for (int i = 0; i < lista.GetNum(); i++)
            {
                puntosView.Rows[i].Cells[0].Value = lista.GetPunto(i).GetX();
                puntosView.Rows[i].Cells[1].Value = lista.GetPunto(i).GetY();
            }
        }
    }
}
