### Capitulo 1 - Design Pattern Factory

Aplicando o padrao de projeto factory, que em partes se assemelha muita com o padr�o de projeto builder. Ambos s�o utilizados para diminuir responsabilidades quanto a criacao de um objeto, a diferen�a � que o factory n�o � relacionado com os argumentos de um construtor, como no builder, ele apenas simplifica o processo de cria��o de um objeto, sedimentando sua l�gica em classes externas.

### Capitulo 2 - Design Pattern Flyweight

Aplicando o padrao de projeto Flyweight, implenta-se uma funcionalidade interessante, para aplicacoes que necessitem reutilizar classes, sem ter que instancia-las novamente. Dessa maneira, economiza-se memoria no programa, caso varios instanciamentos sejam demandados. Nesse capitulo, criou-se uma aplicacao que toca musicas, nela seria necessario o instanciamento de varias notas musicais, isso foi otimizado utilizando esse padrao de projeto, ja que as notas iriam se repetir em uma dada musica, dessa maneira eu instancio uma dada classe apenas uma vez e a consumo quantas vezes for necessario. Para realizar esse procedimento de chamada, foi utilizado uma interface padrao do cs, que e a IDictionary, que instancia varios objetos com a classe e a palavra chave de chamada.

### Capitulo 3 - Design Pattern Memento

Aplicando o padrao de projeto Memento, que cria abstracoes com a finalidade de salvar o historico de estados de um determinado objeto.

### Capitulo 4 - Design Pattern Interpreter

Aplicando o padrao de projeto Interpreter, que utiliza a logica de encadeamento de expressoes, como uma ramificacao arborea. Este Padrao é muito util a ser seguido em aplicacoes que precisem realizar calculos matematicos, ou encadeamentos que seguem uma logica de ramificacao com um metodo de analise generico. No codigo do cap4 criou-se a logica de uma calculadora.

### Capitulo 5 - Design Pattern Visitor

O padrao de projeto visitor é um Design Pattern que caminha muito bem com o padrao Interpreter, que possui uma arvore de expressoes e classes encadeadas, pois esse padrao consegue 'visitar' cada um desses elos que ligam as ramificacoes de uma arvore de expressoes, gerando acoes resultantes desejadas durante as passagens, no exemplo desse codigo foi criado uma impressora de expressoes matematicas, que funcionou muiito bem com o codigo anterior, a cada passagem da arvore de expressoes foi feito um print correspondente na tela, para gerar como saida um print resultante da expressao com a formatacao desejada, formatacao essa que foi estruturada com a aplicacao desse design pattern.
Mais especificamente, cada classe, ou expressao, que compoe a arvore integrada com o padrao interpreter, deve implementar um metodo que permitira a 'visita' do Visitor, no caso desse programa em especifico, esse metodo foi chamado de 'Aceita()', e foi declarado na interface que compoe todas as classes utilizadas na arvore de expressoes.

### Capitulo 6 - Design Pattern Bridge

É interessante o uso desse padrao de projeto em momentos em que precisa-se dividir classes que possuem muitas responsabilidades, abstraindo-as utilizando interfaces por exemplo, sendo que essas interfaces possuem alguma dependencia/ relacao/ ponte. No exemplo desse capitulo, criou-se uma necessidade de enviar mensagens com 'n' categorias de destinatario e para 'n' tipos de envio, abstraiu-se os tipos de mensagens e de envios e relacionou-se as classes pai, que no caso foram as suas respectivas interfaces, fazendo um 'bridge' entre elas.

### Capitulo 7 - Design Pattern Command

Uso da fila para processar varios comandos, passível de trabalhar de forma assíncrona :)
