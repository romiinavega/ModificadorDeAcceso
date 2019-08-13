using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente
                = new Cliente();
            cliente.Nombre = "Rominice";
            cliente.Telefono = "123456";


            Console.WriteLine("Nombre: " + cliente.Nombre);
            Console.WriteLine("Telefono: " + cliente.Telefono);
            try
            {
                cliente.Curp = "123456789";
                Console.WriteLine("Curp:" + cliente.Curp);
            }
            catch(Exception e)
            {
                Console.WriteLine ("La curp no es de 18 caracteres");
            }
            Cuenta cuenta
                = new Cuenta();
            cuenta.Propietario = "";
            cuenta.saldo = 864502864576;


            Console.WriteLine(" Propietario : " + cuenta.Propietario);
            Console.WriteLine("Saldo : " + cuenta.saldo);
            try
            {
                cuenta.Identificador = " 123456789012334";
                Console.WriteLine(" Indetificador: " + cuenta.Identificador);
            }
            catch (Exception e)
            {
                Console.WriteLine(" El identificador no incluye de 10 a 14 caracteres");
            }

            Console.Read();
        }
    }
}
