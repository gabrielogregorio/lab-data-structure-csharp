> Os programas contém minhas próprias alterações.

# Estrutura de dados - C#
Vou compartilhar meus aprendizados em estrutura de dados aqui.

## Pilha Estática  

#### Operações** 

**TOP:** acessa-se o elemento posicionado no topo da pilha;   
**PUSH:** insere um novo elemento no topo da pilha;   
**POP:** remove o elemento do topo da pilha.   
**PULL:** altera o elemento posicionado no topo da pilha;   

#### Operações auxiliares 

**INIT:** inicia a pilha como "Vazia"   
**IS_EMPTY:** verifica se a pilha está "Vazia"   
**IS_FULL:** verifica se a pilha está "cheia"   

![Tela Inicial do programa](https://github.com/gabrielogregorio/estrutura_de_dados/blob/master/PilhaEstaticaVisual/tela.png)

## Pilha Dinâmica

* Na pilha dinânica, a aloção e desacolação na memória é feita sob demanda.  
* Cada elemento indicará quem é o seu sucessor, ou seja, quem está de baixo dele.  
* Nós controlamos quem está no topo da memória e cada elemento aponta para quem está debaixo dele.
* topo -apontaPara> anterior -apontaPara> anterior -apontaPara> NULL. Pilha Vazia
