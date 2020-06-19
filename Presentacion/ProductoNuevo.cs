using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;

namespace Presentacion
{
    public partial class ProductoNuevo : Form
    {
        public delegate void actualizar();
        public event actualizar actualizado;
        private Producto nuevoProducto;
        private DataTable categorias = neg_Categorias.obtenerTodasCategorias();
        private DataTable unidades = neg_Unidades.obtenerTodasUnidades();
        public ProductoNuevo()
        {
            InitializeComponent();
            CargarCombos();
            nuevoProducto = null;
            categorias = neg_Categorias.obtenerTodasCategorias();
            unidades = neg_Unidades.obtenerTodasUnidades();
        }

        public void CargarCombos()
        {
            for (int i = 0; i < categorias.Rows.Count; i++)
                cBCategoria.Items.Add(categorias.Rows[i].ItemArray[1]);
            for (int i = 0; i < unidades.Rows.Count; i++)
                cBUnidad.Items.Add(unidades.Rows[i].ItemArray[1]);

            cBCategoria.SelectedIndex = 0;
            cBUnidad.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtPrecio.Text != "" && txtStock.Text != "")
            {
                int cat = bucarIndex(cBCategoria.SelectedItem.ToString(),categorias);
                int uni = bucarIndex(cBUnidad.SelectedItem.ToString(), unidades);
                int stock = Convert.ToInt32(txtStock.Text);
                decimal precio = Convert.ToDecimal(txtPrecio.Text);

                neg_Producto.AgregarProducto(new Producto() { 
                    nombre = txtNombre.Text ,
                    precio = precio,
                    stock = stock,
                    categoria = cat,
                    unidad = uni,
                    id = 0
                });
                actualizado();
                this.Close();
            }
            else
                MessageBox.Show("Faltan campos por seleccionar");
        }

        private int bucarIndex(string termino,DataTable tabla)
        {
            int res = 0;
            for(int i = 0; i < tabla.Rows.Count; i++)
                if (termino.Equals(tabla.Rows[i].ItemArray[1]))
                    res = Convert.ToInt32(tabla.Rows[i].ItemArray[0]);
            return res;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            actualizado();
            this.Close();
        }
    }
}
