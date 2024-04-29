using System;
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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble lstDoble = new clsListaDoble();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (rbtAscendente.Checked)
            { 
                clsNodo obj = new clsNodo();
                obj.Codigo = Convert.ToInt32(txtCodigo.Text);
                obj.Nombre = txtNombre.Text;
                obj.Tramite = txtTramite.Text;
                lstDoble.Agregar(obj);
                lstDoble.Recorrer(dgvListaDoble);
                lstDoble.Recorrer(lstListaDoble);
                lstDoble.Recorrer(cmbLista);
                lstDoble.Recorrer();
                txtTramite.Text = "";
                txtNombre.Text = "";
                txtCodigo.Text = "";
            }

            if (rbtDescendente.Checked)
            {
                clsNodo obj = new clsNodo();
                obj.Codigo = Convert.ToInt32(txtCodigo.Text);
                obj.Nombre = txtNombre.Text;
                obj.Tramite = txtTramite.Text;
                lstDoble.Agregar(obj);
                lstDoble.RecorrerDes(dgvListaDoble);
                lstDoble.RecorrerDes(lstListaDoble);
                lstDoble.RecorrerDes(cmbLista);
                lstDoble.RecorrerDes();
                txtTramite.Text = "";
                txtNombre.Text = "";
                txtCodigo.Text = "";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(rbtAscendente.Checked)
            {
                if (lstDoble.Primero != null)
                {
                    Int32 x = Convert.ToInt32(cmbLista.Text);
                    lstDoble.Eliminar(x);
                    lstDoble.Recorrer(lstListaDoble);
                    lstDoble.Recorrer(dgvListaDoble);
                    lstDoble.Recorrer(cmbLista);
                    lstDoble.Recorrer();
                }
                else
                {
                    MessageBox.Show("La lista está vacía");
                }
                
            }
           
            if (rbtDescendente.Checked)
            {
                if (lstDoble.Primero != null)
                {
                    Int32 x = Convert.ToInt32(cmbLista.Text);
                    lstDoble.Eliminar(x);
                    lstDoble.RecorrerDes(lstListaDoble);
                    lstDoble.RecorrerDes(dgvListaDoble);
                    lstDoble.RecorrerDes(cmbLista);
                    lstDoble.RecorrerDes();
                }
                else
                {
                    MessageBox.Show("La lista está vacía");
                }
                
            }
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }
    }
}
