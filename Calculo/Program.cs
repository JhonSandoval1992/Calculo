

using Calculo;
using Calculo.Toyota;
using Calculo.Mazda;
using Calculo.Chevrolet;
using System;

namespace Microsoft
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Vehiculo app = new Vehiculo(new Toyota ());
            app.CrearIM();
            app.Paint();
        }
    }
}