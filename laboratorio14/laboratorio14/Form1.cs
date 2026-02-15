using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace laboratorio14
{
    public partial class FrmProductos : Form
    {
        string connectionString = @"Server=localhost;Database=productos;Trusted_Connection=True;";
        bool nuevo;
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarListaProductos();
            LimpiarCampos();
            nuevo = false;
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            LimpiarCampos();
            txtNombre.Focus();
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto.");
                txtNombre.Focus();
                return;
            }

            decimal precio;
            int stock;

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio inválido.");
                txtPrecio.Focus();
                return;
            }

            if (!int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Stock inválido.");
                txtStock.Focus();
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();

                    if (nuevo)
                    {
                        using (SqlCommand cmd = new SqlCommand(
                            "INSERT INTO productos (Nombre, Precio, Stock) VALUES (@Nombre, @Precio, @Stock); SELECT SCOPE_IDENTITY();", cn))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                            cmd.Parameters.AddWithValue("@Precio", precio);
                            cmd.Parameters.AddWithValue("@Stock", stock);

                            object id = cmd.ExecuteScalar();
                            txtId.Text = Convert.ToInt32(id).ToString();
                        }
                        MessageBox.Show("Producto guardado correctamente.");
                    }
                    else
                    {
                        int id;
                        if (!int.TryParse(txtId.Text, out id))
                        {
                            MessageBox.Show("Id inválido para actualizar.");
                            return;
                        }

                        using (SqlCommand cmd = new SqlCommand(
                            "UPDATE Productos SET Nombre=@Nombre, Precio=@Precio, Stock=@Stock WHERE Id=@Id", cn))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                            cmd.Parameters.AddWithValue("@Precio", precio);
                            cmd.Parameters.AddWithValue("@Stock", stock);
                            cmd.Parameters.AddWithValue("@Id", id);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Producto actualizado correctamente.");
                        }
                    }

                    cn.Close();
                }

                nuevo = false;
                CargarListaProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("Ingrese un Id válido para eliminar.");
                return;
            }

            var resp = MessageBox.Show("¿Desea eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp != DialogResult.Yes) return;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Productos WHERE Id=@Id", cn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    cn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("Producto eliminado.");
                        LimpiarCampos();
                        CargarListaProductos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto a eliminar.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }

        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            nuevo = false;
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(tstId.Text, out id))
            {
                MessageBox.Show("Ingrese un Id válido para buscar.");
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Productos WHERE Id=@Id", cn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtId.Text = dr["Id"].ToString();
                            txtNombre.Text = dr["Nombre"].ToString();
                            txtPrecio.Text = dr["Precio"].ToString();
                            txtStock.Text = dr["Stock"].ToString();
                            nuevo = false;
                        }
                        else
                        {
                            MessageBox.Show("Producto no encontrado.");
                        }
                    }
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            tstId.Text = "";
        }

        private void CargarListaProductos()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Productos", cn))
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    // dgvProductos.DataSource = dt; // Si tienes un DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }
    }
}

