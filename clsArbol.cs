using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEstructura_de_datos__nuevo_
{
    internal class clsArbol
    {
        private clsNodo PrimerNodo;

        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value;}
        }

        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierda = null;
            Nvo.Derecho = null;
            if(Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while(Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierda;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if(Nvo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierda = Nvo;
                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }
            }
        }

        public void RecorrerAsCombo(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsCombo(Lista, Raiz);
        }

        private void InOrdenAsCombo(ComboBox Lst, clsNodo R)
        {
            if(R.Izquierda != null)
            {
                InOrdenAsCombo(Lst, R.Izquierda);
            }
            Lst.Items.Add(R.Codigo);
            if(R.Derecho != null)
            {
                InOrdenAsCombo(Lst, R.Derecho);
            }
        }

        public void RecorrerAsGrilla(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsGrilla(Grilla, Raiz);
        }

        private void InOrdenAsGrilla(DataGridView Dgv, clsNodo R)
        {
            if(R.Izquierda != null) InOrdenAsGrilla(Dgv, R.Izquierda);
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsGrilla(Dgv, R.Derecho);

        }
        public void RecorrerInOrdenAscAD()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioInOrden.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            RecorrerInOrdenAscAD(Raiz, AD);
            AD.Close();
        }

        private void RecorrerInOrdenAscAD(clsNodo R, StreamWriter writer)
        {
            if (R != null)
            {
                RecorrerInOrdenAscAD(R.Izquierda, writer);
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}\n");
                RecorrerInOrdenAscAD(R.Derecho, writer);
            }
        }



        public void RecorrerDesGrilla(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrderDesGrilla(Grilla, Raiz);
        }
        public void InOrderDesGrilla(DataGridView dgv, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrderDesGrilla(dgv, R.Derecho);
            }

            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierda != null)
            {
                InOrderDesGrilla(dgv, R.Izquierda);
            }
        }
        public void RecorrerComboDesc(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrderDesCombo(Lista, Raiz);
        }
        public void InOrderDesCombo(ComboBox Lst, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrderDesCombo(Lst, R.Derecho);
            }

            Lst.Items.Add(R.Codigo);
            if (R.Izquierda != null)
            {
                InOrderDesCombo(Lst, R.Izquierda);
            }
        }
        public void RecorrerInOrdenDescAD()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioInOrdenDesc.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            InOrdenDescAD(Raiz, AD);
            AD.Close();
        }

        private void InOrdenDescAD(clsNodo R, StreamWriter writer)
        {
            if (R != null)
            {
                InOrdenDescAD(R.Derecho, writer);
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}\n");
                InOrdenDescAD(R.Izquierda, writer);
            }
        }



        public void RecorrerTree(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrdenTree(Raiz, NodoPadre);
            tree.ExpandAll();
        }

        private void PreOrdenTree(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if(R.Izquierda != null)
            {
                PreOrdenTree(R.Izquierda, NodoPadre);
            }
            if(R.Derecho != null)
            {
                PreOrdenTree(R.Derecho, NodoPadre);
            }
        }

        public void RecorrerPreOrdenGrilla(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrdenGrilla(Grilla, Raiz);
        }
        public void PreOrdenGrilla(DataGridView dgv, clsNodo R)
        {
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierda != null)
            {
                PreOrdenGrilla(dgv, R.Izquierda);
            }
            if (R.Derecho != null)
            {
                PreOrdenGrilla(dgv, R.Derecho);
            }
        }
        public void RecorrerPreOrdenAD()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioPreOrden.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            PreOrdenAD(Raiz, AD);
            AD.Close();
        }

        private void PreOrdenAD(clsNodo R, StreamWriter writer)
        {
            if (R != null)
            {
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}\n");
                PreOrdenAD(R.Izquierda, writer);
                PreOrdenAD(R.Derecho, writer);
            }
        }



        public void RecorrerPostOrdenGrilla(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrdenGrilla(Grilla, Raiz);
        }
        public void PostOrdenGrilla(DataGridView dgv, clsNodo R)
        {

            if (R.Izquierda != null)
            {
                PreOrdenGrilla(dgv, R.Izquierda);
            }
            if (R.Derecho != null)
            {
                PreOrdenGrilla(dgv, R.Derecho);
            }
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        public void RecorrerPostOrdenAD()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioPostOrden.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            PostOrdenAD(Raiz, AD);
            AD.Close();
        }

        private void PostOrdenAD(clsNodo R, StreamWriter writer)
        {
            if (R != null)
            {
                PostOrdenAD(R.Izquierda, writer);
                PostOrdenAD(R.Derecho, writer);
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}\n");
            }
        }



        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while (Aux != null)
            {
                if (cod == Aux.Codigo) break;
                if (cod < Aux.Codigo) Aux = Aux.Izquierda;
                else Aux = Aux.Derecho;
            }
            return Aux;
        }

        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;
        
        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if(NodoPadre.Izquierda != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierda);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if(NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }

        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if(ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        private void GrabarVectorInOrden(clsNodo NodoPadre, Int32 codigo)
        {
            if(NodoPadre.Izquierda!= null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierda, codigo);
            }
            if(NodoPadre.Codigo != codigo)
            {
                Vector[i] = NodoPadre;
                i++;
            }
            if(NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, codigo);
            }
        }
    }
}
