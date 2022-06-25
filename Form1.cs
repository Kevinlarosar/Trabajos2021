using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Producto> lista = new List<Producto>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lista.Add(LeerProducto());
            ActualizarLista();
        }
        private Producto LeerProducto()
        {
            Producto producto = new Producto();
            producto.Articulo = txtArticulo.Text;
            producto.Precio = txtPrecio.Text;
            producto.Stock = txtStock.Text;
            return producto;
        }

        private void ActualizarLista()
        {
            lstLista.Items.Clear();
            int i;
            for (i = 0; i <= lista.Count - 1; i++)
            {
                lstLista.Items.Add(lista[i].Articulo + "  " + lista[i].Precio + "   " + lista[i].Stock);
            }
            txtArticulo.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtArticulo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lista.RemoveAt(lista.Count - 1);
            ActualizarLista();

            MessageBox.Show("La lista esta vacia");
        }
    }
}
