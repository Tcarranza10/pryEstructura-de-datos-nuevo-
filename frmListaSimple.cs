using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEstructura_de_datos__nuevo_
{
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple Lista = new clsListaSimple();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {

                Int32 x = Convert.ToInt32(cmbLista.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvLista);
                Lista.Recorrer(lstLista);
                Lista.Recorrer(cmbLista);
                Lista.Recorrer();

            }
            else
            {
                MessageBox.Show("la lista esta vacia");
            }
            btnEliminar.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLista.Text == "")
            {
                btnEliminar
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
