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
    public partial class rClientes : Form
    {
        public rClientes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
            DirecciontextBox.Clear();
            EmailtextBox.Clear();
            TelefonomaskedTextBox.Clear();
            CelularmaskedTextBox.Clear();
            LimiteCreditotextBox.Clear();

            NombreerrorProvider.Clear();


            NombretextBox.Focus();
        }     

        private bool Validar()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Por favor llenar el campo vacio.");
                retorno = false;
            }
            if (string.IsNullOrEmpty(DirecciontextBox.Text))
            {
                NombreerrorProvider.SetError(DirecciontextBox, "Por favor llenar el campo vacio.");
                retorno = false;
            }
            if (string.IsNullOrEmpty(EmailtextBox.Text))
            {
                NombreerrorProvider.SetError(EmailtextBox, "Por favor llenar el campo vacio.");
                retorno = false;
            }
            if (string.IsNullOrEmpty(TelefonomaskedTextBox.Text))
            {
                NombreerrorProvider.SetError(TelefonomaskedTextBox, "Por favor llenar el campo vacio.");
                retorno = false;
            }
            if (string.IsNullOrEmpty(CelularmaskedTextBox.Text))
            {
                NombreerrorProvider.SetError(CelularmaskedTextBox, "Por favor llenar el campo vacio.");
                retorno = false;
            }
            if (string.IsNullOrEmpty(LimiteCreditotextBox.Text))
            {
                NombreerrorProvider.SetError(LimiteCreditotextBox, "Por favor llenar el campo vacio.");
                retorno = false;
            }

            return retorno;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var cliente = new Entidades.Clientes();
            int id = 0;

            using(var conec = new DAL.Repositorio<Entidades.Clientes>())
            {
                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos vacios");
                    Limpiar();
                }
                else
                {
                    cliente.ClienteId = Utilidades.TOINT(IdtextBox.Text);
                    cliente.Nombres = NombretextBox.Text;
                    cliente.Direccion = DirecciontextBox.Text;
                    cliente.Email = EmailtextBox.Text;
                    cliente.Telefono = TelefonomaskedTextBox.Text;
                    cliente.Celular = CelularmaskedTextBox.Text;
                    cliente.LimiteCredito = Utilidades.TOINT(LimiteCreditotextBox.Text);

                    if (id != cliente.ClienteId)
                    {
                        conec.Modificar(cliente);
                        MessageBox.Show("El cliente se a modificado.");
                    }
                    else
                    {
                        conec.Guardar(cliente);
                        MessageBox.Show("El cliente se a guardado.");
                    }
                }
            }

            Limpiar();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var cliente = new Entidades.Clientes(); 
            int id = Utilidades.TOINT(IdtextBox.Text);

            using (var conec = new DAL.Repositorio<Entidades.Clientes>())
            {
                cliente = conec.Buscar(p => p.ClienteId == id);
            }

            if (cliente != null)
            {
                NombretextBox.Text = cliente.Nombres;
                DirecciontextBox.Text = cliente.Direccion;
                EmailtextBox.Text = cliente.Email;
                TelefonomaskedTextBox.Text = cliente.Telefono;
                CelularmaskedTextBox.Text = cliente.Celular;
                LimiteCreditotextBox.Text = cliente.LimiteCredito.ToString();
            }
            else
            {
                MessageBox.Show("No existe cliente con ese id.");
                Limpiar();
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("Los campos estan vacios");
            }
            else
            {
                int id = Utilidades.TOINT(IdtextBox.Text);

                using(var conec = new DAL.Repositorio<Entidades.Clientes>())
                {
                    if (conec.Eliminar(conec.Buscar(p => p.ClienteId == id)))
                    {
                        Limpiar();
                        MessageBox.Show("Cliente eliminado con exito.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el cliente.");
                    }
                }
            }
        }
    }
}