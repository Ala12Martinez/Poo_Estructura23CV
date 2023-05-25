using Act_Majo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Act_Majo.Services
{
    public class Compra
    {
        public string Datos()
        {
            Cliente cliente = new Cliente();
            Console.WriteLine("Ingrese Su Nombre");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Su Apedillo");
            cliente.Apedillo = Console.ReadLine();
            Console.WriteLine("Ingrese Su Correo");
            cliente.Correo = Console.ReadLine();
            Console.WriteLine("Ingrese Su Telefono");
            cliente.Telefono = Console.ReadLine();

            string datosCompletos = $"{cliente.Nombre} {cliente.Apedillo}, {cliente.Correo}, {cliente.Telefono}";
            return datosCompletos;

        }

        public void Suma()
        {
            
            Console.WriteLine("Ingrese Articulo1");
            int articulo1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Articulo2");
            int articulo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Articulo3");
            int articulo3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Articulo4");
            int articulo4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Articulo5");
            int articulo5 = int.Parse(Console.ReadLine());

            int suma = articulo1 + articulo2 + articulo3 + articulo4 + articulo5;
            
            if (suma >= 5000) 
            {
                Console.WriteLine("El total de la compra seria mayor a 5000. Se ofrese el 10% de descuento.");
                double total= suma * 0.100;
                Console.WriteLine($"Se pagara ${total}");

            }
            if (suma >= 8000)
            {
                Console.WriteLine("El total de la compra es mayor a $8000. Se ofrecen 3 meses sin intereses.");
                double pagoMensual = suma / 3;
                Console.WriteLine($"Se pagará ${pagoMensual} cada mes durante 3 meses.");
            }
            else if (suma >= 1000)
            {
                Console.WriteLine("El total de la compra es mayor a $10000. ¿Desea 3 o 6 meses sin intereses? Ingrese el número correspondiente.");
                int meses = int.Parse(Console.ReadLine());
                double pagoMensual = suma / meses;
                Console.WriteLine($"Se pagará ${pagoMensual} cada mes durante {meses} meses.");
            }
            else
            {
                Console.WriteLine("El total de la compra es menor o igual a $10000. No se aplica ningún plan de pagos sin intereses.");
            }
            
        }
    }
}


