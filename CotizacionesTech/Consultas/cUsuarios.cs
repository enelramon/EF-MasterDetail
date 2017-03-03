using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CotizacionesTech.Consultas
{
    public partial class cUsuarios : Form
    {
        public cUsuarios()
        {
            InitializeComponent();
        }

        private void LlenarCombo()
        {
            FiltrarComboBox.Items.Insert(0, "UsuarioId");
            FiltrarComboBox.Items.Insert(1, "Nombre");
            FiltrarComboBox.Items.Insert(2, "Todo");

            FiltrarComboBox.DataSource = FiltrarComboBox.Items;
            FiltrarComboBox.DisplayMember = "Nombre";
        }

        private void Filtrar()
        {
            using (var db = new DAL.Repositorio<Entidades.Usuarios>())
            {
                if (FiltrarComboBox.SelectedIndex == 0)
                {
                    UsuariosDataGridView.DataSource = db.Lista(U => U.UsuarioId == Utilidades.TOINT(FiltrarTextBox.Text));
                }
                else if (FiltrarComboBox.SelectedIndex == 1)
                {
                    UsuariosDataGridView.DataSource = db.Lista(U => U.Nombre == FiltrarTextBox.Text);
                }
                else
                {
                    UsuariosDataGridView.DataSource = db.ListaTodo();
                }
            }
        }

        private void cUsuarios_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void FiltrarButton_Click(object sender, EventArgs e)
        {
            Filtrar();
        }
        

    }
}
