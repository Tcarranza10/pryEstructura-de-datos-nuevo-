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
                    sql = "select * fron pais where" +
                        "idpais not in" +
                        "(select idpais from libro";
               break;

            }
        }
    }
}
