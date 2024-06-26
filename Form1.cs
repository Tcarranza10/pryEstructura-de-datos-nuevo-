﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructura_de_datos__nuevo_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola cola = new frmCola();
            cola.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila2 pila = new frmPila2();
            pila.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmListaSimple simple = new frmListaSimple();
            simple.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble Doble = new frmListaDoble();
            Doble.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario Arbol = new frmArbolBinario();
            Arbol.ShowDialog();
        }

        private void datosDelDesarroladorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void operacionConTablasDeBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDeDatosOperaciones Operaciones = new frmBaseDeDatosOperaciones();
            Operaciones.ShowDialog();
        }

        private void consultasEnLaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosConsulta consulta = new frmBaseDatosConsulta();
            consulta.ShowDialog();
        }

        private void repasoDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatosRepaso Repaso = new frmBaseDatosRepaso();
            Repaso.ShowDialog();
        }
    }
}
