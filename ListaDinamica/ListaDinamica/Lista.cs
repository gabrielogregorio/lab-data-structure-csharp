using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Estrutura de dados: Lista Dinâmica.
Aula Ministrado pelo professor Ronnie Marcos Rillo na Fatec de Araçatuba-SP
Autor: Gabriel Gregório da Silva
 */

namespace ListaDinamica
{
    class Lista
    {
        /* Descrição dos métodos
         * Inserir (valor)             -> Insere no final da lista
         * Inserir (valor, posicao)    -> Insere em uma posição especifica
         * Excluir (valor)             -> Exclui a primeira posição
         * Excluir (valor, posicao)    -> Exclui em uma posição especifica
         * Pesquisa(valor)             -> Pesquisa por um valor e retorna a posição dele. -1 significa que não foi localizado.
         * Imprimir(valor)             -> Zero imprime do início até o final
         * Imprimir(valor)             -> Um imprime do final ao inicio
         * Ordenação()                 -> Ordena todos o valores
         * Alterar(posicao, novoValor) -> altera um valor de uma posição
        */

        Noh primeiro = null;
        Noh ultimo = null;
        int quantidade = 0;

        public int Quantidade { get; set; }  // Quantidade de itens armazenados

        // Inserir um valor na última posição da lista dinâmica
        public void Inserir(string Valor)
        {
            Noh novoNoh = new Noh();      // Instância o novoNoh    
            Quantidade++;                 // Incrementa a Quantidade

            if (Quantidade == 1)          // Se for o primeiro elemento
            {
                novoNoh.Valor = Valor;    // Insere  valor no novoNoh
                novoNoh.Frente = null;    // Ninguém está na frente do primeiro
                novoNoh.Atras = null;     // Ninguém está atrás do primeiro

                primeiro = novoNoh;       // O novoNoh é o primeiro
                ultimo = novoNoh;         // O novoNoh é o ultimo
            }
            else                          // Já tem elementos inseridos
            {
                ultimo.Atras = novoNoh;   // Atrás do último está o novoNoh
                novoNoh.Valor = Valor;    // Adiciona o valor no novo Noh
                novoNoh.Frente = ultimo;  // Na frente do novoNoh está o ultimo
                novoNoh.Atras = null;     // Atrás do novoNoh não tem ninguém
                ultimo = novoNoh;         // O último é o novoNoh
            }
        }

        // Inserir em uma posição especifica da lista
        public void Inserir(string Valor, int posicao)
        {
            Noh novoNoh = new Noh();                   // Cria uma variável do tipo Noh
            Noh nohInsercao = new Noh();               // Cria uma variável do tipo Noh

            if (posicao == 1)                          // Se o usuário quiser colocar na primeira posição da lista
            {
                novoNoh.Valor = Valor;                 // Adicionar o Valor no novoNoh
                novoNoh.Frente = null;                 // Não tem ninguém na frente do novoNoh que foi inserido no inicio
                novoNoh.Atras = primeiro;              // Quem era o primeiro está atrás do novo Noh, 
                primeiro.Frente = novoNoh;             // Quem está na frente do antigo primeiro é o novoNoh
                primeiro = novoNoh;                    // O primeiro é o novo Noh
            }
            else                                       // Não é a primeira posição
            {
                // Quero inserir na posicao 5.
                // [item1, item2, item3, item4,<novo>, item5, item6, item7]
                // [  1      2      3      4      5      6      7      8  ]
                // [ INICIO          FRENTE <--------> ATRAS          FIM ]

                nohInsercao = primeiro;                // O nohInserção recebe o primeiro Noh

                for (int i = 1; i < posicao - 1; i++)    // Levar o nohInsercao até a posição desejada
                    nohInsercao = nohInsercao.Atras;   // Atualiza o nohInsercao com o valor que está atras dele

                novoNoh.Valor = Valor;                 // Adiciona um valor ao novoNoh
                novoNoh.Frente = nohInsercao;          // O Noh de inserção está na frente do novoNoh
                novoNoh.Atras = nohInsercao.Atras;     // Atrás do novoNoh está quem está atrás do nó de inserção

                nohInsercao.Atras.Frente = novoNoh;    // Na frente do Nó que está atrás do nó de inserção está o novoNoh
                nohInsercao.Atras = novoNoh;           // Atrás do nó de inserção está o novoNoh;
            }
            Quantidade++;                              // atualiza contagem de itens
        }

        // Excluir a primeira posição [Fazer uma revisão]
        public void Excluir()
        {
            if (Quantidade > 1)   // Se a quantidade for maior que 1
            {
                primeiro = primeiro.Atras; // Quem está atrás do primeiro é o primeiro
                primeiro.Frente = null;    // Na frente do primeiro não tem ninguém
                Quantidade--;              // Tem um elemento a menos
            }
            else if (Quantidade == 1) // Se for o ultimo
            {
                primeiro = null;
                ultimo = null;
                Quantidade--;
            }
            else   // Se não tiver mais ninguém
            {
                Console.WriteLine("A lista está vazia!");
            }
        }

        // Excluir em uma posição especifica
        public void Excluir(int posicao)
        {
            // Excluir o primeiro registro
            if (posicao == 1)
            {
                Console.WriteLine("Elemento '" + primeiro.Valor + "' na posição 1 foi Excluído...");
                primeiro.Atras.Frente = null; // Adição própria. ESSA LINHA FOI ADICIONADA....
                primeiro = primeiro.Atras;    // O primeiro agora é quem estava atrás do primeiro
            }
            else
            {
                if (posicao == Quantidade)  // Posição é a ultima
                {
                    Console.WriteLine("Elemento '" + ultimo.Valor + "' na última posição foi Excluido...");
                    ultimo.Frente.Atras = null; // Adição própria. ESSA LINHA FOI ADICIONADA....
                    ultimo = ultimo.Frente;
                }
                else
                {
                    // Quero excluir na posição 5. Use isso como referência
                    // [item1, item2, item3, item4,<item5>, item6, item7, item]
                    // [  1      2      3      4      5      6      7      8  ]
                    // [ INICIO          FRENTE <--------> ATRAS          FIM ]

                    Noh nohExclusao = primeiro;           // O Noh de Exclusão é o primeiro
                    Noh auxFrente = new Noh();            // Noh auxiliar
                    Noh auxAtras = new Noh();             // Noh auxiliar

                    for (int i = 1; i < posicao; i++)     // Posicionando a uma posição anterior do objetivo
                    {
                        auxFrente = nohExclusao;          // Armazena o Noh de Exclusão
                        nohExclusao = nohExclusao.Atras;  // Atualiza para quem está atrás do Noh de Exclusão
                        auxAtras = nohExclusao.Atras;     // Armazena quem está atrás dessa posição
                    }
                    auxFrente.Atras = auxAtras;           // Quem está atrás do noh da frente do objetivo é o noh de tras do objetivo
                    auxAtras.Frente = auxFrente;          // Quem está na frente do Noh atrás do objetivo é o Noh que está na frente do objetivo
                    Quantidade--;                         // decrementa a quantidade de itens
                }
            }
        }

        // Imprimindo os itens da lista
        public void Imprimir(int ordem)
        {
            if (ordem == 0)                                                        // Impressão do primeiro ao ultimo
            {
                Noh nohImpressao = primeiro;                                       // Noh de Impressão é o primeiro

                for (int i = 1; i <= Quantidade; i++)                              // Loop pela quantidade de valores disponíveis na lista
                {
                    Console.WriteLine(i.ToString() + " - " + nohImpressao.Valor);  // Imprime o valor do objeto
                    nohImpressao = nohImpressao.Atras;                             // Atualiza com o Noh que esta atras
                }
            }
            else if (ordem == 1)
            {
                Noh nohImpressao = ultimo;                                         // Noh de impressão é o ultimo

                for (int i = 1; i <= Quantidade; i++)
                {
                    Console.WriteLine(i.ToString() + " - " + nohImpressao.Valor);  // Imprime o valor do objeto
                    nohImpressao = nohImpressao.Frente;                            // Atualiza com o Noh que está na frente
                }
            }
            else
                Console.WriteLine("Digite uma opção válida para a impressão.");
        }

        // Pesquisa por uma valor na lista
        public int Pesquisa(string valor)
        {
            Noh nohPesquisa = primeiro;
            int total = 0;
            int achei = -1;
            if (Quantidade > 0)
            {
                while (achei == -1 && total < Quantidade)              // Ainda não achei e enquanto o total for menor que a quantidade
                {
                    total++;                                     // Incremente o total
                    if (nohPesquisa.Valor.CompareTo(valor) == 0) // O Valor é igual ao valor do noh em analise
                        achei = total;                            // O item foi localizado na lista

                    nohPesquisa = nohPesquisa.Atras;             // O nohPesquisa recebe quem estava atras dele
                }
                if (achei != -1)
                {
                    Console.WriteLine("Achei o " + nohPesquisa.Frente.Valor + " na posição " + total.ToString());
                }
                else
                    Console.WriteLine("Esse item não está na lista!");
            }
            return achei;
        }

        // Ordena os elementos em ordem crescente.
        public void Ordenar()
        {
            Noh nohOrdenacao = primeiro;                               // O noh de ordenação recebe o primeiro Noh
            Noh prox = primeiro.Atras;                                 // O prox recebe quem está atrás do primeiro
            string aux = null;                                         // String auxiliar para troca de posições

            for (int i = 1; i < Quantidade; i++)                       // Ande por todas os itens disponíveis
            {
                for (int j = i + 1; j <= Quantidade; j++)                // ande pelo restante dos itens disponiveis
                {
                    if (nohOrdenacao.Valor.CompareTo(prox.Valor) > 0)  // Se o o próximo for maior que o noh de ordenação
                    {
                        aux = nohOrdenacao.Valor;                      // Armazene o valor do Noh de ordenação na aux
                        nohOrdenacao.Valor = prox.Valor;               // atualize o valor do Noh de ordenacao com o valor do Noh prox
                        prox.Valor = aux;                              // Atualize o valor do prox com o valor da aux
                    }
                    prox = prox.Atras;                                 // Atualize prox com o Noh que está atrás do prox
                }
                nohOrdenacao = nohOrdenacao.Atras;                     // O Noh de ordenação recebe quem esta atras dele
                prox = nohOrdenacao.Atras;                             // O prox recebe quem está Atrás do noh de ordenação
            }
        }

        // Realiza uma alteração no valor em uma dada posição
        public void Alterar(int posicao, string valor)
        {
            Noh nohAlteracao = primeiro;                   // Noh de alteração recebe o primeiro Noh

            if (posicao == 1)                              // Se for na primeira posição
                nohAlteracao.Valor = valor;                // Ele mesmo recebe o novo valor
            else                                           // Se não for na primeira posição
            {
                if (posicao == Quantidade)                 // Se for para alterar na última posição
                    ultimo.Valor = valor;                  // altere o valor do último Noh
                else                                       // Se não for o ultimo
                {
                    for (int i = 1; i < posicao; i++)      // Ande pelos valores disponíveis até a posição
                        nohAlteracao = nohAlteracao.Atras; // Atualize o Noh de alteração com os valores que estão atraz dele
                    nohAlteracao.Valor = valor;            // Atualize o valor da posição
                }
            }
        }
    }
}
