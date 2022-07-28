using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Mazda
{
    public class Mazda:IModel2
    {
        //Relacion de dependencia
        public Repuestos CreateRepuestos(string text)
        {
            return new MazdaRepuestos(text);
        }

        public Cantidad CreateCantidad(string type)
        {
            return new MazdaCantidad(type);
        }

        public Precio CreatePrecio(string label)
        {
            return new MazdaPrecio(label);
        }
    }
}
