﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_goncalves_gines
{
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void btnCancelarListar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
     
    }
}