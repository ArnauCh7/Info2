﻿using System;
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
    public partial class time : Form
    {
        int tiempo;
        public time()
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
            return tiempo;
        }
    }
}
