using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Estrutura de dados: Fila Dinâmica.
Aula Ministrado pelo professor Ronnie Marcos Rillo na Fatec de Araçatuba-SP
Autor: Gabriel Gregório da Silva
 */

namespace filaDinamicaEstudos
{
    class Fila
    {
        Noh primeiro = null;                                   // primeiro item da fila
        Noh ultimo = null;                                     // ultimo item da fila
        int quantidade = 0;                                    // Quantidade de itens da lista

        public int Quantidade { get; set; }

        public void Enfileirar(string Valor)
        {
            Noh novoNoh = new Noh();                           // Instância o Noh
            Quantidade++;                                      // Incrementa a quantidade

            if (Quantidade == 1)                               // Adição do primeiro Noh
            {
                novoNoh.Valor = Valor;                         // Adiciona o valor desse Noh
                novoNoh.Frente = null;                         // Adiciona quem está na frente do primeiro Noh
                novoNoh.Atras = null;                          // Adiciona quem está atras do primeiro noh

                primeiro = novoNoh;                            // O primeiro Noh é o primeiro item da fila
                ultimo = novoNoh;                              // O ultimo Noh é o ultimo item da fila
            }
            else                                               // Adição de mais um Noh
            {
                ultimo.Atras = novoNoh;                        // Esse novo Noh agora é o ultimo.
                novoNoh.Valor = Valor;                         // Esse Noh tem esse valor
                novoNoh.Frente = ultimo;                       // o Noh que está na frente desse noh é o ultimo de antes
                novoNoh.Atras = null;                          // Atras desse Noh não tem mais ninguém
                ultimo = novoNoh;                              // O ultimo Noh é o Noh que está sendo adicionado agora
            }
        }

        public void Desenfileirar()
        {
            primeiro = primeiro.Atras;                         // Quem estava atraz do primeiro
            Quantidade--;                                      // Decrementa a quantidade
        }

        public void Imprimir()
        {
            Noh novoInicio = primeiro;                         // Noh com o primeiro elemento
            for (int i = 1; i <= Quantidade; i++)              // loop com a mesma quantidade de itens
            {
                Console.WriteLine(novoInicio.Valor);           // mostra o valor do primeiro elemento de agora
                novoInicio = novoInicio.Atras;                 // faz o valor receber o Noh anterior
            }
        }

        public bool Pesquisar(string valor)
        {
            Noh nohPesquisa = primeiro;                        // Variável com o valor do primeiro Noh
            bool achei = false;                                // Achou o valor?
            int i = 0;                                         // Loop para evitar estouros
            while (i<Quantidade && !achei)                     // Ainda não chegou ao limite ou ainda não encontrou?
            {
                if (nohPesquisa.Valor.CompareTo(valor) == 0)   // Valor do Noh é igual ao valor passado
                {
                    achei = true;                              // Achou o objetivo
                }
                nohPesquisa = nohPesquisa.Atras;               // O Noh recebe quem estava atras dele
                i++;                                           // incrementa contador
            }
            return achei;                                      // Retorna se encontrou o valor pesquisado
        }
    }
}
