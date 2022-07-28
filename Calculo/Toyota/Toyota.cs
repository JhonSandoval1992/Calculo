using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Toyota
{
    public class Toyota : IModel2
    {
        public Repuestos CreateRepuestos(string text)
        {
            return new ToyotaRepuestos(text);
        }

        public Cantidad CreateCantidad(string type)
        {
            return new ToyotaCantidad(type);
        }

        public Precio CreatePrecio(string label)
        {
            return new ToyotaPrecio(label);
        }

        public string Paint()
        {
            throw new NotImplementedException();
        }
    }
}
