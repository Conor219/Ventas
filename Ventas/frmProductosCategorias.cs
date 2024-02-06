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
    public partial class frmProductosCategorias : Form
    {
        public frmProductosCategorias()
        {
            InitializeComponent();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductosCategorias productoscategorias = new ProductosCategorias();
                productoscategorias.Descripcion = txtDescripcion.Text;
                productoscategorias.Agregar(productoscategorias);

                MessageBox.Show("Categoría del producto agregada correctamente.");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductosCategorias productoscategorias = new ProductosCategorias();
                productoscategorias.Id = int.Parse(txtId.Text);
                productoscategorias.Descripcion = txtDescripcion.Text;
                productoscategorias.Actualizar(productoscategorias);

                MessageBox.Show("Categoría del producto actualizada correctamente.");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductosCategorias productoscategorias = new ProductosCategorias();
                productoscategorias.Eliminar(int.Parse(txtId.Text));

                MessageBox.Show("Cliente eliminado correctamente.");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error {ex.Message}");
            }
        }
    }
}
