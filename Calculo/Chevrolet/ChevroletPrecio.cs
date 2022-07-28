using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Chevrolet
{
    public class ChevroletPrecio:Precio
    {
        string label;
        public ChevroletPrecio(string label)//constructor
        {
            this.label = label;
        }
        public override string Paint()
        {
            return "**" + label + "**";

        }
    }
}
