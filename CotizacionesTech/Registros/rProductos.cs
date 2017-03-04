using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CotizacionesTech.Registros
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            ProductoIdTextBox.Clear();
            DescripcionTextBox.Clear();
            MedidaTextBox.Clear();
            PrecioTextBox.Clear();
            CostoTextBox.Clear();
           
            checkBoxesITBS.Checked = false;

        }

        public bool ValidarTextBox()
        {
            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                errorProvider1.SetError(DescripcionTextBox, "Por favor completar campos....");

                return false;
            }
            if (string.IsNullOrWhiteSpace(MedidaTextBox.Text))
            {
                errorProvider1.SetError(MedidaTextBox, "Por favor completar campos....");
                return false;
            }

          

            if (string.IsNullOrWhiteSpace(CostoTextBox.Text))
            {
                errorProvider1.SetError(CostoTextBox, "Por favor completar campos....");
                return false;
            }

            if (string.IsNullOrWhiteSpace(PrecioTextBox.Text))
            {
                errorProvider1.SetError(PrecioTextBox, "Por favor completar campos....");
                return false;
            }
            return true;


        }


        private void SaveButton_Click(object sender, EventArgs e)
        {

            var Guardar = new Entidades.Productos();
            using (var Context = new DAL.Repositorio<Entidades.Productos>())

            {
                int id = 0;
                if (!ValidarTextBox())
                {
                    MessageBox.Show("Favor llenar los campos....");
                }
                else
                {
                   // guardar.TipoId = (Utilidades.TOINT(IDTipoTextBox.Text));
                    Guardar.ProductoId = Utilidades.TOINT(ProductoIdTextBox.Text);
                    Guardar.Descripcion = DescripcionTextBox.Text;
                    Guardar.Medida = MedidaTextBox.Text;

                 

                    Guardar.Precio = Convert.ToDecimal(PrecioTextBox.Text);
                    Guardar.Costo = Convert.ToDecimal(CostoTextBox.Text);



                    //Asigna true o false al checkBox segun selecione el usuario
                    if (checkBoxesITBS.Checked == false)
                    {

                        Guardar.Itbis = false;
                    }
                    else
                    {
                        Guardar.Itbis = true;
                    }
                    ////////////////////////////////////////////


                    if (id != Guardar.ProductoId)

                    {
                        Context.Modificar(Guardar);
                        MessageBox.Show("Se A Modificado correctamente !!!");
                    }
                    else
                    {
                        BLL.Productos.Guardar(Guardar);
                        MessageBox.Show("Se A Guardado correctamente !!!");
                    }


                }

            }

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            int UsuarioId = Convert.ToInt32(ProductoIdTextBox.Text);

            using (var eliminar = new DAL.Repositorio<Entidades.Productos>())
            {
                if (eliminar.Eliminar(eliminar.Buscar(p => p.ProductoId == UsuarioId)))
                {
                    MessageBox.Show("El Producto Fue eliminado...");

                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto...");
                }
            }

        }

        private void rProductos_Load(object sender, EventArgs e)
        {

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int UsuarioId = int.Parse(ProductoIdTextBox.Text);
            Entidades.Productos producto;
 
           using (var buscar = new DAL.Repositorio<Entidades.Productos>())
            {



                producto = buscar.Buscar(p => p.ProductoId == UsuarioId);
                if (producto != null)
                {
                    ProductoIdTextBox.Text = Convert.ToString(producto.ProductoId);
                    DescripcionTextBox.Text = producto.Descripcion;
                    MedidaTextBox.Text = producto.Medida;
                    checkBoxesITBS.Checked = producto.Itbis;
                    PrecioTextBox.Text = Convert.ToString(producto.Precio);
                    CostoTextBox.Text = Convert.ToString(producto.Costo);
                    MessageBox.Show("Busqueda correcta !!!");
                }
                else
                {
                    MessageBox.Show("No existe Este producto....");
                }
            }
        }
    }
}
