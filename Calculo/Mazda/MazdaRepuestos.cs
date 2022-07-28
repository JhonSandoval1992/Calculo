using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Mazda
{
   public class MazdaRepuestos:Repuestos
    {
        string text;
        public MazdaRepuestos(string text)
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
