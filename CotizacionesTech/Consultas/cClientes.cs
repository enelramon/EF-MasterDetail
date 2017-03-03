using System;
using System.Windows.Forms;
using DAL;

namespace CotizacionesTech.Consultas
{
    public partial class cClientes : Form
    {
        public cClientes()
        {
            InitializeComponent();
        }

        private void Filtrarbutton_Click(object sender, EventArgs e)
        {

            using (var consulta = new Repositorio<Entidades.Clientes>())
            {
                ClientesdataGridView.DataSource = consulta.Lista(p=> p.ClienteId == Convert.ToInt32(BuscartextBox.Text));
            }

        }

        private void BuscartextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
