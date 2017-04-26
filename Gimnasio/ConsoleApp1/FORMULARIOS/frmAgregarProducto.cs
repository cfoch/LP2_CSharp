using ConsoleApp1.CLASES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1.FORMULARIOS
{
    public partial class frmAgregarProducto : Form
    {
        BindingList<Producto> listaProductos;

        public frmAgregarProducto()
        {
            InitializeComponent();
            listaProductos = new BindingList<Producto>();
            txtIdProducto.Enabled = false;
            txtDescProd.Enabled = false;
            txtNombProd.Enabled = false;
            txtPrecioProd.Enabled = false;
            txtStockProd.Enabled = false;

            dgvProductos.DataSource = listaProductos;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAgregarProducto_Load(object sender, EventArgs e)
        {
            StreamReader Lector = new StreamReader("stock.txt");
            
            while (true)
            {
                string linea = Lector.ReadLine();
                if (linea == null) break;
                Producto p = new Producto();

                string[] datos = linea.Split(',');

                p.IdProducto = Int32.Parse(datos[0]);
                p.NombreProducto = datos[1];
                p.Descripcion = datos[2];
                p.Stock = Int32.Parse(datos[3]);
                p.Precio = float.Parse(datos[4]);
                listaProductos.Add(p);
            }
            Lector.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIdProducto.Enabled = true;
            txtDescProd.Enabled = true;
            txtNombProd.Enabled = true;
            txtPrecioProd.Enabled = true;
            txtStockProd.Enabled = true;
        }

        private void txtNombProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int i = dgvProductos.CurrentRow.Index;
            Producto p = new Producto();
            p = listaProductos[i];
            listaProductos.RemoveAt(i);

            txtIdProducto.Text = p.IdProducto.ToString();
            txtDescProd.Text = p.Descripcion;
            txtNombProd.Text = p.NombreProducto;
            txtStockProd.Text = p.Stock.ToString();
            txtPrecioProd.Text = p.Precio.ToString();
            txtIdProducto.Enabled = true;
            txtDescProd.Enabled = true;
            txtNombProd.Enabled = true;
            txtPrecioProd.Enabled = true;
            txtStockProd.Enabled = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.IdProducto = Int32.Parse(txtIdProducto.Text);
            p.NombreProducto = txtNombProd.Text;
            p.Precio = float.Parse(txtPrecioProd.Text);
            p.Stock = Int32.Parse(txtStockProd.Text);
            p.Descripcion = txtDescProd.Text;

            txtIdProducto.Enabled = false;
            txtDescProd.Enabled = false;
            txtNombProd.Enabled = false;
            txtPrecioProd.Enabled = false;
            txtStockProd.Enabled = false;

            listaProductos.Add(p);


            txtIdProducto.Text = "";
            txtDescProd.Text = "";
            txtNombProd.Text = "";
            txtStockProd.Text = "";
            txtPrecioProd.Text = "";


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = dgvProductos.CurrentRow.Index;
            listaProductos.RemoveAt(i);
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void frmAgregarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            //string path = "C:\\Users\alulab14.INF.000\\Source\\Repos\\LP2_CSharp\\Gimnasio\\stock.txt";
            StreamWriter Escritor = new StreamWriter("stock.txt",false);

            foreach(Producto p in listaProductos)
            {
                Escritor.WriteLine(p.IdProducto + "," + p.NombreProducto + "," +p.Descripcion + "," + p.Stock.ToString() + "," + p.Precio.ToString());
            }

            Escritor.Close();

        }
    }
}
