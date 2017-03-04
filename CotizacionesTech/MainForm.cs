using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CotizacionesTech
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entidades.Productos producto;
            Entidades.Clientes cliente;
            Entidades.Cotizaciones cotizacion;

            producto = new Entidades.Productos
            {
                ProductoId = 0,
                Descripcion = "Cebolla",
                Precio = 100

            };

            cliente = new Entidades.Clientes
            {
                ClienteId = 0,
                Nombres = "Enel"

            };

            


            producto = BLL.Productos.Guardar(producto);
            cliente = BLL.Clientes.Guardar(cliente);

            cotizacion = new Entidades.Cotizaciones();

            cotizacion.ClienteId = cliente.ClienteId;
            cotizacion.Fecha = DateTime.Now;
            cotizacion.Monto = 100;
            cotizacion.AgregarDetalle(producto.ProductoId, 1, producto.Precio);

            cotizacion = BLL.Cotizaciones.Guardar(cotizacion);

            MessageBox.Show("Cotizaciones creada" + cotizacion.ClienteId.ToString());
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
           
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
           

        }

        private void tiposDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CotizacionesTech.Registros.rTiposProductos db = new Registros.rTiposProductos();
            db.Show();
        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CotizacionesTech.Registros.rTiposProductos db = new Registros.rTiposProductos();
            db.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Consultas.cProductos().Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CotizacionesTech.Registros.rProductos db = new Registros.rProductos();
            db.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CotizacionesTech.Registros.rUsuarios db = new Registros.rUsuarios();
            db.Show();
        }
    }
}
