﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace WindowsLab
{
    public partial class Vectores2 : Form
    {
        double[] precios= new double[3];
        public Vectores2()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            GetNumeros();
        }

        private  void GetNumeros()
        {
            double suma = 0; 

            for (int i = 0; i < precios.Length; i++)
            {
                double precio = Convert.ToDouble(Interaction.InputBox("Ingrese el precio"));
                suma += precio;
            }
            MessageBox.Show("La suma de los precios es: " + Convert.ToDouble(suma));

            
    }
}
}

