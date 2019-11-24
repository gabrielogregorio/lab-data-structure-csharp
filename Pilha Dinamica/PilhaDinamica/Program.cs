using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha pilhaDinamica = new Pilha(); // Instância da classe
            bool sair = false;                 // Sair do programa
            string valorInserir = "";          // Valor que será inserido na Pilha

            while (!sair)
            {
                Console.WriteLine(" ************* Pilha Dinâmica ************* \n");

                Console.WriteLine("Escolha uma opção:  ");
                Console.WriteLine("1 - Adicionar item  ");
                Console.WriteLine("2 - Remover item    ");
                Console.WriteLine("3 - Mostrar itens   ");
                Console.WriteLine("4 - Sair            ");

                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    Console.Write("Digite um valor: ");

                    valorInserir = Console.ReadLine();
                    pilhaDinamica.Empilhar(valorInserir);
                }
                else if (escolha == "2")
                {
                    Console.WriteLine("Removendo o topo...");
                    pilhaDinamica.Desempilhar();
                }
                else if (escolha == "3")
                {
                    pilhaDinamica.Imprimir();
                }
                else if (escolha == "4")
                {
                    sair = true;
                }
                else
                {
                    Console.WriteLine("Digite uma opção válida!");
                }

                Console.WriteLine("Presione enter para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
