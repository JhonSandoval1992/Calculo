using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Mazda
{
    public class MazdaPrecio:Precio
    {
        string label;
        public MazdaPrecio(string label)//constructor
        {
            this.label = label;
        }
        public override string Paint()
        {
            return "**" + label + "**";

        }
    }
}
