using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo
{
   public interface IModel2
    {
        public Repuestos CreateRepuestos(string text);
        public Precio CreatePrecio(string label);
        public Cantidad CreateCantidad(string type);
       
    }
}
