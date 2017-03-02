using DAL;
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
    public partial class rTiposProductos : Form
    {
        public rTiposProductos()
        {
            InitializeComponent();
        }

        bool estado=false;
        private void Limpiar()
        {
            IDTipoTextBox.Clear();
            nombreTipoTextBox.Clear();
            nombreTipoTextBox.Focus();
            radioButtonActivo.Checked = true;
            radioButtonNoactivo.Checked = false;

        }

        private bool Validar()
        {
            bool retorno = true;
                if(string.IsNullOrWhiteSpace(nombreTipoTextBox.Text))
            {
                errorProviderNombre.SetError(nombreTipoTextBox, "CAMPO VACIO");
                retorno = false;
            }
          

            return retorno;

        }

        private void rTiposProductos_Load(object sender, EventArgs e)
        {
            radioButtonActivo.Checked = true;

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var guardar = new Entidades.TiposProductos();

                guardar.Tipo = nombreTipoTextBox.Text;
                guardar.TipoId = (UtilidadesTiposProductos.TOINT(IDTipoTextBox.Text));
                guardar.esActivo=  estado;
              

                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                }
                else if (BLL.TiposProductos.Guardar(guardar))
                {
                    MessageBox.Show("Nuevo tipo articulo agregado con exito!");
                }

                Limpiar();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void radioButtonActivo_CheckedChanged(object sender, EventArgs e)
        {
            estado = true;
        }

        private void radioButtonNoactivo_CheckedChanged(object sender, EventArgs e)
        {
            estado = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDTipoTextBox.Text);
            Entidades.TiposProductos tipo;
            using (var db = new DAL.Repositorio<Entidades.TiposProductos>())
            {
                tipo = db.Buscar(p => p.TipoId == id);
                if (tipo != null)
                {
                  
                    nombreTipoTextBox.Text = tipo.Tipo;
                    if(estado == true)
                    {
                        //    bool r = false;
                        radioButtonNoactivo.Checked = true;
                    //    radioButtonActivo.Checked = true;
                    }
                    else
                    {
                        radioButtonActivo.Checked = true;
                       // radioButtonNoactivo.Checked = false;
                    }

                    MessageBox.Show("Resultados");
                }
                else
                {
                    MessageBox.Show("No existe ningun Articulo con ese Id.");
                }
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDTipoTextBox.Text);
            using (var db = new DAL.Repositorio<Entidades.TiposProductos>())
            {
                if (db.Eliminar(db.Buscar(p => p.TipoId == id)))
                {

                    MessageBox.Show("El Tipo se ha Eliminado con exito con exito.");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Tipo.");
                }
            }
        }
    }
}
