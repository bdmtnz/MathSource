﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class OpcionDos : Form
    {
        public OpcionDos()
        {
            InitializeComponent();
        }

        public OpcionDos(Form Padre, Panel Contenedor)
        {
            InitializeComponent();
            this.BackColor = Contenedor.BackColor;
            this.Size = Contenedor.Size;
        }
    }
}
