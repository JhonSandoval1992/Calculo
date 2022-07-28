using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Chevrolet
{
    public class Chevrolet: IModel2

    {
        //Relacion de dependencia 
        public Repuestos CreateRepuestos(string text)
        {
            return new ChevroletRepuestos(text);
        }

        public Cantidad CreateCantidad(string type)
        {
            return new ChevroletCantidad(type);
        }

        public Precio CreatePrecio(string label)
        {
            return new ChevroletPrecio(label);
        }

        public string Paint()
        {
            throw new NotImplementedException();
        }
    }
}

