﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace CotizacionesTech.Registros
{
    public partial class rCotizaciones : Form
    {
        public rCotizaciones()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            CotizacionIdtextBox.Clear();
            FechadateTimePicker.Value = DateTime.Today;
            ClienteIdcomboBox.Text = " ";
            MontotextBox.Clear();
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(MontotextBox.Text))
            {
                MontoerrorProvider.SetError(MontotextBox, "Por favor llenar el campo vacio.");
                interruptor = false;
            }

            return interruptor;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var cotizacion = new Entidades.Cotizaciones();
            int id = 0;

            using(var Context = new DAL.Repositorio<Entidades.Cotizaciones>())
            {
                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos vacios.");
                }
                else
                {
                    cotizacion.CotizacionId = Utilidades.TOINT(CotizacionIdtextBox.Text);
                    cotizacion.Fecha = FechadateTimePicker.Value;
                    //cotizacion.ClienteId = Convert.ToUInt32(ClienteIdcomboBox.Text);
                    cotizacion.Monto = Convert.ToDecimal(MontotextBox.Text);

                    if (id != cotizacion.CotizacionId)
                    {
                        Context.Modificar(cotizacion);
                        MessageBox.Show("La cotizacion de modifico con exito.");
                    }
                    else
                    {
                        Context.Guardar(cotizacion);
                        MessageBox.Show("La cotizacion se guardo con exito.");
                    }
                }
            }
        }
    }
}
