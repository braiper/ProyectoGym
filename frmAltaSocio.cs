﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGym
{
    public partial class frmAltaSocio : Form
    {
        public frmAltaSocio()
        {
            InitializeComponent();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese un carácter no numérico
            }
        }

        private void txtTlf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese un carácter no numérico
            }
        }
    }
}
