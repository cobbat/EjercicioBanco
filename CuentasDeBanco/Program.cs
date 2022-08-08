using CuentasDeBanco;

namespace Program
{
    class ProbarBanco
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Maria Becerra", 44108901, "Siempre viva 123");
            Cliente cliente2 = new Cliente("Rusher King", 36457809, "Monroe 47");

            CajaDeAhorro cajaDeAhorro1 = new CajaDeAhorro(cliente1, 0, 100m, 0);
            CajaDeAhorro cajaDeAhorro2 = new CajaDeAhorro(cliente2, 0, 100m, 0);

            CuentaCorriente cuentaCorriente1 = new CuentaCorriente(cliente1, 011, 0m, 0);
            CuentaCorriente cuentaCorriente2 = new CuentaCorriente(cliente2, 092, 0m, 0);

            List<Cliente> ListaClientes = new List<Cliente>();
            ListaClientes.Add(cliente1);
            ListaClientes.Add(cliente2);

            List<Cuenta> ListaCuentas = new List<Cuenta>();
            ListaCuentas.Add(cuentaCorriente1);
            ListaCuentas.Add(cuentaCorriente2);
            ListaCuentas.Add(cajaDeAhorro1);
            ListaCuentas.Add(cajaDeAhorro2);

            Banco banco = new Banco(ListaClientes, ListaCuentas, "Banco Nacion", "Ala 123");

            banco.Transferir(cajaDeAhorro1, cuentaCorriente1, 10);
            cajaDeAhorro1.verSaldo();

            /////////////////////////////////////////////////////////////////////////////////

            Console.ReadLine();
        }
    }
}