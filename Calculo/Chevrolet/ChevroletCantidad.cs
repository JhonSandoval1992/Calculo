using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Chevrolet
{
    public class ChevroletCantidad:Cantidad
    {
        string type;//atributo
        public ChevroletCantidad(string type) //constructor
        {
            this.type = type;
        }

      

        public override string Paint()
        {
            string resultado = "";
            switch (type)
            {
                case "Alerta":

                    resultado = "** \n" +
                             "** \n" +
                             "** Alerta**\n" +
                             " **   ** \n" +
                             "     ***\n";
                    break;

                case "Peligro":

                    break;



            }
            return resultado;
        }
    }
}
