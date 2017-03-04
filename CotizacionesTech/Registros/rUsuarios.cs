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
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Llene el campo Nombre");
                retorno = false;
            }
            if (string.IsNullOrEmpty(ClavetextBox.Text))
            {
                ClaveerrorProvider.SetError(ClavetextBox, "Llene el campo clave");
                retorno = false;
            }
            if (string.IsNullOrEmpty(ConfirmartextBox.Text))
            {
                ConfirmarerrorProvider.SetError(ConfirmartextBox, "Llene el campo Confirmar clave");
                retorno = false;
            }
            return retorno;

        }
        private void Limpiar()
        {
            IdtextBox.Clear();
            NombretextBox.Clear();
            ClavetextBox.Clear();
            ConfirmartextBox.Clear();

           /* NombreerrorProvider.Clear();

            NombretextBox.Focus();*/
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var usuarios = new Entidades.Usuarios();
            int id = 0;

            using (var conec = new DAL.Repositorio<Entidades.Usuarios>())
            {
                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos vacios");
                    Limpiar();
                }
                else
                {

                    usuarios.UsuarioId = Utilidades.TOINT(IdtextBox.Text);
                    usuarios.Nombre = NombretextBox.Text;
                    usuarios.Clave = ClavetextBox.Text;
                    

                    if (id != usuarios.UsuarioId)
                    {
                        conec.Modificar(usuarios);
                        MessageBox.Show("Usuario modificado.");
                    }
                    else
                    {
                        conec.Guardar(usuarios);
                        MessageBox.Show("Usuario Guardado.");
                    }

                }
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var usuario = new Entidades.Usuarios();
            int id = Utilidades.TOINT(IdtextBox.Text);

            using (var conec = new DAL.Repositorio<Entidades.Usuarios>())
            {
                usuario = conec.Buscar(p => p.UsuarioId == id);
            }

            if (usuario != null)
            {
                NombretextBox.Text = usuario.Nombre;
                ClavetextBox.Text = usuario.Clave;
                ConfirmartextBox.Text = usuario.Clave;
                
            }
            else
            {
                MessageBox.Show("No existe el usuario con ese id.");
                Limpiar();
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("Los campos estan vacios");
            }
            else
            {
                int id = Utilidades.TOINT(IdtextBox.Text);

                using (var conec = new DAL.Repositorio<Entidades.Usuarios>())
                {
                    if (conec.Eliminar(conec.Buscar(p => p.UsuarioId == id)))
                    {
                        Limpiar();
                        MessageBox.Show("Usuario eliminado con exito.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el Usuario.");
                    }
                }
            }
        }
    }
}
