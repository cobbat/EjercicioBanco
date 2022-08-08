using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasDeBanco
{
    public class Banco
    {
        List<Cliente> Clientelist { get; set; }
        List<Cuenta> Cuentalist { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public Banco(List<Cliente> listaclientes, List<Cuenta> listacuentas, string nombre, string direccion)
        {
            Clientelist = listaclientes;
            Cuentalist = listacuentas;
            Nombre = nombre;
            Direccion = direccion;
        }

        public void Transferir(Cuenta cuentaEmisora, Cuenta cuentaReceptora, decimal montoTransf)
        {
            //si no puedo extraer no deposito
            bool pudeExtraer;
            pudeExtraer = cuentaEmisora.Extraer(montoTransf);
            if (pudeExtraer)
            {
            cuentaReceptora.Depositar(montoTransf);
            }
            else
            {
                Console.WriteLine("No se pudo transferir pq no se puede extraer");
            }
        }
    }
}
