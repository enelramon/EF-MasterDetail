using DAL;
using Entidades;
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
    public partial class cProductos : Form
    {
        public cProductos()
        {
            InitializeComponent();

        }

        private bool Validar()
        {

            if(comboBoxFilter.SelectedIndex > 1)
            {
                if (String.IsNullOrEmpty(textBoxPrecioDesde.Text) || String.IsNullOrEmpty(textBoxPrecioHasta.Text))
                {
                    errorProvider.SetError(textBoxPrecioDesde, "Esta vacio!");
                    errorProvider.SetError(textBoxPrecioHasta, "Esta vacio!");
                    return false;
                }
                else
                {
                    errorProvider.Clear();
                    return true;
                }

            }
            else
            {
                if (String.IsNullOrEmpty(textBoxSearch.Text))
                {

                    errorProvider.SetError(textBoxSearch, "Esta vacio!");
                    return false;
                }
                
                else 
                {
                    errorProvider.Clear();
                    return true;
                }
                
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (Validar())
            {


                using (var db = new Repositorio<Productos>())
                {

                    switch (comboBoxFilter.SelectedIndex)
                    {

                        case 0:
                            {
                                dataGridViewProductos.DataSource = db.Buscar(x => x.ProductoId == Convert.ToInt32(buttonSearch));
                                break;
                            }
                        case 1:
                            {
                                dataGridViewProductos.DataSource = db.Lista(x => x.Descripcion == textBoxSearch.Text);
                                break;
                            }
                        case 2:
                            {
                                dataGridViewProductos.DataSource = db.Lista(x => x.Precio >= Convert.ToInt32(textBoxPrecioDesde) && x.Precio <= Convert.ToInt32(textBoxPrecioHasta));
                                break;
                            }
                    }
                }
            }      
        }

        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxFilter.SelectedIndex > 1)
            {
                textBoxSearch.Visible = false;
                textBoxPrecioDesde.Visible = true;
                textBoxPrecioHasta.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                textBoxSearch.Visible = true;
                textBoxPrecioDesde.Visible = false;
                textBoxPrecioHasta.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
        }
    }
}
