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
    //Arreglo de errores ortograficos

    //Cambio de nombre de AgregarCuetasForm a AgregarCuentasForm
    public partial class AgregarCuentasForm : Form
    {
        public Cuenta NuevaCuenta { get; private set; }
        private int _clienteId;  //Cambio de la variable de cienteId a clienteId
        public AgregarCuentasForm(int clienteId)
        {
            InitializeComponent();
            _clienteId = clienteId; //Cambio de la variable de cienteId a clienteId
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumCuenta.Text))
            {
                MessageBox.Show("El numero de cuenta es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                NuevaCuenta = new Cuenta
                {
                    NumeroCuenta = txtNumCuenta.Text,
                    Saldo = numSaldoInicial.Value,
                    ClienteId = _clienteId,
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

