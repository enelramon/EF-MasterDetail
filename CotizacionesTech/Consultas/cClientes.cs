using System;
using System.Windows.Forms;


namespace CotizacionesTech.Consultas
{
    public partial class cClientes : Form
    {
        public cClientes()
        {
            InitializeComponent();
        }

        private void cClientes_Load(object sender, EventArgs e)
        {
            LLenarComboBox();
        }

        public void LLenarComboBox()
        {
            ConsultacomboBox.Items.Insert(0, "ClienteId");
            ConsultacomboBox.Items.Insert(1, "Nombres");
            ConsultacomboBox.Items.Insert(2, "Direccion");
            ConsultacomboBox.Items.Insert(3, "Email");
            ConsultacomboBox.Items.Insert(4, "Telefono");
            ConsultacomboBox.Items.Insert(5, "Celular");
            ConsultacomboBox.Items.Insert(6, "LimiteCredito");

            ConsultacomboBox.DataSource = ConsultacomboBox.Items;
            ConsultacomboBox.DisplayMember = "ClienteId";
        }

        public void SeleccionarOpcionCombo()
        {
            using (var consulta = new DAL.Repositorio<Entidades.Clientes>())
            {
                if (ConsultacomboBox.SelectedIndex == 0)
                {
                    ConsultacomboBox.DataSource = consulta.Lista(p => p.ClienteId == Convert.ToInt32(BuscartextBox.Text));
                }

                if (ConsultacomboBox.SelectedIndex == 1)
                {
                    ConsultacomboBox.DataSource = consulta.Lista(p => p.Nombres == BuscartextBox.Text);
                }

                if (ConsultacomboBox.SelectedIndex == 2)
                {
                    ConsultacomboBox.DataSource = consulta.Lista(p => p.Direccion == BuscartextBox.Text);
                }

                if (ConsultacomboBox.SelectedIndex == 3)
                {
                    ConsultacomboBox.DataSource = consulta.Lista(p => p.Email == BuscartextBox.Text);
                }

                if (ConsultacomboBox.SelectedIndex == 4)
                {
                    ConsultacomboBox.DataSource = consulta.Lista(p => p.Telefono == BuscartextBox.Text);
                }

                if (ConsultacomboBox.SelectedIndex == 5)
                {
                    ConsultacomboBox.DataSource = consulta.Lista(p => p.Celular == BuscartextBox.Text);
                }

                if (ConsultacomboBox.SelectedIndex == 6)
                {
                    ConsultacomboBox.DataSource = consulta.Lista(p => p.LimiteCredito == Convert.ToInt32(BuscartextBox.Text));
                }
            }
        }

        private void Filtrarbutton_Click(object sender, EventArgs e)
        {

            SeleccionarOpcionCombo();

        }

        private void BuscartextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
