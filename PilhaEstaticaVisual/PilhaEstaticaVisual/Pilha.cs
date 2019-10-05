using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstaticaVisual
{
    class HPilha
    {
        // Projeto de Gabriel Gregório da Silva.
        // github: https://github.com/gabrielogregorio

        string[] valores;  // Vetor com os itens
        int topo = -1;     // Vetor vazio

        public HPilha(int Tamanho) // Método construtor da classe
        {
            valores = new string[Tamanho];
        }

        public bool Cheio() // Lista está cheia?
        {
            if (topo >= (valores.Length -1 ))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string[] Inserir(string Valor)
        {
            if (Cheio())
            {
                topo++;
                valores[topo] = Valor;
            }
            else
            {
                // objeto lotado
            }
            return valores;
        }

        public string[] Excluir()
        {
            if (topo > -1)
            {
                Console.WriteLine("Elemento '" + valores[topo].ToString() + "' excluido");
                topo--;
            }
            else
            {
                Console.WriteLine("A pilha já está vazia!");
            }
            return valores;
        }

        public void Imprimir()
        {
            int auxTopo = topo;

            while (auxTopo > -1)
            {
                Console.WriteLine(valores[auxTopo]);
                auxTopo--;
            }
        }

        public int RetornaTopo()
        {
            return topo;
        }

    }
}
