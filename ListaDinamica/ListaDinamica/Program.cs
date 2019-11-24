using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista empresas = new Lista();
            Console.WriteLine("******** Lista Dinâmica ******** ");

            Console.WriteLine("\n> Inserindo Amazon, Apple, Samsumg, Motorola e Azus na lista");
            empresas.Inserir("Amazon");
            empresas.Inserir("Apple");
            empresas.Inserir("Samsumg");
            empresas.Inserir("Motorola");
            empresas.Inserir("Azus");

            Console.WriteLine("\n>Imprimindo valores do primeiro inserido ao ultimo ");
            empresas.Imprimir(0);

            Console.WriteLine("\n> Inserindo AnAple entre Amazon e Apple (posição 2)");
            empresas.Inserir("AnAple", 2);

            Console.WriteLine("\n>Imprimindo valores do primeiro inserido ao ultimo ");
            empresas.Imprimir(0);

            Console.WriteLine("\n>Deletando a primeira posição");
            empresas.Excluir();

            Console.WriteLine("\n>Imprimindo valores do primeiro inserido ao ultimo ");
            empresas.Imprimir(0);

            Console.WriteLine("\n>Localize e retorne a posição de motorola");
            int localize = empresas.Pesquisa("Motorola");
            if (localize != -1)
            {
                Console.WriteLine("Exclua Motorola");
                empresas.Excluir(localize);
            }
            else
                Console.WriteLine("Motorola não localizado");

            Console.WriteLine("\n>Imprimindo valores do primeiro inserido ao ultimo ");
            empresas.Imprimir(0);

            Console.WriteLine("\n>Alterar o Samsumg para Samsung");
            Console.WriteLine("\n>Localize Samsumg");
            localize = empresas.Pesquisa("Samsumg");
            if (localize != -1)
            {
                empresas.Alterar(localize, "Samsung");
            }
            else
            {
                Console.WriteLine("Samsung não localizado!");
            }

            Console.WriteLine("\n>Imprimindo valores do primeiro inserido ao ultimo ");
            empresas.Imprimir(0);

            Console.WriteLine("\n>Vamos ordenar os valores");
            empresas.Ordenar();

            Console.WriteLine("\n>Imprimindo valores do primeiro inserido ao ultimo ");
            empresas.Imprimir(0);

            Console.WriteLine("\n>Imprimindo valores do utimo inserido ao primeiro ");
            empresas.Imprimir(1);

            Console.ReadKey();
        }
    }
}
