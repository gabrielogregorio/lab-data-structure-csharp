using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaDinamicaEstudos
{
    class Noh
    {
        string valor;
        Noh frente;
        Noh atras;

        public string Valor { get; set; }
        public Noh Frente { get; set; }
        public Noh Atras { get; set; }
    }
}
