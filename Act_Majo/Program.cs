using Act_Majo.Entities;
using Act_Majo.Services;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Act_Majo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Compra compra = new Compra();
            compra.Datos();
            compra.Suma();
        }
    }
}
