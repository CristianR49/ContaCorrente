using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    public class Movimentacao
    {
        public string valor;
        public string tipo;

        public string propriedade
        {
            set
            {
                string[] infos = value.Split(' ');
                valor = infos[0];
                tipo = infos[1];
            }
        }

    }
}
