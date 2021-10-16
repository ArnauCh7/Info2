using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class conflictAvoid : Form
    {
        bool avoid = false;
        public conflictAvoid()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            avoid = true;
            Close();
        }

        private void No_Click(object sender, EventArgs e)
        {
            avoid = false;
            Close();
        }

        public bool GetAvoid()
        {
            return this.avoid;
        }
    }
}
