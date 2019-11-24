using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Estrutura de dados: Pilha Dinâmica.
Aula Ministrado pelo professor Ronnie Marcos Rillo na Fatec de Araçatuba-SP
Autor: Gabriel Gregório da Silva
*/

namespace PilhaDinamica
{
    class Pilha
    {
        Noh topo = null; // O topo é nulo
        int quantidade = 0; // Não tem ninguém na pilha

        public int Quantidade { get; set; }

        // Método para inserir objetos na pilha
        public void Empilhar(string Valor)
        {
            Noh novoNoh = new Noh();    // Novo Noh
            novoNoh.Valor = Valor;      // Adiciona o valor no novo Noh
            novoNoh.Anterior = topo;    // O anterior é o antigo topo
            topo = novoNoh;             // O topo é o novo Noh (Atualizado)
            Quantidade++;               // Atualiza a quantidade

            Console.WriteLine("Item " + Valor + " Inserido!");
        }

        // Esse é o método para Excluir os elementos que estão no topo
        public void Desempilhar()
        {
            if (Quantidade != 0)        // Se eu tiver algum item empilhado
            {
                topo = topo.Anterior;   // Pegue esse item e atribua o valor anterior
                Quantidade--;           // Decremente a quantidade
            }
            else                        // Nenhum item empilhado
            {
                Console.WriteLine("Não há itens para remover");
            }
        }

        // Método para imprimir os objetos, desenpilhando-os
        public void Imprimir()
        {
            Noh nohImpressao = topo;    // Noh com o valor do topo
            int total = Quantidade;     // Quantidade de Nós

            if (total > 0)              // Se o total for maior que zero
            {
                while (total > 0)       // Enquanto o total for maior que zero
                {
                    Console.WriteLine(total.ToString() + " - | " + nohImpressao.Valor + " |");  // Imprima o valor
                    nohImpressao = nohImpressao.Anterior;                                    // Atualize o valor para o Noh Anterior
                    total--;                                                                 // Decremente o total local
                }
            }
            else                        // Se o total for igual a zero
            {
                Console.WriteLine("Pilha Vazia!");
            }
        }
    }
}
