using EntidadFinanciera2M6.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntidadFinanciera2M6
{
    public partial class AgregarCuetasForm : Form
    {
        public Cuenta NuevaCuenta { get; private set; }
        private int _cienteId;
        public AgregarCuetasForm(int clienteId)
        {
            InitializeComponent();
            _cienteId = clienteId;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumCuenta.Text))
            {
                MessageBox.Show("El numero de cuenta es requerido");
                return;
            }
            else
            {
                NuevaCuenta = new Cuenta
                {
                    NumeroCuenta = txtNumCuenta.Text,
                    Saldo = numSaldoInicial.Value,
                    ClienteId = _cienteId,
                    Activa = true
                };
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Close();
        }
    }

}

