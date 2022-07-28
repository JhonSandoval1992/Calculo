using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Toyota
{
    public class ToyotaRepuestos: Toyota
    {
        string text;
        public ToyotaRepuestos(string text)
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
