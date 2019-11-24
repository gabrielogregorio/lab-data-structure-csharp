using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    class Noh
    {
        string valor;  // Valor do nó
        Noh anterior;  // referência ao anterior

        public string Valor { get; set; }
        public Noh Anterior { get; set; }
    }
}
