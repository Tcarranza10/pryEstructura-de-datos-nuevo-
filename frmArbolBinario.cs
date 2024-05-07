using System;
using System.Collections;
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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }
        clsArbol Arbol = new clsArbol();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo obj = new clsNodo();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);
            obj.Nombre = txtNombre.Text;
            obj.Tramite = txtTramite.Text;
            Arbol.Agregar(obj);
            Arbol.RecorrerAsGrilla(dgvArbol);
            Arbol.RecorrerTree(treeView1);
            Arbol.RecorrerAsCombo(cmbArbol);
            txtTramite.Text = "";
            txtNombre.Text = "";
            txtCodigo.Text = "";
        }
       
       
        private void rbtInOrden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerAsGrilla(dgvArbol);
            Arbol.RecorrerAsCombo(cmbArbol);
            Arbol.RecorrerInOrdenAscAD();
        }

        private void rbtPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerPreOrdenGrilla(dgvArbol);
            Arbol.RecorrerTree(treeView1);
            Arbol.RecorrerPreOrdenAD();
        }

        private void rbtPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerPostOrdenGrilla(dgvArbol);
            Arbol.RecorrerPostOrdenAD();

        }

        private void rbtInOrdenDes_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerDesGrilla(dgvArbol);
            Arbol.RecorrerComboDesc(cmbArbol);
            Arbol.RecorrerInOrdenDescAD();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbArbol.SelectedIndex != -1)
            {
                Int32 x = Convert.ToInt32(cmbArbol.Text);
                Arbol.Eliminar(x);
                Arbol.RecorrerAsGrilla(dgvArbol);
                Arbol.RecorrerTree(treeView1);
                Arbol.RecorrerAsCombo(cmbArbol);
                Arbol.RecorrerInOrdenAscAD();
            }
            else
            {
                MessageBox.Show("Seleccione un dato");
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.RecorrerAsGrilla(dgvArbol);
            Arbol.RecorrerTree(treeView1);
            Arbol.RecorrerAsCombo(cmbArbol);
            Arbol.RecorrerInOrdenAscAD();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cmbArbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArbol.SelectedIndex == cmbArbol.Items.Count - 1)
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }
    }
}
