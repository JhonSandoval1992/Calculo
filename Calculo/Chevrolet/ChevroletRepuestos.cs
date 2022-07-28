using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Chevrolet
{
    public class ChevroletRepuestos:Chevrolet
    {
        string text;
        public ChevroletRepuestos(string text)
        {
            this.text = text;

        }
        public override string Paint()
        {
            return "******************\n" +
                   "*" + text + "\n" +
                   " ******************\n";
        }
    }
}
