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
            string sql = "SELECT* " +
                 "FROM(SELECT* " +
                 "FROM Libro as T1 " +
                 "WHERE T1.IdIdioma > 5) as T2 WHERE T2.IdAutor > 10";
            BaseDatos.Listar(dgvOperaciones, sql);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM (\r\n    " +
                "SELECT * FROM Libro WHERE IdAutor = 2\r\n   " +
                " UNION\r\n    " +
                "SELECT * FROM Libro WHERE IdAutor = 5\r\n    " +
                "UNION\r\n   " +
                " SELECT * FROM Libro WHERE IdAutor = 3\r\n)" +
                " AS LibrosFiltrados" +
                "\r\nORDER BY Titulo ASC;";
            BaseDatos.Listar(dgvOperaciones, sql);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * " +
                "FROM Libro " +
                "WHERE IdIdioma" +
                "\r\nIN " +
                "\r\n(SELECT DISTINCT IdIdioma" +
                " FROM Libro" +
                " WHERE IdIdioma < 5)\r\n";
            BaseDatos.Listar(dgvOperaciones, sql);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * " +
                "FROM Libro " +
                "WHERE IdIdioma" +
                "\r\nNOT IN " +
                "\r\n(SELECT DISTINCT IdIdioma " +
                "FROM Libro " +
                "WHERE IdIdioma < 5)\r\n";
            BaseDatos.Listar(dgvOperaciones, sql);
        }
    }
}
