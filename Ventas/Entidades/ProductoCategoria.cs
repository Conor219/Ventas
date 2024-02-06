using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Entidades
{
    internal class ProductoCategoria
    {
        private string _connectionString;
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public ProductoCategoria()
        {
            _connectionString = "Server=localhost;Database=VentasDB;Trusted_Connection=True;TrustServerCertificate=True";
        }

        public void Agregar(ProductoCategoria productocategoria)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "insert into ProductosCategorias" +
                        "(Descripcion) " +
                        "values" +
                        "(@Descripcion) ";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Descripcion", productocategoria.Descripcion);

                        con.Open();
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Actualizar(ProductoCategoria productocategoria)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "UPDATE ProductosCategorias" +
                        " SET " +
                        " Descripcion = @Descripcion";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Descripcion", productocategoria.Descripcion);

                        con.Open();
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Eliminar(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    string query = "DELETE FROM ProductosCategorias" +
                        " WHERE " +
                        " Id = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", id);

                        con.Open();
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
