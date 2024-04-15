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
            clsNodo obj = new clsNodo();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);
            obj.Nombre = txtNombre.Text;
            obj.Tramite = txtTramite.Text;
            Lista.Agregar(obj);
            Lista.Recorrer(dgvLista);
            Lista.Recorrer(lstLista);
            Lista.Recorrer(cmbLista);
            Lista.Recorrer();
            txtTramite.Text = "";
            txtNombre.Text = "";
            txtCodigo.Text = "";
        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLista.Text == "")
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
