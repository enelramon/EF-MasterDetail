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
    public partial class cTiposProductos : Form
    {
        public cTiposProductos()
        {
            InitializeComponent();
        }

        private void cTiposProductos_Load(object sender, EventArgs e)
        {
            LLenarComboBox();
        }

        public void LLenarComboBox()
        {
            FiltrarcomboBox.Items.Insert(0, "ID");
            FiltrarcomboBox.Items.Insert(1, "Tipo");                       
            FiltrarcomboBox.DataSource = FiltrarcomboBox.Items;
            FiltrarcomboBox.DisplayMember = "Todos";
        }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(FiltrartextBox.Text))
            {
                FiltrarerrorProvider.SetError(FiltrartextBox, "Llenar los campos vacios.");
                return false;
            }
            return true;
        }

        public void FiltrarOpcion()
        {
            if (!Validar())
            {
                MessageBox.Show("Llenar los campos.");
            }
            else
            {
                if (FiltrarcomboBox.SelectedIndex == 0)
                {
                    TiposPruductosdataGridView.DataSource = BLL.TiposProductos.Lista(tp=> tp.TipoId == Convert.ToInt32(FiltrartextBox.Text));
                }

                if (FiltrarcomboBox.SelectedIndex == 1)
                {
                    TiposPruductosdataGridView.DataSource = BLL.TiposProductos.Lista(tp=> tp.Tipo == FiltrartextBox.Text);
                }               
            }

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            FiltrarOpcion();
        }
                
    }
}
