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
    public partial class Form1 : Form
    {
        private DataTable tablaProductos;
        public Form1()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos()
        {
            tablaProductos = neg_Producto.MostrarTodosProductos();
            dataGWProductos.DataSource = null;
            if (tablaProductos.Rows.Count > 0)
                dataGWProductos.DataSource = tablaProductos;
            else
                dataGWProductos.DataSource = CreaTabla();

            FormatoTabla();
        }

        private DataTable CreaTabla()
        {
            return null;
        }

        private void FormatoTabla()
        {
            dataGWProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGWProductos.ColumnHeadersHeight = 33;
            dataGWProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Titulos de las columnas
            dataGWProductos.Columns[0].HeaderText = "Nombre";
            dataGWProductos.Columns[1].HeaderText = "Precio";
            dataGWProductos.Columns[2].HeaderText = "Categoria";
            dataGWProductos.Columns[3].HeaderText = "Stock";
            dataGWProductos.Columns[4].HeaderText = "Unidad";

            //Quitar columna antes de las filas
            dataGWProductos.RowHeadersVisible = false;

            //Desactivar scrolls bars
            dataGWProductos.ScrollBars = ScrollBars.None;

            //Reasignar ancho
            for (int i=0;i<5;i++)
            {
                dataGWProductos.Columns[i].Width=dataGWProductos.Width/5;
            }
            //Ocultar meta datos
            dataGWProductos.Columns[5].Visible = false;
            dataGWProductos.Columns[6].Visible = false;
            dataGWProductos.Columns[7].Visible = false;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            ProductoNuevo frm_Producto = new ProductoNuevo();
            frm_Producto.actualizado += Frm_Producto_actualizado;
            this.Enabled = false;
            frm_Producto.Show();
            
        }

        private void Frm_Producto_actualizado()
        {
            CargarProductos();
            this.Enabled = true;
        }

        private void dataGWProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGWProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGWProductos_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void dataGWProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            int columna = e.ColumnIndex;
            if (columna == 3)
            {
                int idProducto = Convert.ToInt32(""+ tablaProductos.Rows[fila].ItemArray[5]);
                int nuevoStock = Convert.ToInt32(""+ tablaProductos.Rows[fila].ItemArray[columna]);
                neg_Producto.ActualizarStock(new Producto() { 
                nombre = null,
                categoria = 0,
                precio = 0,
                unidad = 0,
                id = idProducto,
                stock = nuevoStock
                });
            }
            

        }
    }
}
