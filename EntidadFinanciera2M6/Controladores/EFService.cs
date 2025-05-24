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

    }
}
