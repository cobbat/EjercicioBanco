using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasDeBanco
{
    public abstract class Cuenta
    {
        public Cliente titular { get; set; }
        public int Nro { get; set; }
        public decimal Saldo { get; set; }
        public Cuenta(Cliente Titular, int nro, decimal saldo)
        {
            titular = Titular;
            Nro = nro;
            Saldo = saldo;
        }
        public void Depositar(decimal Monto)
        {
            if (Monto > 0)
            {
                Saldo += Monto;
            }
            else
            {
                Console.WriteLine("El monto para depositar debe ser mayor a 0");
            }
        }
        public abstract bool Extraer(decimal Monto);
        public void verSaldo()
        {
            Console.WriteLine( $"\nEl saldo disponible es ${Saldo}");
        }
    }
}