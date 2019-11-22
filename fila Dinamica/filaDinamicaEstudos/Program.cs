using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Fila dinâmica */
namespace filaDinamicaEstudos
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();
            Console.WriteLine("Enfileirando");
            fila.Enfileirar("CJ");        // Colocando na fila
            fila.Enfileirar("Mario");     // Colocando na fila
            fila.Enfileirar("Catalina");  // Colocando na fila
            fila.Enfileirar("franklin "); // Colocando na fila

            fila.Imprimir();

            Console.WriteLine("Desenfileirando um");
            fila.Desenfileirar();

            fila.Imprimir();

            Console.WriteLine("Mario existe: " + fila.Pesquisar("Mario"));
            Console.WriteLine("Lucas existe: " + fila.Pesquisar("Lucas"));

            Console.WriteLine("A Fila tem " + fila.Quantidade + " itens");

            Console.ReadKey();
        }
    }
}
