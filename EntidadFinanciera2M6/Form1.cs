using EntidadFinanciera2M6.Data;
using Microsoft.EntityFrameworkCore;
using EntidadFinanciera2M6.Models;
using EntidadFinanciera2M6.Controladores;

namespace EntidadFinanciera2M6
{
    public partial class Form1 : Form
    {
        private EFService _servicio = new EFService();
        public Form1()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            //Ejecucion de consultas
            //Uso de linq-filtrado de informacion

            var clientes = _servicio.ObtenerClientesConCuentas();
            var cuentas = _servicio.ObtenerCuentasConCliente();
        }



        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            var form = new AgregarClienteForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _servicio.AgregarCliente(form.NuevoCliente);
                CargarDatos();
            }
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDesctivarCuenta_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cuenta para desactivar");
                return;
            }
            var cuentaId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;
            _servicio.DesactivarCuenta(cuentaId);
            CargarDatos();
        }

        

        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count != 2)
            {
                MessageBox.Show("Seleccione exactamente 2 cuentas");
                return;
            }
            else
            {
                var cuentaOrigenId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;
                var cuentaDestinoId = (int)dgvCuentas.SelectedRows[1].Cells["CuentaId"].Value;

                var form = new TransferenciaForms(cuentaOrigenId, cuentaDestinoId);
                if (form.ShowDialog() == DialogResult.OK)
                {
                 
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ShowDialog();
        }

      
    }
}
