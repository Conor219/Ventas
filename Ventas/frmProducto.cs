using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.Entidades;

namespace Ventas
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto();
                producto.CodigoBarras = txtCodigoBarras.Text;
                producto.Codigo = txtCodigo.Text;
                producto.Descripcion = txtDescripcion.Text;
                producto.CategoriaId = int.Parse(txtCategoriaId.Text);
                producto.Agregar(producto);

                MessageBox.Show("Producto agregado correctamente.");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex.Message}");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Producto producto = new Producto();
                    producto.Id = int.Parse(txtId.Text);
                    producto.CodigoBarras = txtCodigoBarras.Text;
                    producto.Codigo = txtCodigo.Text;
                    producto.Descripcion = txtDescripcion.Text;
                    producto.CategoriaId = int.Parse(txtCategoriaId.Text);
                    producto.Actualizar(producto);

                    MessageBox.Show("Producto actualizado correctamente.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error {ex.Message}");
                }

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Producto producto = new Producto();
                    producto.Id = int.Parse(txtId.Text);
                    producto.Eliminar(int.Parse(txtId.Text));

                    MessageBox.Show("Producto eliminado correctamente.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error {ex.Message}");
                }

            }
        }
    }
}
