using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindFormProductos
{
    public partial class FormularioProductos : Form
    {
        Producto NuevoProd;
        Producto ProdExistente;
        int Fila;
        bool nuevo = true;
        public FormularioProductos()
        {
            InitializeComponent();
            dgv_Crear();
        }
        void dgv_Crear()
        {
            dgv_Productos.Columns.Add("0", "Código");
            dgv_Productos.Columns.Add("1", "Descripción");
            dgv_Productos.Columns.Add("2", "Stock");
            // Tamaño Columnas
            dgv_Productos.Columns[0].Width = 170;
            dgv_Productos.Columns[1].Width = 320;
            dgv_Productos.Columns[2].Width = 120;
        }

        // Instanciamos utilizando constructor con parametros / Mostrar datos ingresados en Mov.Productos
        private void btnCargar_Click(object sender, EventArgs e)
        {
            NuevoProd = new Producto(int.Parse(txtCodigo.Text), txtDescripcion.Text);
            lblCodigoMov.Text = NuevoProd.p_codigo.ToString();
            lblDescripMov.Text = NuevoProd.p_descripcion;
            lblStockmov.Text = "Hay " +  NuevoProd.p_stock.ToString()  + " Unidades";

          tabC_Productos.SelectedTab = tabP_Movimiento;
            txb_Movim.Clear();
            txb_Movim.Focus();
            MessageBox.Show("Producto Instanciado");

            // Agregar al DGV
            dgv_Productos.Rows.Add(NuevoProd.p_codigo.ToString(), NuevoProd.p_descripcion.ToString(), NuevoProd.p_stock.ToString());
            Fila = (dgv_Productos.Rows.Count - 1);
            nuevo = true;
        }

      
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (nuevo == true)
            {
                if (rb_Ingreso.Checked == true)
                {
                    NuevoProd.Ingreso(int.Parse(txb_Movim.Text));
                }
                if (rb_Egreso.Checked == true)
                {
                    NuevoProd.Salida(int.Parse(txb_Movim.Text));
                }
                LlevarProductoDgv(NuevoProd, Fila);
            }
            else
            {
                if (rb_Ingreso.Checked == true)
                {
                    ProdExistente.Ingreso(int.Parse(txb_Movim.Text));
                }
                if (rb_Egreso.Checked == true)
                {
                    ProdExistente.Salida(int.Parse(txb_Movim.Text));
                }
                LlevarProductoDgv(ProdExistente, Fila);
            }
            void LlevarProductoDgv(Producto Prod, int lugar)
            {
                dgv_Productos[0, lugar].Value = Prod.p_codigo.ToString();
                dgv_Productos[1, lugar].Value = Prod.p_descripcion;
                dgv_Productos[2, lugar].Value = Prod.p_stock.ToString();
            }

        }

        private void dgv_Productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdExistente = new  Producto(Convert.ToInt32(dgv_Productos.CurrentRow.Cells[0].Value),
                          dgv_Productos.CurrentRow.Cells[1].Value.ToString(),
                          Convert.ToInt32(dgv_Productos.CurrentRow.Cells[2].Value));

            lblCodigoMov.Text = ProdExistente.p_codigo.ToString();
            lblDescripMov.Text = ProdExistente.p_descripcion;
            lblStockmov.Text = "Hay " + ProdExistente.p_stock.ToString() + " Unidades";
            txb_Movim.Clear();
            Fila = e.RowIndex;
            nuevo = false;
        }

        private void tabC_Productos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

