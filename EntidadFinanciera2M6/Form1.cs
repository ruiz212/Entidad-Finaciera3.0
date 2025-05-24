using EntidadFinanciera2M6.Data;
using Microsoft.EntityFrameworkCore;
using EntidadFinanciera2M6.Models;

namespace EntidadFinanciera2M6
{
    public partial class Form1 : Form
    {
        private EntidadFinancieraContext _db = new EntidadFinancieraContext();
        public Form1()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            //Ejecucion de consultas
            //Uso de linq-filtrado de informacion

            var clientes = _db.Clientes.Include(c => c.Cuentas).ToList();
            var cuentas = _db.Cuentas.Include(c => c.Cliente).Where(c => c.Activa).
                Select(c => new
                {
                    c.CuentaId,
                    c.NumeroCuenta,
                    c.Saldo,
                    c.Activa,
                    c.ClienteId,
                    c.Cliente.Nombre
                }).ToList();

            // dgvClientes.DataSource = _db.Clientes.ToList();
            dgvClientes.DataSource = clientes;
            dgvCuentas.DataSource = cuentas;
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            var form = new AgregarClienteForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _db.Clientes.Add(form.NuevoCliente);
                _db.SaveChanges();
                CargarDatos();
            }
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente primero");
                return;
            }
            var clienteId = (int)dgvClientes.SelectedRows[0].Cells["ClienteId"].Value;
            var form = new AgregarCuetasForm(clienteId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                _db.Cuentas.Add(form.NuevaCuenta);
                _db.SaveChanges();
                CargarDatos();
            }
        }

        private void btnDesctivarCuenta_Click(object sender, EventArgs e)
        {
            if (dgvCuentas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una cuenta para desactivar");
                return;
            }
            var cuentaId = (int)dgvCuentas.SelectedRows[0].Cells["CuentaId"].Value;
            var cuenta = _db.Cuentas.Find(cuentaId);
            if (cuenta != null)
                cuenta.Activa = false;
            _db.SaveChanges();
            CargarDatos();
        }

        private void RealizarTransacc(int origenCuenta, int destinoCuenta, decimal monto)
        {
            //Transacciones completas
            //implentacion de transacciones
            //Nivel de asilaiento (serializable para operaciones financieras)
            using var transaccion = _db.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);
            try
            {
                var cuentaOrigen = _db.Cuentas.FirstOrDefault(c => c.CuentaId == origenCuenta);
                var cuentaDestino = _db.Cuentas.FirstOrDefault(c => c.CuentaId == destinoCuenta);

                if (cuentaOrigen.Saldo < monto)
                {
                    throw new Exception("Saldo insuficiente");
                }
                cuentaOrigen.Saldo -= monto;
                cuentaDestino.Saldo += monto;
                _db.Transacciones.Add(new Transaccion
                {
                    Monto = monto,
                    Fecha = DateTime.Now,
                    Tipo = "Transferencia",
                    Descripcion = "Transferencia",
                    CuentaOrigenId = origenCuenta,
                    CuentaDestinoId = destinoCuenta
                });
                _db.SaveChanges();
                //Completamos la transaccion
                transaccion.Commit();
                MessageBox.Show("Trasnferencia realizada con exito");
                CargarDatos();

            }
            catch (Exception ex)
            {
                //reversion de transacciones
                transaccion.Rollback();
                MessageBox.Show($"Error en la transferencia: {ex.Message}");
            }
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
                    RealizarTransacc(cuentaOrigenId, cuentaDestinoId, form.Monto);
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
