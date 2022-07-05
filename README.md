### Capitulo 1 - Design Pattern Factory

Aplicando o padrao de projeto factory, que em partes se assemelha muita com o padr�o de projeto builder. Ambos s�o utilizados para diminuir responsabilidades quanto a criacao de um objeto, a diferen�a � que o factory n�o � relacionado com os argumentos de um construtor, como no builder, ele apenas simplifica o processo de cria��o de um objeto, sedimentando sua l�gica em classes externas.

### Capitulo 2 - Design Pattern Flyweight

Aplicando o padrao de projeto Flyweight, implenta-se uma funcionalidade interessante, para aplicacoes que necessitem reutilizar classes, sem ter que instancia-las novamente. Dessa maneira, economiza-se memoria no programa, caso varios instanciamentos sejam demandados. Nesse capitulo, criou-se uma aplicacao que toca musicas, nela seria necessario o instanciamento de varias notas musicais, isso foi otimizado utilizando esse padrao de projeto, ja que as notas iriam se repetir em uma dada musica, dessa maneira eu instancio uma dada classe apenas uma vez e a consumo quantas vezes for necessario. Para realizar esse procedimento de chamada, foi utilizado uma interface padrao do cs, que e a IDictionary, que instancia varios objetos com a classe e a palavra chave de chamada.

### Capitulo 3 - Design Pattern Memento

Aplicando o padrao de projeto Memento, que cria abstracoes com a finalidade de salvar o historico de estados de um determinado objeto.

### Capitulo 4 - Design Pattern Memento

Aplicando o padrao de projeto Interpreter, que utiliza a logica de encadeamento de expressoes, como uma ramificacao arborea. Este Padrao é muito util a ser seguido em aplicacoes que precisem realizar calculos matematicos, ou encadeamentos que seguem uma logica de ramificacao com um metodo de analise generico. No codigo do cap4 criou-se a logica de uma calculadora.
