using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Toyota
{
    public class ToyotaPrecio:Precio
    {
        string label;
        public ToyotaPrecio(string label)//constructor
        {
            this.label = label;
        }
        public override string Paint()
        {
            return "**" + label + "**";

        }
    }
}
