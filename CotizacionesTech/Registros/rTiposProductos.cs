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

       private void Limpiar()
        {
            IDTipoTextBox.Clear();
            nombreTipoTextBox.Clear();
            checkBoxesActivo.Checked = false;
            nombreTipoTextBox.Focus();

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
        
        }

        private void esActivo_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var guardar = new Entidades.TiposProductos();
            int id = 0;

            try
            {
                   if (!Validar())
                    {
                        MessageBox.Show("Por favor llenar los campos");
                    }
                    else
                    {
                        //No Crei necesario crear una funcion llenar campos ya que son pocas cosas que se deben guardar 
                        guardar.Tipo = nombreTipoTextBox.Text;
                        guardar.TipoId = (Utilidades.TOINT(IDTipoTextBox.Text));

                        //Asigna true o false al checkBox segun selecione el usuario
                        if (checkBoxesActivo.Checked == false)
                        {

                            guardar.esActivo = false;
                        }
                        else
                        {
                            guardar.esActivo = true;
                        }
                        ////////////////////////////////////////////


                        //Modifica si es necesario  de lo contrario guarda 
                        if (id != guardar.TipoId)
                        {
                            BLL.TiposProductos.Mofidicar(guardar);
                            MessageBox.Show("Tipo de articulo modificado");
                        }
                        else
                        {
                            BLL.TiposProductos.Guardar(guardar);
                            MessageBox.Show("Nuevo tipo articulo agregado con exito!");
                        }
                    

                

                }
                Limpiar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(IDTipoTextBox.Text);
            var bll = new BLL.TiposProductos();
          

          
            var user = BLL.TiposProductos.Buscar(p=> p.TipoId==id);
            if (BLL.TiposProductos.Eliminar(user))
                {

                    MessageBox.Show("El Tipo se ha Eliminado con exito con exito.");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Tipo.");
                }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int id = int.Parse(IDTipoTextBox.Text);
            Entidades.TiposProductos tipo;

                tipo = BLL.TiposProductos.Buscar(p => p.TipoId == id);
                if (tipo != null)
                {

                    nombreTipoTextBox.Text = tipo.Tipo;
                    checkBoxesActivo.Checked = tipo.esActivo;

                    MessageBox.Show("Resultados de su busqueda");
                }
                else
                {
                    MessageBox.Show("No existe ningun Articulo con ese Id.");
                }
            }
        
    }
}
