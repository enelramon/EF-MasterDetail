using System;
using System.Windows.Forms;


namespace CotizacionesTech.Consultas
{
    public partial class cClientes : Form
    {
        public cClientes()
        {
            InitializeComponent();
            LLenarComboBox();
        }

        private void cClientes_Load(object sender, EventArgs e)
        {
            
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

        public bool Validar()
        {
            if (string.IsNullOrEmpty(BuscartextBox.Text))
            {
                BuscarError.SetError(BuscartextBox, "Favor llenar el campo");
                return false;
            }
            return true;
        }

        public void SeleccionarOpcionCombo()
        {

            if (!Validar())
            {
                MessageBox.Show("Favor de llenar el campo");
            }
            else
            {
                if (ConsultacomboBox.SelectedIndex == 0)
                {
                    ClientesdataGridView.DataSource = BLL.Clientes.GetListId(Convert.ToInt32(BuscartextBox.Text));
                }

                if (ConsultacomboBox.SelectedIndex == 1)
                {
                    ClientesdataGridView.DataSource = BLL.Clientes.GetListNombre(BuscartextBox.Text);
                }

                if (ConsultacomboBox.SelectedIndex == 2)
                {
                    ClientesdataGridView.DataSource = BLL.Clientes.GetListDireccion(BuscartextBox.Text);
                }

                if (ConsultacomboBox.SelectedIndex == 3)
                {
                    ClientesdataGridView.DataSource = BLL.Clientes.GetListEmail(BuscartextBox.Text);
                }

                if (ConsultacomboBox.SelectedIndex == 4)
                {
                    ClientesdataGridView.DataSource = BLL.Clientes.GetListTelefono(Convert.ToInt32(BuscartextBox.Text));
                }

                if (ConsultacomboBox.SelectedIndex == 5)
                {
                    ClientesdataGridView.DataSource = BLL.Clientes.GetListCelular(Convert.ToInt32(BuscartextBox.Text));
                }

                if (ConsultacomboBox.SelectedIndex == 6)
                {
                    ClientesdataGridView.DataSource = BLL.Clientes.GetListLimiteCredito(Convert.ToInt32(BuscartextBox.Text));
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
