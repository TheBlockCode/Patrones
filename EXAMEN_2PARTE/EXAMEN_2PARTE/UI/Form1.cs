using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EXAMEN_2PARTE.DAO;
using EXAMEN_2PARTE.DTO;

namespace EXAMEN_2PARTE
{
    public partial class CRUD : Form
    {
        private Query xd;
        public CRUD()
        {
            InitializeComponent();
            xd = new Query();
            ActualiarDataGrid();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string Fecha = txtFech.Text;
                int Dia = int.Parse(txtDia.Text);
                int Mes = int.Parse(txtMes.Text);
                int Codigo_Ver = int.Parse(txtCodigo_Ver.Text);
                string Vendedor = txtVendedor.Text;
                int Producto = int.Parse(txtId_prod.Text);
                string Nombre_Producto = txtProducto.Text;
                int Linea = int.Parse(txtLinea.Text);
                string Nombre_Linea = txtNombre_Lin.Text;
                string Cliente = txtCliente.Text;
                string Precio = txtPrecio.Text;
                int Cantidad = int.Parse(txtCantidad.Text);


                xd.Insertar(new exa(Fecha,Dia,Mes,Codigo_Ver,Vendedor,Producto,Nombre_Producto,Linea,Nombre_Linea,
                    Cliente,Precio,Cantidad));
                Limpiar();

                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            txtFech.Text = "";
            txtDia.Text = "";
            txtMes.Text = "";
            txtCodigo_Ver.Text = "";
            txtVendedor.Text = "";
            txtId_prod.Text = "";
            txtProducto.Text = "";
            txtLinea.Text = "";
            txtNombre_Lin.Text = "";
            txtCliente.Text = "";
           txtPrecio .Text = "";
           txtCantidad .Text = "";

            ActualiarDataGrid();
        }

        private void ActualiarDataGrid()
        {
            try
            {
                dataGridView1.DataSource = xd.Mostrar().Tables[0];
                dataGridView1.Refresh();
                dataGridView1.Update();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int Codigo_Var = int.Parse(txtDelete.Text);

                xd.Eliminar(Codigo_Var);
                Limpiar();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string Fecha = txtFech.Text;
                int Dia = int.Parse(txtDia.Text);
                int Mes = int.Parse(txtMes.Text);
                int Codigo_Ver = int.Parse(txtUpdate.Text);
                string Vendedor = txtVendedor.Text;
                int Producto = int.Parse(txtId_prod.Text);
                string Nombre_Producto = txtProducto.Text;
                int Linea = int.Parse(txtLinea.Text);
                string Nombre_Linea = txtNombre_Lin.Text;
                string Cliente = txtCliente.Text;
                string Precio = txtPrecio.Text;
                int Cantidad = int.Parse(txtCantidad.Text);


                xd.Actualizar(new exa(Fecha, Dia, Mes, Codigo_Ver, Vendedor, Producto, Nombre_Producto, Linea, Nombre_Linea,
                    Cliente, Precio, Cantidad));
                Limpiar();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            ActualiarDataGrid();
        }
    }
}
