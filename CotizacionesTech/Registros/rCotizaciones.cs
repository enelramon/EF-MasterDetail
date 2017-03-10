using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace CotizacionesTech.Registros
{
    public partial class rCotizaciones : Form
    {
        Entidades.CotizacionesDetalle detalle /*= new Entidades.CotizacionesDetalle()*/;
        

        public rCotizaciones()
        {
            InitializeComponent();
            Limpiar();
        }

        private void Limpiar()
        {
            detalle = new Entidades.CotizacionesDetalle();
            //Producto = new Entidades.Cotizaciones();

            CotizacionIdtextBox.Clear();
            FechadateTimePicker.Value = DateTime.Today;
            ClienteIdcomboBox.Text = " ";
            MontomaskedTextBox.Clear();
            ValidarerrorProvider.Clear();
            DetalledataGridView.DataSource = null;
            ProductoIdtextBox.Clear();
            PrecioProductotextBox.Clear();
            NombreProductotextBox.Clear();
            ImportetextBox.Clear();
            CantidadnumericUpDown.Value = 0;
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(MontomaskedTextBox.Text))
            {
                ValidarerrorProvider.SetError(MontomaskedTextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(ClienteIdcomboBox.Text))
            {
                ValidarerrorProvider.SetError(ClienteIdcomboBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }

            return interruptor;
        }

        private void LlenarCombo()
        {
            List<Entidades.Clientes> lista = BLL.Clientes.ListaTodo();

            ClienteIdcomboBox.DataSource = lista;
            ClienteIdcomboBox.DisplayMember = "Nombres";
            ClienteIdcomboBox.ValueMember = "ClienteId";
        }

        private void LlenarGrid(Entidades.Cotizaciones producto)
        {
            //DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = producto.Detalle.ToList();

            this.DetalledataGridView.Columns["Id"].Visible = false;
            this.DetalledataGridView.Columns["CotizacionId"].Visible = false;
            this.DetalledataGridView.Columns["Producto"].Visible = false;
            this.DetalledataGridView.Columns["Cotizaciones"].Visible = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var cotizacion = new Entidades.Cotizaciones();
            int id = Utilidades.TOINT(CotizacionIdtextBox.Text);

            cotizacion = BLL.Cotizaciones.Buscar(p => p.CotizacionId == id);

            if (cotizacion != null)
            {
                FechadateTimePicker.Value = cotizacion.Fecha;
                MontomaskedTextBox.Text = cotizacion.Monto.ToString();
                ClienteIdcomboBox.Text = cotizacion.ClienteId.ToString();

                LlenarGrid(cotizacion);
            }
            else
            {
                MessageBox.Show("No existe cliente con ese Id.");
                Limpiar();
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var cotizacion = new Entidades.Cotizaciones();
            int id = 0;
            string cliente = ProductoIdtextBox.Text;

            if (!Validar())
            {
                MessageBox.Show("Por favor llenar los campos vacios.");
            }
            else
            {
                //cotizacion.CotizacionId = Utilidades.TOINT(CotizacionIdtextBox.Text);
                cotizacion.Fecha = FechadateTimePicker.Value;
                cotizacion.ClienteId = Utilidades.TOINT(ClienteIdcomboBox.Text);
                cotizacion.Monto = Convert.ToDecimal(MontomaskedTextBox.Text);
                detalle.Producto.ProductoId = Utilidades.TOINT(cliente);

                if (id != cotizacion.CotizacionId)
                {
                    BLL.Cotizaciones.Mofidicar(cotizacion);
                    MessageBox.Show("La cotizacion de modifico con exito.");
                }
                else
                {
                    BLL.Cotizaciones.Guardar(cotizacion);
                    MessageBox.Show("La cotizacion se guardo con exito.");
                }

                Limpiar();
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("Los campos estan vacios.");
            }
            else
            {
                int id = Utilidades.TOINT(CotizacionIdtextBox.Text);

                if (BLL.Cotizaciones.Eliminar(BLL.Cotizaciones.Buscar(p => p.CotizacionId == id)))
                {
                    Limpiar();
                    MessageBox.Show("La cotizacion se elimino con exito.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la cotizacion.");
                }
            }
        }

        private void rCotizaciones_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {

            int id = Utilidades.TOINT(ProductoIdtextBox.Text);

            if (e.KeyChar == (char)Keys.Enter)
            {
                detalle.Producto = BLL.Productos.Buscar(p => p.ProductoId == id);

                if (detalle.Producto != null)
                {
                    NombreProductotextBox.Text = detalle.Producto.Descripcion;
                    PrecioProductotextBox.Text = detalle.Producto.Precio.ToString();
                    CantidadnumericUpDown.Focus();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (CantidadnumericUpDown.Value > 0)
            {
                decimal importe = detalle.Producto.Precio * CantidadnumericUpDown.Value;
                ImportetextBox.Text = importe.ToString();
            }
            else
            {
                ImportetextBox.Text = "0";
            }

            Agregarbutton.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entidades.Cotizaciones Producto = new Entidades.Cotizaciones();
            Producto.AgregarDetalle(detalle.Producto, CantidadnumericUpDown.Value);

            LlenarGrid(Producto);
        }
    }
}
