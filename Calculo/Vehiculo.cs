using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
    public class Vehiculo
    {
        public IModel2 marca;
        List<IModelo> GUI;

        public Vehiculo(IModel2 marca) //Constructor
        {
            this.marca = marca;
            GUI = new List<IModelo>();
        }

        public void CrearIM()// Crear la interfaz de maodelo
        {
            Precio titulo = marca.CreatePrecio("CAMIONETA");
            Precio mensaje = marca.CreatePrecio("Toyota");
            Cantidad iconoalerta = marca.CreateCantidad("Cantidad");
            Repuestos buttonOk =marca.CreateRepuestos("ok");
            Repuestos buttonCancelar = marca.CreateRepuestos("Cancelar ");

            GUI.Add(titulo);
            GUI.Add(mensaje);
            GUI.Add(iconoalerta);
            GUI.Add(buttonOk);
            GUI.Add(buttonCancelar);
        }
        public void Paint()
        {
            String respuesta = "";
            foreach (var objeto in GUI)
            {
                respuesta+= objeto.Paint() + "\n";
            }

            Console.WriteLine(respuesta);
        }
    }
}
