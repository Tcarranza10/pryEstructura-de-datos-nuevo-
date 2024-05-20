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
    public partial class frmBaseDeDatosOperaciones : Form
    {
        public frmBaseDeDatosOperaciones()
        {
            InitializeComponent();
        }

        clsBaseDeDatos BaseDatos = new clsBaseDeDatos();

        private void btnProyeccionSimple_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT Titulo FROM Libro";
            BaseDatos.Listar(dgvOperaciones, Sql);
        }

        private void btnProyeccionMultiatributo_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT IdLibro, Titulo FROM Libro";
            BaseDatos.Listar(dgvOperaciones,Sql); 
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * " +
                "FROM Libro, Idioma " +
                "WHERE Libro.IdIdioma = Idioma.IdIdioma";
            BaseDatos.Listar(dgvOperaciones, Sql );
        }

        private void btnSeleccionSimple_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM Libro WHERE IdAutor = 2";
            BaseDatos.Listar(dgvOperaciones, Sql);
        }

        private void btnSeleccionMultiatributo_Click(object sender, EventArgs e)
        {
            string Sql = "SELECT * FROM Libro WHERE IdAutor = 2 AND IdLibro = 2";
            BaseDatos.Listar(dgvOperaciones, Sql);
        }
        private void btnSeleccionConvolucion_Click(object sender, EventArgs e)
        {

        }

        private void btnUnion_Click(object sender, EventArgs e)
        {

        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {

        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {

        }
    }
}
