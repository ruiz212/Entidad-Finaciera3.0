using EntidadFinanciera2M6.Data;
using EntidadFinanciera2M6.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadFinanciera2M6.Controladores
{
    public class EFService
    {
        private readonly EntidadFinancieraContext _context;

        public EFService()
        {
            _context = new EntidadFinancieraContext();
        }

        public List<Cliente> ObtenerClientesConCuentas()
        {
            return _context.Clientes.Include(c => c.Cuentas).ToList();
        }

        public List<object> ObtenerCuentasConCliente()
        {
            return _context.Cuentas.Include(c => c.Cliente)
                .Select(c => new
                {
                    c.CuentaId,
                    c.NumeroCuenta,
                    c.Saldo,
                    c.Activa,
                    c.ClienteId,
                    c.Cliente.Nombre
                }).ToList<object>();
        }
        public void AgregarCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void AgregarCuenta(Cuenta cuenta)
        {
            _context.Cuentas.Add(cuenta);
            _context.SaveChanges();
        }
        public void DesactivarCuenta(int cuentaId)
        {
            var cuenta = _context.Cuentas.Find(cuentaId);
            if (cuenta != null)
            {
                cuenta.Activa = false;
                _context.SaveChanges();
            }
        }

        public void TransferirFondos(int origenId, int destinoId, decimal monto)
        {
            using var transaccion = _context.Database.BeginTransaction(System.Data.IsolationLevel.Serializable);
            try
            {
                var cuentaOrigen = _context.Cuentas.FirstOrDefault(c => c.CuentaId == origenId);
                var cuentaDestino = _context.Cuentas.FirstOrDefault(c => c.CuentaId == destinoId);

                if (cuentaOrigen == null || cuentaDestino == null)
                    throw new Exception("Cuentas no encontradas");

                if (cuentaOrigen.Saldo < monto)
                    throw new Exception("Saldo insuficiente");

                cuentaOrigen.Saldo -= monto;
                cuentaDestino.Saldo += monto;

                _context.Transacciones.Add(new Transaccion
                {
                    Monto = monto,
                    Fecha = DateTime.Now,
                    Tipo = "Transferencia",
                    Descripcion = "Transferencia entre cuentas",
                    CuentaOrigenId = origenId,
                    CuentaDestinoId = destinoId
                });

                _context.SaveChanges();
                transaccion.Commit();
            }
            catch
            {
                transaccion.Rollback();
                throw;
            }
        }

        public List<Transaccion> ObtenerTransacciones()
        {
            return _context.Transacciones.ToList();
        }

    }
}
