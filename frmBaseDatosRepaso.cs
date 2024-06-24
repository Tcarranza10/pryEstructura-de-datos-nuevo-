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
    public partial class frmBaseDatosRepaso : Form
    {
        public frmBaseDatosRepaso()
        {
            InitializeComponent();
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDeDatos objBD = new clsBaseDeDatos();
            string sql = "SELECT * FROM LIBRO";
            switch (cmbConsulta.SelectedIndex)
            {
                case 0:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                        "Paises que no tienen libros";
                    sql = " SELECT * FROM pais WHERE " +
                        "idpais not in" +
                        "(SELECT idpais FROM libro)";
                    break;

                case 1:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                        "Idiomas que si tienen libros";
                    sql = "SELECT * FROM Idioma " +
                        "WHERE IdIdioma IN " +
                        "(SELECT IdIdioma FROM Libro)";
                    break;

                case 2:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                        "Autores que tienen más de un libro";
                    sql = "SELECT autor.nombre, COUNT(*) AS cantidadlibros " +
                        "FROM libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor " +
                        "GROUP BY Autor.Nombre HAVING COUNT(*) > 1";
                    break;

                case 3:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                        "Libros que no han sido prestados";
                    sql = "SELECT * FROM Libro WHERE Cantidad > 0";
                    break;

                case 4:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                        "Listar todos los libros";
                    sql = "SELECT * FROM Libro ORDER BY Año DESC";
                    break;

                case 5:
                    string nombreAutor = "carlos";
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                        "Libros de un autor específico";
                    sql = $"SELECT Libro.IdLibro, Libro.Titulo, Libro.Año, Libro.IdPais, Libro.IdIdioma, Libro.Cantidad, Libro.Precio, Autor.Nombre AS Autor " +
                          $"FROM Libro " +
                         $"INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor " +
                         $"WHERE Autor.Nombre = '{nombreAutor}'";
                    break;

                case 6:
                    int idIdioma = 1;
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                        "Libros en un idioma específico";
                    sql = $"SELECT Libro.IdLibro, Libro.Titulo, Libro.Año, Libro.IdPais, Libro.IdIdioma, Libro.Cantidad, Libro.Precio, Idioma.Nombre AS Idioma " +
                         $"FROM Libro " +
                         $"INNER JOIN Idioma ON Libro.IdIdioma = Idioma.IdIdioma " +
                         $"WHERE Libro.IdIdioma = {idIdioma}";

                    break;

                case 7:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                        "Libros disponibles en la biblioteca";
                    sql = "SELECT * FROM Libro WHERE Cantidad > 0";
                    break;

                case 8:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                        "Libros prestados actualmente";
                    sql = "SELECT * FROM Libro WHERE Cantidad = 0";
                    break;

                case 9:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                       "Autores y sus libros ordenados por nombre de autor";
                    sql = "SELECT Autor.Nombre AS Autor, Libro.Titulo AS TituloLibro " +
                        "FROM Autor INNER JOIN Libro ON Autor.IdAutor = " +
                        "Libro.IdAutor ORDER BY Autor.Nombre";
                    break;

                case 10:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                       "Libros agrupados por idioma";
                    sql = "SELECT Idioma.Nombre AS Idioma, COUNT(*) AS CantidadLibros " +
                        "FROM Libro INNER JOIN Idioma ON " +
                        "Libro.IdIdioma = Idioma.IdIdioma " +
                        "GROUP BY Idioma.Nombre";
                    break;

                case 11:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                       "Libros prestados y disponibles en la biblioteca";
                    sql = "SELECT Libro.Titulo, Libro.Cantidad, " +
                          "IIf(Libro.Cantidad > 0, 'Disponible', 'Prestado') AS Estado " +
                          "FROM Libro";
                    break;

                case 12:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                       "Libros con título y año de publicación";
                    sql = "SELECT Libro.Titulo, Libro.Año FROM Libro";
                    break;

                case 13:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                       "Libros de autores vivos";
                    sql = "SELECT Libro.Titulo FROM Libro INNER " +
                        "JOIN Autor ON Libro.IdAutor = Autor.IdAutor " +
                        "WHERE Autor.EstadoVital = 'Vivo'";
                    break;

                case 14:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                       "Libros escritos por autor femenino";
                    sql = "SELECT Libro.Titulo FROM Libro INNER " +
                        "JOIN Autor ON Libro.IdAutor = Autor.IdAutor " +
                        "WHERE Autor.Genero = 'Femenino'";
                    break;

                case 15:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                       "Libros ordenados por título ascendente";
                    sql = "SELECT * FROM Libro ORDER BY Titulo ASC";
                    break;

                case 16:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                       "Libros en español";
                    sql = "SELECT Libro.Titulo FROM Libro " +
                        "INNER JOIN Idioma ON Libro.IdIdioma = Idioma.IdIdioma " +
                        "WHERE Idioma.Nombre = 'Español'";
                    break;

                case 17:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                       "Libros publicados por primera vez este año";
                    sql = "SELECT * FROM Libro WHERE Año = YEAR(GETDATE())";
                    break;

                case 18:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                       "Libros con más de 5 copias disponibles";
                    sql = "SELECT * FROM Libro WHERE Cantidad > 5";
                    break;

                case 19:
                    lblRepaso.Text = cmbConsulta.Text + ":" +
                       "Autores con más de 3 libros publicados";
                    sql = "SELECT Autor.Nombre, COUNT(*) AS CantidadLibros " +
                        "FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor " +
                        "GROUP BY Autor.Nombre HAVING COUNT(*) > 3";
                    break;

                default:
                    lblRepaso.Text = "Selecciona una consulta válida";
                    return;
            }
            objBD.Listar(dgvRepaso,sql);
        }

        private void frmBaseDatosRepaso_Load(object sender, EventArgs e)
        {

        }
    }
}
