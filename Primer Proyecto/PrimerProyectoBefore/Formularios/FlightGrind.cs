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
    public partial class FlightGrind : Form
    {
        FlightPlanList lista = new FlightPlanList();
        public FlightGrind()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void GiveList(FlightPlanList fl)
        {
            this.lista = fl; 
        }

        private void FlightGrind_Load(object sender, EventArgs e)
        {
            viewFlights.RowCount = lista.GetLength();
            viewFlights.ColumnCount = 4;
            for (int i = 0; i < lista.GetLength(); i++)
            {
                viewFlights.Rows[i].Cells[0].Value = lista.GetFlightPlan(i).GetID();
                viewFlights.Rows[i].Cells[1].Value = lista.GetFlightPlan(i).GetCurrentPosition().GetX();
                viewFlights.Rows[i].Cells[2].Value = lista.GetFlightPlan(i).GetCurrentPosition().GetY();
                viewFlights.Rows[i].Cells[3].Value = lista.GetFlightPlan(i).GetVelocity();
            }
        }
    }
}
