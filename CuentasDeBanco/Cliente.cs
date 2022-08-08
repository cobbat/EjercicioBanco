using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentasDeBanco
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public string Direccion{get;set;}
        public Cliente(string nombre,int dni, string direccion)
        {
            Nombre = nombre;
            Dni = dni;
            Direccion = direccion;
            
        }
        public string verNombre(string nombre)
        {
            return Nombre; 
        }
        public void modiNombre(string nuevoNombre)
        {
            Nombre = nuevoNombre;
        }
    }
}
