using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasDeBanco
{
    public class CuentaCorriente : Cuenta
    {
        const decimal tope = -1000;
        public decimal SaldoEnRojo { get; set; }
        public CuentaCorriente(Cliente titular, int nro, decimal saldo, decimal saldoEnRojo) : base(titular, nro, saldo)
        {
            SaldoEnRojo = saldoEnRojo;
        }

        public override bool Extraer(decimal Monto)//monto mayor a 0
        {
            if ((Saldo - Monto) > tope && Monto > 0)
            {
                if (Saldo <= 0)
                {
                    SaldoEnRojo -= Monto + tope;
                    Console.WriteLine($"saldo en rojo {SaldoEnRojo}");
                }
                Saldo -= Monto;
                return true;
            }
            else
            {
                Console.WriteLine("Monto mayor a tope o monto menor a 0");
                return false;
            }
            // 0 es mayor que -1000 es mayor que -2000
        }
    }
}
