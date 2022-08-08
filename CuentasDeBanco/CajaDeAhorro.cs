using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasDeBanco
{
    public class CajaDeAhorro : Cuenta
    {
        public int cantExtracciones { get; set; }
        public CajaDeAhorro(Cliente titular, int nro, decimal saldo, int cantExtracciones) : base(titular, nro, saldo)
        {
            this.cantExtracciones = cantExtracciones;
        }
        public override bool Extraer(decimal Monto)
        {
            if (Monto > Saldo && Monto > 0)
            {
                Console.WriteLine("Dinero no disponible.");
                return false;
            }
            else
            {
                Saldo -= Monto;
                cantExtracciones++;
                return true;
            }
        }
    }
}
